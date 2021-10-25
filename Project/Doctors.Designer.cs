namespace Project
{
    partial class Doctors
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridpanel = new System.Windows.Forms.Panel();
            this.doctorsgrid = new System.Windows.Forms.DataGridView();
            this.btnNewDoctor = new System.Windows.Forms.Button();
            this.btnEditDoctor = new System.Windows.Forms.Button();
            this.btnRemoveDoctor = new System.Windows.Forms.Button();
            this.pnlNewDoctor = new System.Windows.Forms.Panel();
            this.emptyfields_label = new System.Windows.Forms.Label();
            this.txtDateAdded = new System.Windows.Forms.DateTimePicker();
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWorkStatus = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancelDoctor = new System.Windows.Forms.Button();
            this.btnOkDoctor = new System.Windows.Forms.Button();
            this.txtWorkStatus = new System.Windows.Forms.ComboBox();
            this.gridpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsgrid)).BeginInit();
            this.pnlNewDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridpanel
            // 
            this.gridpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridpanel.Controls.Add(this.doctorsgrid);
            this.gridpanel.Location = new System.Drawing.Point(4, 102);
            this.gridpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridpanel.Name = "gridpanel";
            this.gridpanel.Size = new System.Drawing.Size(1445, 454);
            this.gridpanel.TabIndex = 0;
            // 
            // doctorsgrid
            // 
            this.doctorsgrid.AllowUserToAddRows = false;
            this.doctorsgrid.AllowUserToDeleteRows = false;
            this.doctorsgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doctorsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsgrid.Location = new System.Drawing.Point(0, 0);
            this.doctorsgrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorsgrid.Name = "doctorsgrid";
            this.doctorsgrid.ReadOnly = true;
            this.doctorsgrid.RowHeadersVisible = false;
            this.doctorsgrid.RowHeadersWidth = 51;
            this.doctorsgrid.RowTemplate.Height = 24;
            this.doctorsgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctorsgrid.ShowCellToolTips = false;
            this.doctorsgrid.ShowEditingIcon = false;
            this.doctorsgrid.Size = new System.Drawing.Size(1445, 454);
            this.doctorsgrid.TabIndex = 0;
            this.doctorsgrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.doctorsgrid_RowStateChanged);
            // 
            // btnNewDoctor
            // 
            this.btnNewDoctor.AutoSize = true;
            this.btnNewDoctor.Location = new System.Drawing.Point(524, 604);
            this.btnNewDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewDoctor.Name = "btnNewDoctor";
            this.btnNewDoctor.Size = new System.Drawing.Size(90, 32);
            this.btnNewDoctor.TabIndex = 15;
            this.btnNewDoctor.Text = "New";
            this.btnNewDoctor.UseVisualStyleBackColor = true;
            this.btnNewDoctor.Click += new System.EventHandler(this.btnNewDoctor_Click);
            // 
            // btnEditDoctor
            // 
            this.btnEditDoctor.AutoSize = true;
            this.btnEditDoctor.Location = new System.Drawing.Point(820, 604);
            this.btnEditDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditDoctor.Name = "btnEditDoctor";
            this.btnEditDoctor.Size = new System.Drawing.Size(90, 32);
            this.btnEditDoctor.TabIndex = 14;
            this.btnEditDoctor.Text = "Edit";
            this.btnEditDoctor.UseVisualStyleBackColor = true;
            this.btnEditDoctor.Click += new System.EventHandler(this.btnEditDoctor_Click);
            // 
            // btnRemoveDoctor
            // 
            this.btnRemoveDoctor.AutoSize = true;
            this.btnRemoveDoctor.Location = new System.Drawing.Point(672, 604);
            this.btnRemoveDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveDoctor.Name = "btnRemoveDoctor";
            this.btnRemoveDoctor.Size = new System.Drawing.Size(90, 32);
            this.btnRemoveDoctor.TabIndex = 13;
            this.btnRemoveDoctor.Text = "Remove";
            this.btnRemoveDoctor.UseVisualStyleBackColor = true;
            this.btnRemoveDoctor.Click += new System.EventHandler(this.btnRemoveDoctor_Click);
            // 
            // pnlNewDoctor
            // 
            this.pnlNewDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlNewDoctor.Controls.Add(this.txtWorkStatus);
            this.pnlNewDoctor.Controls.Add(this.emptyfields_label);
            this.pnlNewDoctor.Controls.Add(this.txtDateAdded);
            this.pnlNewDoctor.Controls.Add(this.lblDateAdded);
            this.pnlNewDoctor.Controls.Add(this.lblEmail);
            this.pnlNewDoctor.Controls.Add(this.lblWorkStatus);
            this.pnlNewDoctor.Controls.Add(this.lblAddress);
            this.pnlNewDoctor.Controls.Add(this.lblID);
            this.pnlNewDoctor.Controls.Add(this.lblLastName);
            this.pnlNewDoctor.Controls.Add(this.lblPhone);
            this.pnlNewDoctor.Controls.Add(this.lblName);
            this.pnlNewDoctor.Controls.Add(this.txtID);
            this.pnlNewDoctor.Controls.Add(this.txtLastName);
            this.pnlNewDoctor.Controls.Add(this.txtEmail);
            this.pnlNewDoctor.Controls.Add(this.txtPhone);
            this.pnlNewDoctor.Controls.Add(this.txtAddress);
            this.pnlNewDoctor.Controls.Add(this.txtName);
            this.pnlNewDoctor.Controls.Add(this.btnCancelDoctor);
            this.pnlNewDoctor.Controls.Add(this.btnOkDoctor);
            this.pnlNewDoctor.Location = new System.Drawing.Point(401, 176);
            this.pnlNewDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNewDoctor.Name = "pnlNewDoctor";
            this.pnlNewDoctor.Size = new System.Drawing.Size(632, 352);
            this.pnlNewDoctor.TabIndex = 16;
            // 
            // emptyfields_label
            // 
            this.emptyfields_label.AutoSize = true;
            this.emptyfields_label.BackColor = System.Drawing.SystemColors.HighlightText;
            this.emptyfields_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyfields_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyfields_label.ForeColor = System.Drawing.Color.Red;
            this.emptyfields_label.Location = new System.Drawing.Point(17, 16);
            this.emptyfields_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emptyfields_label.Name = "emptyfields_label";
            this.emptyfields_label.Size = new System.Drawing.Size(208, 22);
            this.emptyfields_label.TabIndex = 12;
            this.emptyfields_label.Text = "Some fields are empty";
            // 
            // txtDateAdded
            // 
            this.txtDateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateAdded.Location = new System.Drawing.Point(467, 217);
            this.txtDateAdded.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateAdded.Name = "txtDateAdded";
            this.txtDateAdded.Size = new System.Drawing.Size(119, 26);
            this.txtDateAdded.TabIndex = 7;
            this.txtDateAdded.Value = new System.DateTime(2020, 4, 16, 23, 22, 4, 0);
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDateAdded.Location = new System.Drawing.Point(342, 215);
            this.lblDateAdded.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(95, 20);
            this.lblDateAdded.TabIndex = 7;
            this.lblDateAdded.Text = "Date Added";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(46, 217);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblWorkStatus
            // 
            this.lblWorkStatus.AutoSize = true;
            this.lblWorkStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWorkStatus.Location = new System.Drawing.Point(342, 164);
            this.lblWorkStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkStatus.Name = "lblWorkStatus";
            this.lblWorkStatus.Size = new System.Drawing.Size(97, 20);
            this.lblWorkStatus.TabIndex = 7;
            this.lblWorkStatus.Text = "Work Status";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress.Location = new System.Drawing.Point(46, 167);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(342, 114);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastName.Location = new System.Drawing.Point(46, 116);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhone.Location = new System.Drawing.Point(342, 64);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 20);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(46, 66);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(467, 110);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.MaxLength = 9;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 26);
            this.txtID.TabIndex = 5;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(170, 113);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(119, 26);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(170, 214);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(119, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(467, 60);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(119, 26);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(170, 163);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(119, 26);
            this.txtAddress.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 26);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnCancelDoctor
            // 
            this.btnCancelDoctor.Location = new System.Drawing.Point(330, 287);
            this.btnCancelDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelDoctor.Name = "btnCancelDoctor";
            this.btnCancelDoctor.Size = new System.Drawing.Size(90, 28);
            this.btnCancelDoctor.TabIndex = 9;
            this.btnCancelDoctor.Text = "Cancel";
            this.btnCancelDoctor.UseVisualStyleBackColor = true;
            this.btnCancelDoctor.Click += new System.EventHandler(this.btnCancelDoctor_Click);
            // 
            // btnOkDoctor
            // 
            this.btnOkDoctor.Location = new System.Drawing.Point(212, 287);
            this.btnOkDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.btnOkDoctor.Name = "btnOkDoctor";
            this.btnOkDoctor.Size = new System.Drawing.Size(90, 28);
            this.btnOkDoctor.TabIndex = 8;
            this.btnOkDoctor.Text = "OK";
            this.btnOkDoctor.UseVisualStyleBackColor = true;
            this.btnOkDoctor.Click += new System.EventHandler(this.btnOkDoctor_Click);
            // 
            // txtWorkStatus
            // 
            this.txtWorkStatus.FormattingEnabled = true;
            this.txtWorkStatus.Items.AddRange(new object[] {
            "Working",
            "Sick leave",
            "Vacation"});
            this.txtWorkStatus.Location = new System.Drawing.Point(467, 161);
            this.txtWorkStatus.Name = "txtWorkStatus";
            this.txtWorkStatus.Size = new System.Drawing.Size(121, 28);
            this.txtWorkStatus.TabIndex = 6;
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.pnlNewDoctor);
            this.Controls.Add(this.btnNewDoctor);
            this.Controls.Add(this.gridpanel);
            this.Controls.Add(this.btnEditDoctor);
            this.Controls.Add(this.btnRemoveDoctor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Doctors";
            this.Size = new System.Drawing.Size(1453, 703);
            this.Load += new System.EventHandler(this.Doctors_Load);
            this.gridpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsgrid)).EndInit();
            this.pnlNewDoctor.ResumeLayout(false);
            this.pnlNewDoctor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gridpanel;
        private System.Windows.Forms.DataGridView doctorsgrid;
        private System.Windows.Forms.Button btnNewDoctor;
        private System.Windows.Forms.Button btnEditDoctor;
        private System.Windows.Forms.Button btnRemoveDoctor;
        private System.Windows.Forms.Panel pnlNewDoctor;
        private System.Windows.Forms.Label emptyfields_label;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancelDoctor;
        private System.Windows.Forms.Button btnOkDoctor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.Label lblWorkStatus;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker txtDateAdded;
        private System.Windows.Forms.ComboBox txtWorkStatus;
    }
}
