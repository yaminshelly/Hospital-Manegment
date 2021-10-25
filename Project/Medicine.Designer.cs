namespace Project
{
    partial class Medicine
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
            this.btnEditMedicine = new System.Windows.Forms.Button();
            this.btnRemoveMedicine = new System.Windows.Forms.Button();
            this.pnlNewMedicine = new System.Windows.Forms.Panel();
            this.emptyfields_label = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblDosage = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancelMedicine = new System.Windows.Forms.Button();
            this.btnOkMedicine = new System.Windows.Forms.Button();
            this.btnNewMedicine = new System.Windows.Forms.Button();
            this.medicineGrid = new System.Windows.Forms.DataGridView();
            this.pnlNewMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditMedicine
            // 
            this.btnEditMedicine.AutoSize = true;
            this.btnEditMedicine.Location = new System.Drawing.Point(820, 604);
            this.btnEditMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditMedicine.Name = "btnEditMedicine";
            this.btnEditMedicine.Size = new System.Drawing.Size(90, 32);
            this.btnEditMedicine.TabIndex = 7;
            this.btnEditMedicine.Text = "Edit";
            this.btnEditMedicine.UseVisualStyleBackColor = true;
            this.btnEditMedicine.Click += new System.EventHandler(this.btnEditMedicine_Click);
            // 
            // btnRemoveMedicine
            // 
            this.btnRemoveMedicine.AutoSize = true;
            this.btnRemoveMedicine.Location = new System.Drawing.Point(672, 604);
            this.btnRemoveMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveMedicine.Name = "btnRemoveMedicine";
            this.btnRemoveMedicine.Size = new System.Drawing.Size(90, 32);
            this.btnRemoveMedicine.TabIndex = 5;
            this.btnRemoveMedicine.Text = "Remove";
            this.btnRemoveMedicine.UseVisualStyleBackColor = true;
            this.btnRemoveMedicine.Click += new System.EventHandler(this.btnRemoveMedicine_Click);
            // 
            // pnlNewMedicine
            // 
            this.pnlNewMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlNewMedicine.Controls.Add(this.emptyfields_label);
            this.pnlNewMedicine.Controls.Add(this.lblCost);
            this.pnlNewMedicine.Controls.Add(this.txtCost);
            this.pnlNewMedicine.Controls.Add(this.txtSupplier);
            this.pnlNewMedicine.Controls.Add(this.lblSupplier);
            this.pnlNewMedicine.Controls.Add(this.lblDosage);
            this.pnlNewMedicine.Controls.Add(this.lblStock);
            this.pnlNewMedicine.Controls.Add(this.lblName);
            this.pnlNewMedicine.Controls.Add(this.txtStock);
            this.pnlNewMedicine.Controls.Add(this.txtDosage);
            this.pnlNewMedicine.Controls.Add(this.txtName);
            this.pnlNewMedicine.Controls.Add(this.btnCancelMedicine);
            this.pnlNewMedicine.Controls.Add(this.btnOkMedicine);
            this.pnlNewMedicine.Location = new System.Drawing.Point(401, 176);
            this.pnlNewMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNewMedicine.Name = "pnlNewMedicine";
            this.pnlNewMedicine.Size = new System.Drawing.Size(632, 352);
            this.pnlNewMedicine.TabIndex = 9;
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
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCost.Location = new System.Drawing.Point(336, 118);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(42, 20);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(460, 114);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(119, 26);
            this.txtCost.TabIndex = 4;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(460, 62);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(119, 26);
            this.txtSupplier.TabIndex = 3;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSupplier.Location = new System.Drawing.Point(335, 66);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(67, 20);
            this.lblSupplier.TabIndex = 8;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDosage.Location = new System.Drawing.Point(52, 169);
            this.lblDosage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(65, 20);
            this.lblDosage.TabIndex = 7;
            this.lblDosage.Text = "Dosage";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStock.Location = new System.Drawing.Point(52, 118);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 20);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(52, 66);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(176, 114);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(119, 26);
            this.txtStock.TabIndex = 1;
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(176, 166);
            this.txtDosage.Margin = new System.Windows.Forms.Padding(2);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(119, 26);
            this.txtDosage.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 26);
            this.txtName.TabIndex = 0;
            // 
            // btnCancelMedicine
            // 
            this.btnCancelMedicine.Location = new System.Drawing.Point(330, 287);
            this.btnCancelMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelMedicine.Name = "btnCancelMedicine";
            this.btnCancelMedicine.Size = new System.Drawing.Size(90, 28);
            this.btnCancelMedicine.TabIndex = 6;
            this.btnCancelMedicine.Text = "Cancel";
            this.btnCancelMedicine.UseVisualStyleBackColor = true;
            this.btnCancelMedicine.Click += new System.EventHandler(this.btnCancelMedicine_Click);
            // 
            // btnOkMedicine
            // 
            this.btnOkMedicine.Location = new System.Drawing.Point(212, 287);
            this.btnOkMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.btnOkMedicine.Name = "btnOkMedicine";
            this.btnOkMedicine.Size = new System.Drawing.Size(90, 28);
            this.btnOkMedicine.TabIndex = 5;
            this.btnOkMedicine.Text = "OK";
            this.btnOkMedicine.UseVisualStyleBackColor = true;
            this.btnOkMedicine.Click += new System.EventHandler(this.btnOkMedicine_Click);
            // 
            // btnNewMedicine
            // 
            this.btnNewMedicine.AutoSize = true;
            this.btnNewMedicine.Location = new System.Drawing.Point(524, 604);
            this.btnNewMedicine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewMedicine.Name = "btnNewMedicine";
            this.btnNewMedicine.Size = new System.Drawing.Size(90, 32);
            this.btnNewMedicine.TabIndex = 12;
            this.btnNewMedicine.Text = "New";
            this.btnNewMedicine.UseVisualStyleBackColor = true;
            this.btnNewMedicine.Click += new System.EventHandler(this.btnNewMedicine_Click_1);
            // 
            // medicineGrid
            // 
            this.medicineGrid.AllowUserToAddRows = false;
            this.medicineGrid.AllowUserToDeleteRows = false;
            this.medicineGrid.AllowUserToResizeRows = false;
            this.medicineGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineGrid.Location = new System.Drawing.Point(4, 102);
            this.medicineGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medicineGrid.Name = "medicineGrid";
            this.medicineGrid.ReadOnly = true;
            this.medicineGrid.RowHeadersVisible = false;
            this.medicineGrid.RowHeadersWidth = 51;
            this.medicineGrid.RowTemplate.Height = 24;
            this.medicineGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicineGrid.Size = new System.Drawing.Size(1445, 454);
            this.medicineGrid.TabIndex = 13;
            this.medicineGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.medicineGrid_RowStateChanged);
            this.medicineGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.medicineGrid_MouseMove);
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.pnlNewMedicine);
            this.Controls.Add(this.medicineGrid);
            this.Controls.Add(this.btnNewMedicine);
            this.Controls.Add(this.btnEditMedicine);
            this.Controls.Add(this.btnRemoveMedicine);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Medicine";
            this.Size = new System.Drawing.Size(1453, 703);
            this.Load += new System.EventHandler(this.Medicine_Load);
            this.pnlNewMedicine.ResumeLayout(false);
            this.pnlNewMedicine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditMedicine;
        private System.Windows.Forms.Button btnRemoveMedicine;
        private System.Windows.Forms.Panel pnlNewMedicine;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancelMedicine;
        private System.Windows.Forms.Button btnOkMedicine;
        private System.Windows.Forms.Label emptyfields_label;
        private System.Windows.Forms.Button btnNewMedicine;
        private System.Windows.Forms.DataGridView medicineGrid;
    }
}
