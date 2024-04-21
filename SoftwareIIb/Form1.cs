using SoftwareIIb.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareIIb
{
    public partial class Form1 : Form
    {
        private SchedulingSoftware _db = new SchedulingSoftware();

        public Form1()
        {
            InitializeComponent();
        }

        private void controlTabsEnabled()
        {
            foreach (TabPage item in tabControl1.TabPages)
            {
                switch (item.Text) {
                    case "countries":
                        item.Enabled = true;
                        break;
                    case "cities":
                        item.Enabled = countryDataGridView.Rows.Count > 0;
                        break;
                    case "addresses":
                        item.Enabled = cityDataGridView.Rows.Count > 0;
                        break;
                    case "customers":
                        item.Enabled = addressDataGridView.Rows.Count > 0;
                        break;
                    case "appointments":
                        item.Enabled = dataGridView1.Rows.Count > 0;
                        break;
                };
            }
        }

        private void tabController_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex < 0) return;
            controlTabsEnabled();
            e.Cancel = !e.TabPage.Enabled;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schedulingSoftwareDataSet.customer' table. You can move, or remove it, as needed.
            _db.countries.Load();
            _db.cities.Load();
            _db.addresses.Load();
            _db.customers.Load();
            _db.appointments.Load();

            BindingSource gvdb = new BindingSource();
            BindingSource gvaddb = new BindingSource();
            BindingSource gvcodb = new BindingSource();
            BindingSource gvcidb = new BindingSource();

            gvcodb.DataSource = _db.countries.Local.ToBindingList();
            gvcidb.DataSource = _db.cities.Local.ToBindingList();
            gvaddb.DataSource = _db.addresses.Local.ToBindingList();
            gvdb.DataSource = _db.customers.Local.ToBindingList();

            countryBindingSource.DataSource = gvcodb;
            cityBindingSource.DataSource = gvcidb;
            addressBindingSource.DataSource = gvaddb;
            //addressId.DataSource = gvaddb;
            dataGridView1.DataSource = gvdb;

            //this.customerNameInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", ((customer)dataGridView1.CurrentRow.DataBoundItem), "customerName", true));
            //addressinput.databindings.add(new system.windows.forms.binding("text", ((customer)datagridview1.currentrow.databounditem).address, "address1", true));
            //address2Input.DataBindings.Add(new System.Windows.Forms.Binding("Text", ((customer)dataGridView1.CurrentRow.DataBoundItem).address, "address2", true));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            customer foo = new customer {
                address = new address
                {
                    city = new city
                    {
                        country = new country()
                    }
                }
            };
            _db.customers.Add(foo);
            //dataGridView1.Refresh();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _db.Dispose();
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

        private void customercbc(object sender, EventArgs e)
        {
            cancelButton_Click<customer>(sender, e);
        }

        private void countrycbc(object sender, EventArgs e)
        {
            cancelButton_Click<country>(sender,e);
        }

        private void citycbc(object sender, EventArgs e)
        {
            cancelButton_Click<city>(sender, e);
        }

        private void addresscbc(object sender, EventArgs e)
        {
            cancelButton_Click<address>(sender, e);
        }

        private void saveButton_Click<T>(object sender, EventArgs e) where T : AModel
        {   // get added
            DateTime cdate = DateTime.Now;
            _db.ChangeTracker.Entries<T>().ToList().Where(x => x.State == EntityState.Added).ToList().ForEach(c =>
            {
                ((AModel)c.Entity).createDate = c.Entity.lastUpdate = cdate;
                c.Entity.createdBy = c.Entity.lastUpdateBy = Authenticator.currentUser;

            });
            //get updated
            _db.ChangeTracker.Entries<T>().ToList().Where(x => x.State == EntityState.Modified).ToList().ForEach(c => {
                c.Entity.lastUpdate = DateTime.Now;
                c.Entity.lastUpdateBy = Authenticator.currentUser;
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

        private void countryDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["country"].Value = "new country";
        }

        private void cityDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["city1"].Value = "new city";
            e.Row.Cells["countryId"].Value = _db.countries.First().countryId;
        }

        private void addressDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["address1"].Value = "new";
            e.Row.Cells["address2"].Value = string.Empty;
            e.Row.Cells["cityId"].Value = _db.cities.First().cityId;
            e.Row.Cells["postalCode"].Value = string.Empty;
            e.Row.Cells["phone"].Value = string.Empty;
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["customerName1"].Value = string.Empty;
            e.Row.Cells["active1"].Value = true;
            e.Row.Cells["addressId"].Value = _db.addresses.First().addressId;
        }
    }
}
