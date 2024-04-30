using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using SoftwareIIb.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareIIb
{
    public partial class Form2 : Form
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

        public Form2()
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

            _data.Tables.Add(_db.appointments.Local.ToBindingList().ToDataTable());
            DataView dataView1 = new DataView(_data.Tables[0]);

            gvcodb.DataSource = _db.countries.Local.ToBindingList();
            gvcidb.DataSource = _db.cities.Local.ToBindingList();
            gvaddb.DataSource = _db.addresses.Local.ToBindingList();
            gvcudb.DataSource = _db.customers.Local.ToBindingList();
            gvudb.DataSource = _db.users.Local.ToBindingList();
            gvapdb.DataSource = _db.appointments.Local.ToBindingList();

            countryBindingSource.DataSource = gvcodb;
            cityBindingSource.DataSource = gvcidb;
            addressBindingSource.DataSource = gvaddb;
            userBindingSource.DataSource = gvudb;
            appointmentBindingSource.DataSource = gvapdb;
            customerBindingSource.DataSource = gvcudb;
        }

        string myConnectionString = "server=localhost;port=3306;username=root;password=Passw0rd!;database=client_schedule";

        private void NewReport_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new();
            form1.Show();
            this.Hide();
        }

        private void btnRunAppTypeReport_Click(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            DateTime dt30Days = DateTime.Now.AddDays(30);
            string type = cbAppointmentType.Text;

            gvapdb.DataSource = new ObservableCollection<appointment>(
                _db.appointments.Where(x => x.type == type && x.start >= dtNow && x.start <= dt30Days)
            ).ToBindingList();
            if (((ObservableBackedBindingList<appointment>)gvapdb.DataSource).Count > 0)
            {
                DVGNewReport.DataSource = null;
                DVGNewReport.Columns.Clear();
                DVGNewReport.AutoGenerateColumns = true;
                DVGNewReport.DataSource = gvapdb;
                DVGNewReport.AutoGenerateColumns = false;
                DVGNewReport.Columns[0].HeaderText = "Appointment ID";
                DVGNewReport.Columns[1].Visible = false;
                DVGNewReport.Columns[2].Visible = false;
                DVGNewReport.Columns[3].HeaderText = "Title";
                DVGNewReport.Columns[4].HeaderText = "Description";
                DVGNewReport.Columns[5].HeaderText = "Location";
                DVGNewReport.Columns[6].HeaderText = "Contact";
                DVGNewReport.Columns[7].HeaderText = "Type";
                DVGNewReport.Columns[8].HeaderText = "Customer";
                DVGNewReport.Columns[9].HeaderText = "Start";
                DVGNewReport.Columns[10].HeaderText = "End";
                DVGNewReport.Columns[11].Visible = false;
                DVGNewReport.Columns[12].Visible = false;
                DVGNewReport.Columns[13].Visible = false;
                DVGNewReport.Columns[14].Visible = false;

            }
        }

        private void btnRunConsultantReport_Click(object sender, EventArgs e)
        {
            string userName = cbConsultant.Text;

            int userID = _db.users.First(x => x.userName == userName).userId;

            gvapdb.DataSource = new ObservableCollection<appointment>(
                _db.appointments.Where(x => x.userId == userID)
            ).ToBindingList();
            if (((ObservableBackedBindingList<appointment>)gvapdb.DataSource).Count > 0)
            {
                DVGNewReport.DataSource = null;
                DVGNewReport.Columns.Clear();
                DVGNewReport.AutoGenerateColumns = true;
                DVGNewReport.DataSource = gvapdb;
                DVGNewReport.AutoGenerateColumns = false;
                DVGNewReport.Columns[0].HeaderText = "Appointment ID";
                DVGNewReport.Columns[1].Visible = false;
                DVGNewReport.Columns[2].Visible = false;
                DVGNewReport.Columns[3].HeaderText = "Title";
                DVGNewReport.Columns[4].HeaderText = "Description";
                DVGNewReport.Columns[5].HeaderText = "Location";
                DVGNewReport.Columns[6].HeaderText = "Contact";
                DVGNewReport.Columns[7].HeaderText = "Type";
                DVGNewReport.Columns[8].HeaderText = "Customer";
                DVGNewReport.Columns[9].HeaderText = "Start";
                DVGNewReport.Columns[10].HeaderText = "End";
                DVGNewReport.Columns[11].Visible = false;
                DVGNewReport.Columns[12].Visible = false;
                DVGNewReport.Columns[13].Visible = false;
                DVGNewReport.Columns[14].Visible = false;
            }
        }

        private void btnRunCustomerReport_Click(object sender, EventArgs e)
        {
            string customerName = cbCustomer.Text;

            //getting customerID for the appointment sql statement below 
            int customerID = _db.customers.First(x => x.customerName == customerName).customerId;

            gvapdb.DataSource = new ObservableCollection<appointment>(
                _db.appointments.Where(x => x.customerId == customerID)
            );
            if (((ObservableCollection<appointment>)gvapdb.DataSource).Count() > 0)
            {
                DVGNewReport.DataSource = null;
                DVGNewReport.Columns.Clear();
                DVGNewReport.AutoGenerateColumns = true;
                DVGNewReport.DataSource = gvapdb;
                DVGNewReport.AutoGenerateColumns = false;
                DVGNewReport.Columns[0].HeaderText = "Appointment ID";
                DVGNewReport.Columns[1].Visible = false;
                DVGNewReport.Columns[2].Visible = false;
                DVGNewReport.Columns[3].HeaderText = "Title";
                DVGNewReport.Columns[4].HeaderText = "Description";
                DVGNewReport.Columns[5].HeaderText = "Location";
                DVGNewReport.Columns[6].HeaderText = "Contact";
                DVGNewReport.Columns[7].HeaderText = "Type";
                DVGNewReport.Columns[8].HeaderText = "Customer";
                DVGNewReport.Columns[9].HeaderText = "Start";
                DVGNewReport.Columns[10].HeaderText = "End";
                DVGNewReport.Columns[11].Visible = false;
                DVGNewReport.Columns[12].Visible = false;
                DVGNewReport.Columns[13].Visible = false;
                DVGNewReport.Columns[14].Visible = false;
            }
        }

    }
}
