namespace SoftwareIIb
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DVGNewReport = new System.Windows.Forms.DataGridView();
            appointmentBindingSource = new System.Windows.Forms.BindingSource(components);
            label1 = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            cbAppointmentType = new System.Windows.Forms.ComboBox();
            cbConsultant = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cbCustomer = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            btnRunAppTypeReport = new System.Windows.Forms.Button();
            btnRunConsultantReport = new System.Windows.Forms.Button();
            btnRunCustomerReport = new System.Windows.Forms.Button();
            cityBindingSource = new System.Windows.Forms.BindingSource(components);
            countryBindingSource = new System.Windows.Forms.BindingSource(components);
            addressBindingSource = new System.Windows.Forms.BindingSource(components);
            customerBindingSource = new System.Windows.Forms.BindingSource(components);
            userBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)DVGNewReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appointmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addressBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DVGNewReport
            // 
            DVGNewReport.AutoGenerateColumns = false;
            DVGNewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVGNewReport.DataSource = appointmentBindingSource;
            DVGNewReport.Location = new System.Drawing.Point(14, 105);
            DVGNewReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DVGNewReport.Name = "DVGNewReport";
            DVGNewReport.Size = new System.Drawing.Size(1127, 423);
            DVGNewReport.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(442, 25);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(215, 42);
            label1.TabIndex = 1;
            label1.Text = "New Report";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(1028, 632);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(113, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(14, 557);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 16);
            label2.TabIndex = 6;
            label2.Text = "Appointment Type";
            // 
            // cbAppointmentType
            // 
            cbAppointmentType.DataSource = appointmentBindingSource;
            cbAppointmentType.ValueMember = "type";
            cbAppointmentType.DisplayMember = "type";
            cbAppointmentType.FormattingEnabled = true;
            cbAppointmentType.Location = new System.Drawing.Point(159, 552);
            cbAppointmentType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbAppointmentType.Name = "cbAppointmentType";
            cbAppointmentType.Size = new System.Drawing.Size(254, 23);
            cbAppointmentType.TabIndex = 7;
            // 
            // cbConsultant
            // 
            cbConsultant.DataSource = userBindingSource;
            cbConsultant.ValueMember = "userId";
            cbConsultant.DisplayMember = "userName";
            cbConsultant.FormattingEnabled = true;
            cbConsultant.Location = new System.Drawing.Point(159, 598);
            cbConsultant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbConsultant.Name = "cbConsultant";
            cbConsultant.Size = new System.Drawing.Size(254, 23);
            cbConsultant.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(14, 603);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 16);
            label3.TabIndex = 8;
            label3.Text = "Consultant";
            // 
            // cbCustomer
            // 
            cbCustomer.DataSource = customerBindingSource;
            cbCustomer.ValueMember = "customerId";
            cbCustomer.DisplayMember = "customerName";
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new System.Drawing.Point(159, 644);
            cbCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new System.Drawing.Size(254, 23);
            cbCustomer.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(14, 650);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 16);
            label4.TabIndex = 10;
            label4.Text = " Customer";
            // 
            // btnRunAppTypeReport
            // 
            btnRunAppTypeReport.Location = new System.Drawing.Point(434, 552);
            btnRunAppTypeReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRunAppTypeReport.Name = "btnRunAppTypeReport";
            btnRunAppTypeReport.Size = new System.Drawing.Size(113, 24);
            btnRunAppTypeReport.TabIndex = 12;
            btnRunAppTypeReport.Text = "Run Report";
            btnRunAppTypeReport.UseVisualStyleBackColor = true;
            btnRunAppTypeReport.Click += btnRunAppTypeReport_Click;
            // 
            // btnRunConsultantReport
            // 
            btnRunConsultantReport.Location = new System.Drawing.Point(434, 598);
            btnRunConsultantReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRunConsultantReport.Name = "btnRunConsultantReport";
            btnRunConsultantReport.Size = new System.Drawing.Size(113, 24);
            btnRunConsultantReport.TabIndex = 13;
            btnRunConsultantReport.Text = "Run Report";
            btnRunConsultantReport.UseVisualStyleBackColor = true;
            btnRunConsultantReport.Click += btnRunConsultantReport_Click;
            // 
            // btnRunCustomerReport
            // 
            btnRunCustomerReport.Location = new System.Drawing.Point(434, 644);
            btnRunCustomerReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRunCustomerReport.Name = "btnRunCustomerReport";
            btnRunCustomerReport.Size = new System.Drawing.Size(113, 24);
            btnRunCustomerReport.TabIndex = 14;
            btnRunCustomerReport.Text = "Run Report";
            btnRunCustomerReport.UseVisualStyleBackColor = true;
            btnRunCustomerReport.Click += btnRunCustomerReport_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1153, 697);
            Controls.Add(btnRunCustomerReport);
            Controls.Add(btnRunConsultantReport);
            Controls.Add(btnRunAppTypeReport);
            Controls.Add(cbCustomer);
            Controls.Add(label4);
            Controls.Add(cbConsultant);
            Controls.Add(label3);
            Controls.Add(cbAppointmentType);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(DVGNewReport);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "NewReport";
            Load += NewReport_Load;
            ((System.ComponentModel.ISupportInitialize)DVGNewReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)appointmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)addressBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView DVGNewReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAppointmentType;
        private System.Windows.Forms.ComboBox cbConsultant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRunAppTypeReport;
        private System.Windows.Forms.Button btnRunConsultantReport;
        private System.Windows.Forms.Button btnRunCustomerReport;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        #endregion 

    }
}