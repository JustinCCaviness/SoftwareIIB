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
            this.countryDataGridView = new System.Windows.Forms.DataGridView();
            this.citiesTab = new System.Windows.Forms.TabPage();
            this.citySaveButton = new System.Windows.Forms.Button();
            this.cityCancelButton = new System.Windows.Forms.Button();
            this.cityDataGridView = new System.Windows.Forms.DataGridView();
            this.addressTab = new System.Windows.Forms.TabPage();
            this.addressSaveButton = new System.Windows.Forms.Button();
            this.addressCancelButton = new System.Windows.Forms.Button();
            this.addressDataGridView = new System.Windows.Forms.DataGridView();
            this.customerTab = new System.Windows.Forms.TabPage();
            this.customerSaveButton = new System.Windows.Forms.Button();
            this.customerCancelButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addressId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.appointmentsTab = new System.Windows.Forms.TabPage();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.postalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.countriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).BeginInit();
            this.citiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
            this.addressTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).BeginInit();
            this.customerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
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
            this.countriesTab.Controls.Add(this.countryDataGridView);
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
            // countryDataGridView
            // 
            this.countryDataGridView.AutoGenerateColumns = false;
            this.countryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryKey,
            this.country1});
            this.countryDataGridView.DataSource = this.countryBindingSource;
            this.countryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.countryDataGridView.Name = "countryDataGridView";
            this.countryDataGridView.Size = new System.Drawing.Size(772, 368);
            this.countryDataGridView.TabIndex = 5;
            this.countryDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.countryDataGridView_DefaultValuesNeeded);
            // 
            // citiesTab
            // 
            this.citiesTab.Controls.Add(this.citySaveButton);
            this.citiesTab.Controls.Add(this.cityCancelButton);
            this.citiesTab.Controls.Add(this.cityDataGridView);
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
            // cityDataGridView
            // 
            this.cityDataGridView.AutoGenerateColumns = false;
            this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityKey,
            this.city1,
            this.countryId});
            this.cityDataGridView.DataSource = this.cityBindingSource;
            this.cityDataGridView.Location = new System.Drawing.Point(0, 0);
            this.cityDataGridView.Name = "cityDataGridView";
            this.cityDataGridView.Size = new System.Drawing.Size(772, 368);
            this.cityDataGridView.TabIndex = 5;
            this.cityDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.cityDataGridView_DefaultValuesNeeded);
            // 
            // addressTab
            // 
            this.addressTab.Controls.Add(this.addressSaveButton);
            this.addressTab.Controls.Add(this.addressCancelButton);
            this.addressTab.Controls.Add(this.addressDataGridView);
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
            // addressDataGridView
            // 
            this.addressDataGridView.AutoGenerateColumns = false;
            this.addressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressKey,
            this.address1,
            this.address2,
            this.cityId,
            this.postalCode,
            this.phone});
            this.addressDataGridView.DataSource = this.addressBindingSource;
            this.addressDataGridView.Location = new System.Drawing.Point(0, 0);
            this.addressDataGridView.Name = "addressDataGridView";
            this.addressDataGridView.Size = new System.Drawing.Size(772, 368);
            this.addressDataGridView.TabIndex = 5;
            this.addressDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.addressDataGridView_DefaultValuesNeeded);
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.customerSaveButton);
            this.customerTab.Controls.Add(this.customerCancelButton);
            this.customerTab.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerKey,
            this.customerName1,
            this.active1,
            this.addressId});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 368);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
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
            // appointmentsTab
            // 
            this.appointmentsTab.Location = new System.Drawing.Point(4, 22);
            this.appointmentsTab.Name = "appointmentsTab";
            this.appointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentsTab.Size = new System.Drawing.Size(772, 405);
            this.appointmentsTab.TabIndex = 1;
            this.appointmentsTab.Text = "Appointments";
            this.appointmentsTab.UseVisualStyleBackColor = true;
            // 
            // customerId
            // 
            this.customerId.DataPropertyName = "customerId";
            this.customerId.HeaderText = "customerId";
            this.customerId.Name = "customerId";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "customerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "customerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "addressId";
            this.dataGridViewTextBoxColumn3.HeaderText = "addressId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "createDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "createDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "createdBy";
            this.dataGridViewTextBoxColumn5.HeaderText = "createdBy";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "lastUpdate";
            this.dataGridViewTextBoxColumn6.HeaderText = "lastUpdate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "lastUpdateBy";
            this.dataGridViewTextBoxColumn7.HeaderText = "lastUpdateBy";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn8.HeaderText = "address";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "appointments";
            this.dataGridViewTextBoxColumn9.HeaderText = "appointments";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // countryKey
            // 
            this.countryKey.DataPropertyName = "countryId";
            this.countryKey.HeaderText = "countryId";
            this.countryKey.Name = "countryKey";
            this.countryKey.Visible = false;
            // 
            // country1
            // 
            this.country1.DataPropertyName = "country1";
            this.country1.HeaderText = "country";
            this.country1.Name = "country1";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(SoftwareIIb.country);
            // 
            // cityKey
            // 
            this.cityKey.DataPropertyName = "cityId";
            this.cityKey.HeaderText = "cityId";
            this.cityKey.Name = "cityKey";
            this.cityKey.Visible = false;
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
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(SoftwareIIb.city);
            // 
            // addressKey
            // 
            this.addressKey.DataPropertyName = "addressId";
            this.addressKey.HeaderText = "addressId";
            this.addressKey.Name = "addressKey";
            this.addressKey.Visible = false;
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
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(SoftwareIIb.address);
            // 
            // customerKey
            // 
            this.customerKey.DataPropertyName = "customerId";
            this.customerKey.HeaderText = "customerId";
            this.customerKey.Name = "customerKey";
            this.customerKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerKey.Visible = false;
            // 
            // customerName1
            // 
            this.customerName1.DataPropertyName = "customerName";
            this.customerName1.HeaderText = "customerName";
            this.customerName1.Name = "customerName1";
            // 
            // active1
            // 
            this.active1.DataPropertyName = "active";
            this.active1.HeaderText = "active";
            this.active1.Name = "active1";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SoftwareIIb.customer);
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
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).EndInit();
            this.citiesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
            this.addressTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).EndInit();
            this.customerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage customerTab;
        private System.Windows.Forms.TabPage appointmentsTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button customerCancelButton;
        private System.Windows.Forms.Button customerSaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn citiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.TabPage countriesTab;
        private System.Windows.Forms.TabPage addressTab;
        private System.Windows.Forms.TabPage citiesTab;
        private System.Windows.Forms.DataGridView countryDataGridView;
        private System.Windows.Forms.DataGridView cityDataGridView;
        private System.Windows.Forms.DataGridView addressDataGridView;
        private System.Windows.Forms.Button countrySaveButton;
        private System.Windows.Forms.Button countryCancelButton;
        private System.Windows.Forms.Button citySaveButton;
        private System.Windows.Forms.Button cityCancelButton;
        private System.Windows.Forms.Button addressSaveButton;
        private System.Windows.Forms.Button addressCancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn country1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2;
        private System.Windows.Forms.DataGridViewComboBoxColumn cityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn city1;
        private System.Windows.Forms.DataGridViewComboBoxColumn countryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active1;
        private System.Windows.Forms.DataGridViewComboBoxColumn addressId;
    }
}