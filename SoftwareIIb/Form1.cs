using SoftwareIIb.DAL.Models;
using SoftwareIIb.Exceptions;
using SoftwareIIb.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySqlX.XDevAPI;
using System.Threading;
//using Microsoft.Extensions.Configuration;

namespace SoftwareIIb
{
    public partial class Form1 : Form
    {
        private readonly SchedulingSoftware _db;
        private BindingSource gvcudb = []; //customer
        private BindingSource gvaddb = []; //address
        private BindingSource gvcodb = []; //country
        private BindingSource gvcidb = []; //city
        private BindingSource gvudb = [];  //user
        private BindingSource gvapdb = []; //appointment
        private DataSet _data = new DataSet();
        private Task _timerTask;
        CancellationTokenSource _cancellationTokenSource;
        PeriodicTimer _periodicTimer;

        public Form1()
        {
            _db = new SchedulingSoftware(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
            _db.Database.Migrate();
            InitializeComponent();
            _db.countries.Load();
            _db.cities.Load();
            _db.addresses.Load();
            _db.customers.Load();
            _db.appointments.Load();
            _db.users.Load();

            _cancellationTokenSource = new();
            _periodicTimer = new(TimeSpan.FromMinutes(1));
            _timerTask = HandleTimerAsync(_periodicTimer, _cancellationTokenSource.Token);

            _data.Tables.Add(_db.appointments.Local.ToBindingList().ToDataTable());
            DataView dataView1 = new DataView(_data.Tables[0]);

            gvcodb.DataSource = _db.countries.Local.ToBindingList();
            //.ToBindingList();
            gvcidb.DataSource = _db.cities.Local.ToBindingList();
            //.ToBindingList();
            gvaddb.DataSource = _db.addresses.Local.ToBindingList();
            //.ToBindingList();
            gvcudb.DataSource = _db.customers.Local.ToBindingList();
            //.ToBindingList();
            gvudb.DataSource = _db.users.Local.ToBindingList();
            //.ToBindingList();
            gvapdb.DataSource = _db.appointments.Local.ToBindingList();
            //dataView1;    
            //_db.appointments.Local;
            //.ToBindingList();

            countryBindingSource.DataSource = gvcodb;
            cityBindingSource.DataSource = gvcidb;
            addressBindingSource.DataSource = gvaddb;
            userBindingSource.DataSource = gvudb;
            appointmentBindingSource.DataSource = gvapdb;
            customerBindingSource.DataSource = gvcudb;
        }

        public void Cancel() => _cancellationTokenSource.Cancel();

        async Task HandleTimerAsync(PeriodicTimer timer, CancellationToken cancel = default)
        {
            try
            {
                while (await timer.WaitForNextTickAsync(cancel))
                {
                    await Task.Run(() =>
                    {
                        DateTime targTime = DateTime.Now.AddMinutes(15);
                        if (_db.appointments.ToList()
                            .Any(x => x.userId == Authenticator.currentUser.userId && 
                                x.start.ToLocalTime() <= targTime
                            ))
                        {
                            MessageBox.Show("You have an appointment starting soon");
                        }
                    },
                    cancel);
                }
            }
            catch (Exception ex)
            {
                //Handle exception without propagating
            }
        }

        public async ValueTask DisposeAsync()
        {
            _periodicTimer.Dispose();
            await _timerTask;
            GC.SuppressFinalize(this);
        }

        private void controlTabsEnabled()
        {
            foreach (TabPage item in tabControl1.TabPages)
            {
                switch (item.Text)
                {
                    case "Countries":
                        item.Enabled = true;
                        break;
                    case "Cities":
                        item.Enabled = _db.countries.Count() > 0;
                        if (!item.Enabled) throw new TabUnavailableException("You must have at least 1 country defined to use this tab");
                        break;
                    case "Addresses":
                        item.Enabled = _db.cities.Count() > 0;
                        if (!item.Enabled) throw new TabUnavailableException("You must have at least 1 city defined to use this tab");
                        break;
                    case "Customer Records":
                        item.Enabled = _db.addresses.Count() > 0;
                        if (!item.Enabled) throw new TabUnavailableException("You must have at least 1 address defined to use this tab");
                        break;
                    case "Appointments":
                        item.Enabled = _db.customers.Count() > 0 && _db.users.Count() > 0;
                        if (!item.Enabled) throw new TabUnavailableException("You must have at least 1 customer and 1 user defined to use this tab");
                        break;
                };
            }
        }

        private void tabController_Selecting(object sender, TabControlCancelEventArgs e)
        {
            string msg;
            if (e.TabPageIndex < 0) return;
            try
            {
                controlTabsEnabled();
            }
            catch (TabUnavailableException te)
            {
                if (!e.TabPage.Enabled) MessageBox.Show(te.Message);
            }
            e.Cancel = !e.TabPage.Enabled;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schedulingSoftwareDataSet.customer' table. You can move, or remove it, as needed.
            //this.customerNameInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", ((customer)dataGridView1.CurrentRow.DataBoundItem), "customerName", true));
            //addressinput.databindings.add(new system.windows.forms.binding("text", ((customer)datagridview1.currentrow.databounditem).address, "address1", true));
            //address2Input.DataBindings.Add(new System.Windows.Forms.Binding("Text", ((customer)dataGridView1.CurrentRow.DataBoundItem).address, "address2", true));
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _db.Dispose();
            Application.Exit();
        }

        private void customersbc(object sender, EventArgs e)
        {
            saveButton_Click<customer>(sender, e);
        }

        private void countrysbc(object sender, EventArgs e)
        {
            saveButton_Click<country>(sender, e);
        }

        private void citysbc(object sender, EventArgs e)
        {
            saveButton_Click<city>(sender, e);
        }

        private void addresssbc(object sender, EventArgs e)
        {
            saveButton_Click<address>(sender, e);
        }

        private void appointmentsbc(object sender, EventArgs e)
        {
            saveButton_Click<appointment>(sender, e);
        }

        private void customercbc(object sender, EventArgs e)
        {
            cancelButton_Click<customer>(sender, e);
        }

        private void countrycbc(object sender, EventArgs e)
        {
            cancelButton_Click<country>(sender, e);
        }

        private void citycbc(object sender, EventArgs e)
        {
            cancelButton_Click<city>(sender, e);
        }

        private void addresscbc(object sender, EventArgs e)
        {
            cancelButton_Click<address>(sender, e);
        }

        private void appointmentcbc(object sender, EventArgs e)
        {
            cancelButton_Click<appointment>(sender, e);
        }

        private void saveButton_Click<T>(object sender, EventArgs e) where T : AModel
        {   // get added
            DateTime cdate = DateTime.Now;
            _db.ChangeTracker.Entries<T>().ToList().Where(x => x.State == EntityState.Added).ToList().ForEach(c =>
            {
                ((AModel)c.Entity).createDate = c.Entity.lastUpdate = cdate;
                c.Entity.createdBy = c.Entity.lastUpdateBy = Authenticator.currentUser.userName;

            });
            //get updated
            _db.ChangeTracker.Entries<T>().ToList().Where(x => x.State == EntityState.Modified).ToList().ForEach(c =>
            {
                c.Entity.lastUpdate = DateTime.Now;
                c.Entity.lastUpdateBy = Authenticator.currentUser.userName;
            });

            // Save the changes
            _db.SaveChanges<T>();
        }

        private void cancelButton_Click<T>(object sender, EventArgs e) where T : AModel
        {
            _db.ChangeTracker.Entries<T>().ToList().Where(x => x.State != EntityState.Unchanged).ToList().ForEach(c =>
            {
                switch (c.State)
                {
                    case EntityState.Modified:
                        c.CurrentValues.SetValues(c.OriginalValues);
                        c.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                    case EntityState.Added:
                        c.State = EntityState.Unchanged;
                        break;
                }
            });
        }

        private void countryGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["country1"].Value = "new country";
        }

        private void cityGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["city1"].Value = "new city";
            e.Row.Cells["countryId"].Value = _db.countries.First().countryId;
        }

        private void addressGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["address1"].Value = "new";
            e.Row.Cells["address2"].Value = string.Empty;
            e.Row.Cells["cityId"].Value = _db.cities.First().cityId;
            e.Row.Cells["postalCode"].Value = string.Empty;
            e.Row.Cells["phone"].Value = string.Empty;
        }

        private void customerGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["customerName"].Value = string.Empty;
            e.Row.Cells["active"].Value = true;
            e.Row.Cells["addressId"].Value = _db.addresses.First().addressId;
        }

        private void appointmentGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["customerId"].Value = _db.customers.First().customerId;
            e.Row.Cells["userId"].Value = _db.users.First().userId;
            e.Row.Cells["start"].Value = DateTime.UtcNow;
            e.Row.Cells["end"].Value = ((DateTime)e.Row.Cells["start"].Value).AddMinutes(15);
        }

        private void weekRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                DateTime start = DateTime.Now;
                DateTime weekOut = DateTime.Now.AddDays(7);
                gvapdb.DataSource = new ObservableCollection<appointment>(
                    _db.appointments.Where(ap => ap.start >= start && ap.start <= weekOut)
                ).ToBindingList();
                appointmentGridView.Refresh();
            }
        }

        private void monthRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                DateTime start = DateTime.Now;
                DateTime monthOut = DateTime.Now.AddMonths(1);
                gvapdb.DataSource = new ObservableCollection<appointment>(
                    _db.appointments.Where(ap => ap.start >= start && ap.start <= monthOut)
                ).ToBindingList();
                appointmentGridView.Refresh();
            }
        }

        private void allRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                gvapdb.DataSource = _db.appointments.Local.ToBindingList();
                appointmentGridView.Refresh();
            }
        }

        private void appointmentGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            bool error = false;
            // you can obtain current editing value like this:
            var currentCell = appointmentGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            appointment currentRecord = (appointment)currentCell.OwningRow.DataBoundItem;
            string message = string.Empty;

            object current = appointmentGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            switch (appointmentGridView.Columns[e.ColumnIndex].HeaderText)
            {
                case "start":
                case "end":
                    if (error = badStartEnd(currentRecord.start, currentRecord.end))
                    {
                        message = "Start time must be before end time";
                    }
                    else if (error = overlapping(currentRecord.start, currentRecord.end))
                    {
                        message = "This appointment overlaps with an existing appointment";
                    }
                    else if (error = outsideHours(currentRecord.start, currentRecord.end))
                    {
                        message = "Appointment starts or ends outside of regular business hours";
                    }
                    break;
            }
            if (error)
            {
                MessageBox.Show(message);
                e.Cancel = true;
            }
        }

        private bool badStartEnd(DateTime start, DateTime end)
        {
            return start > end || end < start || start == end;
        }

        private bool overlapping(DateTime start, DateTime end)
        {
            return _db.appointments.Any(x => start >= x.start && start < x.end) || _db.appointments.Any(x => end > x.start && end <= x.end);
        }
        private bool outsideHours(DateTime start, DateTime end)
        {
            var b = start.ToLocalTime().TimeOfDay;
            var e = end.ToLocalTime().TimeOfDay;

            bool error = false;
            TimeSpan businessStartTime, businessEndTime;
            businessStartTime = new TimeSpan(08, 00, 00);
            businessEndTime = new TimeSpan(17, 30, 00);
            return b < businessStartTime || e > businessEndTime;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            form2.ShowDialog();
        }
    }
}
