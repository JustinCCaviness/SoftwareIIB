namespace SoftwareIIb
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.countriesTab = new System.Windows.Forms.TabPage();
            this.countrySaveButton = new System.Windows.Forms.Button();
            this.countryCancelButton = new System.Windows.Forms.Button();
            this.countryGridView = new System.Windows.Forms.DataGridView();
            this.country1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesTab = new System.Windows.Forms.TabPage();
            this.citySaveButton = new System.Windows.Forms.Button();
            this.cityCancelButton = new System.Windows.Forms.Button();
            this.cityGridView = new System.Windows.Forms.DataGridView();
            this.city1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cityKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTab = new System.Windows.Forms.TabPage();
            this.addressSaveButton = new System.Windows.Forms.Button();
            this.addressCancelButton = new System.Windows.Forms.Button();
            this.addressGridView = new System.Windows.Forms.DataGridView();
            this.address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.postalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTab = new System.Windows.Forms.TabPage();
            this.customerSaveButton = new System.Windows.Forms.Button();
            this.customerCancelButton = new System.Windows.Forms.Button();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.addressId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customerKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTab = new System.Windows.Forms.TabPage();
            this.appointmentSaveButton = new System.Windows.Forms.Button();
            this.appointmentCancelButton = new System.Windows.Forms.Button();
            this.appointmentGridView = new System.Windows.Forms.DataGridView();
            this.customerId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.countriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.citiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.addressTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.customerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.appointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.countriesTab);
            this.tabControl1.Controls.Add(this.citiesTab);
            this.tabControl1.Controls.Add(this.addressTab);
            this.tabControl1.Controls.Add(this.customerTab);
            this.tabControl1.Controls.Add(this.appointmentsTab);
            this.tabControl1.Location = new System.Drawing.Point(8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 431);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabController_Selecting);
            // 
            // countriesTab
            // 
            this.countriesTab.Controls.Add(this.countrySaveButton);
            this.countriesTab.Controls.Add(this.countryCancelButton);
            this.countriesTab.Controls.Add(this.countryGridView);
            this.countriesTab.Location = new System.Drawing.Point(4, 22);
            this.countriesTab.Name = "countriesTab";
            this.countriesTab.Size = new System.Drawing.Size(772, 405);
            this.countriesTab.TabIndex = 4;
            this.countriesTab.Text = "Countries";
            this.countriesTab.UseVisualStyleBackColor = true;
            // 
            // countrySaveButton
            // 
            this.countrySaveButton.Location = new System.Drawing.Point(699, 374);
            this.countrySaveButton.Name = "countrySaveButton";
            this.countrySaveButton.Size = new System.Drawing.Size(70, 26);
            this.countrySaveButton.TabIndex = 8;
            this.countrySaveButton.Text = "Save";
            this.countrySaveButton.UseVisualStyleBackColor = true;
            this.countrySaveButton.Click += new System.EventHandler(this.countrysbc);
            // 
            // countryCancelButton
            // 
            this.countryCancelButton.Location = new System.Drawing.Point(623, 373);
            this.countryCancelButton.Name = "countryCancelButton";
            this.countryCancelButton.Size = new System.Drawing.Size(70, 26);
            this.countryCancelButton.TabIndex = 7;
            this.countryCancelButton.Text = "Cancel";
            this.countryCancelButton.UseVisualStyleBackColor = true;
            this.countryCancelButton.Click += new System.EventHandler(this.countrycbc);
            // 
            // countryGridView
            // 
            this.countryGridView.AutoGenerateColumns = false;
            this.countryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.country1,
            this.countryKey});
            this.countryGridView.DataSource = this.countryBindingSource;
            this.countryGridView.Location = new System.Drawing.Point(0, 0);
            this.countryGridView.Name = "countryGridView";
            this.countryGridView.Size = new System.Drawing.Size(772, 368);
            this.countryGridView.TabIndex = 5;
            this.countryGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.countryGridView_DefaultValuesNeeded);
            // 
            // country1
            // 
            this.country1.DataPropertyName = "country1";
            this.country1.HeaderText = "country";
            this.country1.Name = "country1";
            // 
            // countryKey
            // 
            this.countryKey.DataPropertyName = "countryId";
            this.countryKey.HeaderText = "countryId";
            this.countryKey.Name = "countryKey";
            this.countryKey.Visible = false;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(SoftwareIIb.country);
            // 
            // citiesTab
            // 
            this.citiesTab.Controls.Add(this.citySaveButton);
            this.citiesTab.Controls.Add(this.cityCancelButton);
            this.citiesTab.Controls.Add(this.cityGridView);
            this.citiesTab.Location = new System.Drawing.Point(4, 22);
            this.citiesTab.Name = "citiesTab";
            this.citiesTab.Size = new System.Drawing.Size(772, 405);
            this.citiesTab.TabIndex = 3;
            this.citiesTab.Text = "Cities";
            this.citiesTab.UseVisualStyleBackColor = true;
            // 
            // citySaveButton
            // 
            this.citySaveButton.Location = new System.Drawing.Point(699, 374);
            this.citySaveButton.Name = "citySaveButton";
            this.citySaveButton.Size = new System.Drawing.Size(70, 26);
            this.citySaveButton.TabIndex = 8;
            this.citySaveButton.Text = "Save";
            this.citySaveButton.UseVisualStyleBackColor = true;
            this.citySaveButton.Click += new System.EventHandler(this.citysbc);
            // 
            // cityCancelButton
            // 
            this.cityCancelButton.Location = new System.Drawing.Point(623, 373);
            this.cityCancelButton.Name = "cityCancelButton";
            this.cityCancelButton.Size = new System.Drawing.Size(70, 26);
            this.cityCancelButton.TabIndex = 7;
            this.cityCancelButton.Text = "Cancel";
            this.cityCancelButton.UseVisualStyleBackColor = true;
            this.cityCancelButton.Click += new System.EventHandler(this.citycbc);
            // 
            // cityGridView
            // 
            this.cityGridView.AutoGenerateColumns = false;
            this.cityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.city1,
            this.countryId,
            this.cityKey});
            this.cityGridView.DataSource = this.cityBindingSource;
            this.cityGridView.Location = new System.Drawing.Point(0, 0);
            this.cityGridView.Name = "cityGridView";
            this.cityGridView.Size = new System.Drawing.Size(772, 368);
            this.cityGridView.TabIndex = 5;
            this.cityGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.cityGridView_DefaultValuesNeeded);
            // 
            // city1
            // 
            this.city1.DataPropertyName = "city1";
            this.city1.HeaderText = "city";
            this.city1.Name = "city1";
            // 
            // countryId
            // 
            this.countryId.DataPropertyName = "countryId";
            this.countryId.DataSource = this.countryBindingSource;
            this.countryId.DisplayMember = "country1";
            this.countryId.HeaderText = "country";
            this.countryId.Name = "countryId";
            this.countryId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countryId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.countryId.ValueMember = "countryId";
            // 
            // cityKey
            // 
            this.cityKey.DataPropertyName = "cityId";
            this.cityKey.HeaderText = "cityId";
            this.cityKey.Name = "cityKey";
            this.cityKey.Visible = false;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(SoftwareIIb.city);
            // 
            // addressTab
            // 
            this.addressTab.Controls.Add(this.addressSaveButton);
            this.addressTab.Controls.Add(this.addressCancelButton);
            this.addressTab.Controls.Add(this.addressGridView);
            this.addressTab.Location = new System.Drawing.Point(4, 22);
            this.addressTab.Name = "addressTab";
            this.addressTab.Size = new System.Drawing.Size(772, 405);
            this.addressTab.TabIndex = 2;
            this.addressTab.Text = "Addresses";
            this.addressTab.UseVisualStyleBackColor = true;
            // 
            // addressSaveButton
            // 
            this.addressSaveButton.Location = new System.Drawing.Point(699, 374);
            this.addressSaveButton.Name = "addressSaveButton";
            this.addressSaveButton.Size = new System.Drawing.Size(70, 26);
            this.addressSaveButton.TabIndex = 8;
            this.addressSaveButton.Text = "Save";
            this.addressSaveButton.UseVisualStyleBackColor = true;
            this.addressSaveButton.Click += new System.EventHandler(this.addresssbc);
            // 
            // addressCancelButton
            // 
            this.addressCancelButton.Location = new System.Drawing.Point(623, 373);
            this.addressCancelButton.Name = "addressCancelButton";
            this.addressCancelButton.Size = new System.Drawing.Size(70, 26);
            this.addressCancelButton.TabIndex = 7;
            this.addressCancelButton.Text = "Cancel";
            this.addressCancelButton.UseVisualStyleBackColor = true;
            this.addressCancelButton.Click += new System.EventHandler(this.addresscbc);
            // 
            // addressGridView
            // 
            this.addressGridView.AutoGenerateColumns = false;
            this.addressGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.address1,
            this.address2,
            this.cityId,
            this.postalCode,
            this.phone,
            this.addressKey});
            this.addressGridView.DataSource = this.addressBindingSource;
            this.addressGridView.Location = new System.Drawing.Point(0, 0);
            this.addressGridView.Name = "addressGridView";
            this.addressGridView.Size = new System.Drawing.Size(772, 368);
            this.addressGridView.TabIndex = 5;
            this.addressGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.addressGridView_DefaultValuesNeeded);
            // 
            // address1
            // 
            this.address1.DataPropertyName = "address1";
            this.address1.HeaderText = "address";
            this.address1.Name = "address1";
            // 
            // address2
            // 
            this.address2.DataPropertyName = "address2";
            this.address2.HeaderText = "address2";
            this.address2.Name = "address2";
            // 
            // cityId
            // 
            this.cityId.DataPropertyName = "cityId";
            this.cityId.DataSource = this.cityBindingSource;
            this.cityId.DisplayMember = "city1";
            this.cityId.HeaderText = "city";
            this.cityId.Name = "cityId";
            this.cityId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cityId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cityId.ValueMember = "cityId";
            // 
            // postalCode
            // 
            this.postalCode.DataPropertyName = "postalCode";
            this.postalCode.HeaderText = "postalCode";
            this.postalCode.Name = "postalCode";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            // 
            // addressKey
            // 
            this.addressKey.DataPropertyName = "addressId";
            this.addressKey.HeaderText = "addressId";
            this.addressKey.Name = "addressKey";
            this.addressKey.Visible = false;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(SoftwareIIb.address);
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.customerSaveButton);
            this.customerTab.Controls.Add(this.customerCancelButton);
            this.customerTab.Controls.Add(this.customerGridView);
            this.customerTab.Location = new System.Drawing.Point(4, 22);
            this.customerTab.Name = "customerTab";
            this.customerTab.Padding = new System.Windows.Forms.Padding(3);
            this.customerTab.Size = new System.Drawing.Size(772, 405);
            this.customerTab.TabIndex = 0;
            this.customerTab.Text = "Customer Records";
            this.customerTab.UseVisualStyleBackColor = true;
            // 
            // customerSaveButton
            // 
            this.customerSaveButton.Location = new System.Drawing.Point(696, 374);
            this.customerSaveButton.Name = "customerSaveButton";
            this.customerSaveButton.Size = new System.Drawing.Size(70, 26);
            this.customerSaveButton.TabIndex = 6;
            this.customerSaveButton.Text = "Save";
            this.customerSaveButton.UseVisualStyleBackColor = true;
            this.customerSaveButton.Click += new System.EventHandler(this.customersbc);
            // 
            // customerCancelButton
            // 
            this.customerCancelButton.Location = new System.Drawing.Point(620, 373);
            this.customerCancelButton.Name = "customerCancelButton";
            this.customerCancelButton.Size = new System.Drawing.Size(70, 26);
            this.customerCancelButton.TabIndex = 5;
            this.customerCancelButton.Text = "Cancel";
            this.customerCancelButton.UseVisualStyleBackColor = true;
            this.customerCancelButton.Click += new System.EventHandler(this.customercbc);
            // 
            // customerGridView
            // 
            this.customerGridView.AutoGenerateColumns = false;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.active,
            this.addressId,
            this.customerKey});
            this.customerGridView.DataSource = this.customerBindingSource;
            this.customerGridView.Location = new System.Drawing.Point(0, 0);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.Size = new System.Drawing.Size(772, 368);
            this.customerGridView.TabIndex = 4;
            this.customerGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.customerGridView_DefaultValuesNeeded);
            // 
            // addressId
            // 
            this.addressId.DataPropertyName = "addressId";
            this.addressId.DataSource = this.addressBindingSource;
            this.addressId.DisplayMember = "address1";
            this.addressId.HeaderText = "address";
            this.addressId.Name = "addressId";
            this.addressId.ValueMember = "addressId";
            // 
            // customerKey
            // 
            this.customerKey.DataPropertyName = "customerId";
            this.customerKey.HeaderText = "customerId";
            this.customerKey.Name = "customerKey";
            this.customerKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerKey.Visible = false;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SoftwareIIb.customer);
            // 
            // appointmentsTab
            // 
            this.appointmentsTab.Controls.Add(this.appointmentSaveButton);
            this.appointmentsTab.Controls.Add(this.appointmentCancelButton);
            this.appointmentsTab.Controls.Add(this.appointmentGridView);
            this.appointmentsTab.Location = new System.Drawing.Point(4, 22);
            this.appointmentsTab.Name = "appointmentsTab";
            this.appointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentsTab.Size = new System.Drawing.Size(772, 405);
            this.appointmentsTab.TabIndex = 1;
            this.appointmentsTab.Text = "Appointments";
            this.appointmentsTab.UseVisualStyleBackColor = true;
            // 
            // appointmentSaveButton
            // 
            this.appointmentSaveButton.Location = new System.Drawing.Point(696, 373);
            this.appointmentSaveButton.Name = "appointmentSaveButton";
            this.appointmentSaveButton.Size = new System.Drawing.Size(70, 26);
            this.appointmentSaveButton.TabIndex = 10;
            this.appointmentSaveButton.Text = "Save";
            this.appointmentSaveButton.UseVisualStyleBackColor = true;
            this.appointmentSaveButton.Click += new System.EventHandler(this.appointmentsbc);
            // 
            // appointmentCancelButton
            // 
            this.appointmentCancelButton.Location = new System.Drawing.Point(620, 372);
            this.appointmentCancelButton.Name = "appointmentCancelButton";
            this.appointmentCancelButton.Size = new System.Drawing.Size(70, 26);
            this.appointmentCancelButton.TabIndex = 9;
            this.appointmentCancelButton.Text = "Cancel";
            this.appointmentCancelButton.UseVisualStyleBackColor = true;
            this.appointmentCancelButton.Click += new System.EventHandler(this.appointmentcbc);
            // 
            // appointmentGridView
            // 
            this.appointmentGridView.AutoGenerateColumns = false;
            this.appointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerId,
            this.userId,
            this.title,
            this.description,
            this.location,
            this.contact,
            this.type,
            this.url,
            this.start,
            this.end,
            this.appointmentKey});
            this.appointmentGridView.DataSource = this.appointmentBindingSource;
            this.appointmentGridView.Location = new System.Drawing.Point(0, 0);
            this.appointmentGridView.Name = "appointmentGridView";
            this.appointmentGridView.Size = new System.Drawing.Size(772, 368);
            this.appointmentGridView.TabIndex = 6;
            this.appointmentGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.appointmentGridView_DefaultValuesNeeded);
            // 
            // customerId
            // 
            this.customerId.DataPropertyName = "customerId";
            this.customerId.DataSource = this.customerBindingSource;
            this.customerId.DisplayMember = "customerName";
            this.customerId.HeaderText = "customer";
            this.customerId.Name = "customerId";
            this.customerId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerId.ValueMember = "customerId";
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.DataSource = this.userBindingSource;
            this.userId.DisplayMember = "userName";
            this.userId.HeaderText = "user";
            this.userId.Name = "userId";
            this.userId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userId.ValueMember = "userId";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(SoftwareIIb.user);
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "title";
            this.title.Name = "title";
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.Name = "description";
            // 
            // location
            // 
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "location";
            this.location.Name = "location";
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "contact";
            this.contact.Name = "contact";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "type";
            this.type.Name = "type";
            // 
            // url
            // 
            this.url.DataPropertyName = "url";
            this.url.HeaderText = "url";
            this.url.Name = "url";
            // 
            // start
            // 
            this.start.DataPropertyName = "start";
            this.start.HeaderText = "start";
            this.start.Name = "start";
            // 
            // end
            // 
            this.end.DataPropertyName = "end";
            this.end.HeaderText = "end";
            this.end.Name = "end";
            // 
            // appointmentKey
            // 
            this.appointmentKey.DataPropertyName = "appointmentId";
            this.appointmentKey.HeaderText = "appointmentId";
            this.appointmentKey.Name = "appointmentKey";
            this.appointmentKey.Visible = false;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(SoftwareIIb.appointment);
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "customerName";
            this.customerName.Name = "customerName";
            // 
            // active
            // 
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "active";
            this.active.Name = "active";
            // 
            // createDate
            // 
            this.createDate.DataPropertyName = "createDate";
            this.createDate.HeaderText = "createDate";
            this.createDate.Name = "createDate";
            // 
            // createdBy
            // 
            this.createdBy.DataPropertyName = "createdBy";
            this.createdBy.HeaderText = "createdBy";
            this.createdBy.Name = "createdBy";
            // 
            // lastUpdate
            // 
            this.lastUpdate.DataPropertyName = "lastUpdate";
            this.lastUpdate.HeaderText = "lastUpdate";
            this.lastUpdate.Name = "lastUpdate";
            // 
            // lastUpdateBy
            // 
            this.lastUpdateBy.DataPropertyName = "lastUpdateBy";
            this.lastUpdateBy.HeaderText = "lastUpdateBy";
            this.lastUpdateBy.Name = "lastUpdateBy";
            // 
            // appointments
            // 
            this.appointments.DataPropertyName = "appointments";
            this.appointments.HeaderText = "appointments";
            this.appointments.Name = "appointments";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.countriesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.citiesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cityGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.addressTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addressGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.customerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.appointmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage customerTab;
        private System.Windows.Forms.TabPage appointmentsTab;
        private System.Windows.Forms.TabPage countriesTab;
        private System.Windows.Forms.TabPage addressTab;
        private System.Windows.Forms.TabPage citiesTab;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.DataGridView countryGridView;
        private System.Windows.Forms.DataGridView cityGridView;
        private System.Windows.Forms.DataGridView addressGridView;
        private System.Windows.Forms.DataGridView appointmentGridView;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button countrySaveButton;
        private System.Windows.Forms.Button countryCancelButton;
        private System.Windows.Forms.Button citySaveButton;
        private System.Windows.Forms.Button cityCancelButton;
        private System.Windows.Forms.Button addressSaveButton;
        private System.Windows.Forms.Button addressCancelButton;
        private System.Windows.Forms.Button appointmentSaveButton;
        private System.Windows.Forms.Button appointmentCancelButton;
        private System.Windows.Forms.Button customerCancelButton;
        private System.Windows.Forms.Button customerSaveButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn country1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn city1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentKey;
        private System.Windows.Forms.DataGridViewComboBoxColumn cityId;
        private System.Windows.Forms.DataGridViewComboBoxColumn countryId;
        private System.Windows.Forms.DataGridViewComboBoxColumn addressId;
        private System.Windows.Forms.DataGridViewComboBoxColumn customerId;
        private System.Windows.Forms.DataGridViewComboBoxColumn userId;
    }
}