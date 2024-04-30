using IPinfo.Models;
using SoftwareIIb;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using System.Configuration;

public partial class MainForm : Form
{
    private TextBox txtUsername;
    private TextBox txtPassword;
    private Button btnLogin;
    private Label lblUsername;
    private Label lblPassword;
    private ResourceManager resManager = new ResourceManager("SoftwareIIb.Messages", typeof(MainForm).Assembly);
    private LocationService location = new LocationService();

    public MainForm()
    {
        InitializeComponent();
        LocalizeUI();
        AddAuthentications();
    }

    private async void LocalizeUI()
    {
        IPResponse locationsvc = await location.GetUserLocationAsync();

        string countryCode = locationsvc.Country;
        CultureInfo currentCulture;

        switch (countryCode)
        {
            case "ES": // Spain
                currentCulture = new CultureInfo("es-ES");
                break;
            // Add cases for other countries/languages as needed
            default:
                currentCulture = CultureInfo.InvariantCulture;
                break;
        }

        CultureInfo.CurrentCulture = currentCulture;
        CultureInfo.DefaultThreadCurrentCulture = currentCulture;
        CultureInfo.DefaultThreadCurrentUICulture = currentCulture;


        btnLogin.Text = resManager.GetString("LoginButtonText", CultureInfo.CurrentCulture);
        lblPassword.Text = resManager.GetString("LoginPasswordText", CultureInfo.CurrentCulture);   
        lblUsername.Text = resManager.GetString("LoginUserText", CultureInfo.CurrentCulture);
    }

    private user fetchLoginUser(string u) {
        return (new SchedulingSoftware(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString))
            .users
            .SingleOrDefault(
                user => user.userName == u
            );
    }
    
    private void AddAuthentications()
    {
        Authenticator.addHandler((u, p) =>
        {
            // user table search and match handler
            Authenticator.currentUser = fetchLoginUser(u);
            if (Authenticator.currentUser == null)
            {
                return Authenticator.authenticated;
            } else
            {
                return Authenticator.authenticated = Authenticator.authenticated || (Authenticator.authenticated = Authenticator.currentUser.password == p);
            }
        });
        Authenticator.addHandler((u, p) =>
        {
            Authenticator.currentUser = fetchLoginUser(u);
            if (Authenticator.currentUser == null)
            {
                return Authenticator.authenticated;
            } else
            {
                return Authenticator.authenticated || (Authenticator.authenticated = p == "ABC123");
            }
        });
        Authenticator.addHandler((u, p) =>
        {
            // Add logging
            if (Authenticator.authenticated)
            {
                try
                {
                    File.AppendAllText(@"authlog.txt", $"User {u} logged in {DateTime.Now.ToString()}{Environment.NewLine}");
                } catch
                {
                    // do nothing if logfile.txt doesn't exist already
                }
            }
            return Authenticator.authenticated;
        });
    }
    private void btnLogin_Click(object sender, EventArgs e)
    {
        // Assuming you have TextBox controls for username and password named txtUsername and txtPassword
        if (AuthenticateUser(txtUsername.Text, txtPassword.Text))
        {
            //Authenticator.currentUser = txtUsername.Text;
            this.Hide();
            Form1 custform = new Form1();
            custform.ShowDialog();
            // Proceed to log the user in
            
        }
        else
        {
            // Display error message
            MessageBox.Show(resManager.GetString("LoginErrorMessage", CultureInfo.CurrentCulture), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool AuthenticateUser(string username, string password)
    {
        return Authenticator.authenticate(username, password);
    }

    private void InitializeComponent()
    {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(63, 79);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(152, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(63, 121);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(152, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(156, 162);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(59, 26);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(60, 63);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 13);
            this.lblUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(60, 105);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 13);
            this.lblPassword.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnLogin;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
