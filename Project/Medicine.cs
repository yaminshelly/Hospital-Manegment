using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Project
{
    public partial class Medicine : UserControl
    {
        bool edit_or_new_flag;
        bool panel_is_opened;



        public Medicine()
        {
            ListOfMedicine.BasicLoad();

            InitializeComponent();
            ListUpdate();
        }
        //updating the list everytime an object is added
        private void ListUpdate()
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = ListOfMedicine.getList();

            medicineGrid.DataSource = bs;
            medicineGrid.ClearSelection();

        }
        private void Medicine_Load(object sender, EventArgs e)
        {


            pnlNewMedicine.Hide();
            btnRemoveMedicine.Enabled = false;
            btnEditMedicine.Enabled = false;
            medicineGrid.ClearSelection();


            //columns lenght
            this.medicineGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.medicineGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.medicineGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.medicineGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.medicineGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }
        //new button
        private void btnNewMedicine_Click(object sender, EventArgs e)
        {
            emptyfields_label.Hide();

            this.panel_is_opened = true;
            this.edit_or_new_flag = true;
            this.pnlNewMedicine.Show();
            this.btnRemoveMedicine.Enabled = false;
            this.btnEditMedicine.Enabled = false;
        }

        // cancel button
        private void btnCancelMedicine_Click(object sender, EventArgs e)
        {
            this.pnlNewMedicine.Hide();
            this.panel_is_opened = false;


            if (medicineGrid.SelectedRows.Count == 1)
            {
                btnRemoveMedicine.Enabled = true;
                btnEditMedicine.Enabled = true;
            }

            emptyfields_label.Hide();

            txtName.Clear();
            txtStock.Clear();
            txtDosage.Clear();
            txtSupplier.Clear();
            txtCost.Clear();

        }

        //ok button for new/edit options

        private void btnOkMedicine_Click(object sender, EventArgs e)
        {

            if ((txtName.Text == "") || (txtStock.Text == "") || (txtDosage.Text == "") || (txtSupplier.Text == "") || (txtCost.Text == ""))
            {
                emptyfields_label.Show();

            }
            else
            {

                if (edit_or_new_flag == true)// if new
                {
                    MedicineObj newMedicine = new MedicineObj
                       (txtName.Text,
                        txtStock.Text,
                        txtDosage.Text,
                        txtSupplier.Text,
                        txtCost.Text
                        );

                    ListOfMedicine.addItemToList(newMedicine);

                    ListUpdate();


                }

                else //if edit
                {
                    medicineGrid.SelectedRows[0].Cells[0].Value = txtName.Text;
                    medicineGrid.SelectedRows[0].Cells[1].Value = txtStock.Text;
                    medicineGrid.SelectedRows[0].Cells[2].Value = txtDosage.Text;
                    medicineGrid.SelectedRows[0].Cells[3].Value = txtSupplier.Text;
                    medicineGrid.SelectedRows[0].Cells[4].Value = txtCost.Text;

                }

                txtName.Clear();
                txtStock.Clear();
                txtDosage.Clear();
                txtSupplier.Clear();
                txtCost.Clear();
                emptyfields_label.Hide();
                panel_is_opened = false;
                pnlNewMedicine.Hide();
                ListOfMedicine.BasicSave();

                if (medicineGrid.SelectedRows.Count == 1)
                {
                    btnRemoveMedicine.Enabled = true;
                    btnEditMedicine.Enabled = true;
                }

            }
        }
        //remove button

        private void btnRemoveMedicine_Click(object sender, EventArgs e)
        {
            medicineGrid.Rows.RemoveAt(medicineGrid.SelectedRows[0].Index);
            ListOfMedicine.BasicSave();

            txtName.Clear();
            txtStock.Clear();
            txtDosage.Clear();
            txtSupplier.Clear();
            txtCost.Clear();

            btnEditMedicine.Enabled = false;
            


        }
        //edit button

        private void btnEditMedicine_Click(object sender, EventArgs e)
        {
            panel_is_opened = true;
            edit_or_new_flag = false;

            txtName.Text = medicineGrid.SelectedRows[0].Cells[0].Value.ToString();
            txtStock.Text = medicineGrid.SelectedRows[0].Cells[1].Value.ToString();
            txtDosage.Text = medicineGrid.SelectedRows[0].Cells[2].Value.ToString();
            txtSupplier.Text = medicineGrid.SelectedRows[0].Cells[3].Value.ToString();
            txtCost.Text = medicineGrid.SelectedRows[0].Cells[4].Value.ToString();

            this.pnlNewMedicine.Show();
            this.btnRemoveMedicine.Enabled = false;
            this.btnEditMedicine.Enabled = false;
        }

        //selecting item



        private void pnlNewMedicine_Paint(object sender, PaintEventArgs e)
        {

        }


        private void MedicineListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //new button
        private void btnNewMedicine_Click_1(object sender, EventArgs e)
        {
            emptyfields_label.Hide();

            panel_is_opened = true;
            edit_or_new_flag = true;
            pnlNewMedicine.Show();
            this.btnRemoveMedicine.Enabled = false;
            this.btnEditMedicine.Enabled = false;
        }
        //selecting items
        private void medicineGrid_MouseMove(object sender, MouseEventArgs e)
        {

          /*  if ((medicineGrid.SelectedRows.Count == 1) && (panel_is_opened == false))
            {
                btnEditMedicine.Enabled = true;
                btnRemoveMedicine.Enabled = true;
            }
            else
            {
                //    btnEditMedicine.Enabled = false;
                btnRemoveMedicine.Enabled = false;
            }*/
        }

        private void medicineGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
           

            //what happens to edit and remove buttons when row selected
            if ((medicineGrid.SelectedRows.Count == 1) && (panel_is_opened == false))
            {
                btnEditMedicine.Enabled = true;
                btnRemoveMedicine.Enabled = true;
            }
            else
            {
                btnEditMedicine.Enabled = false;
                btnRemoveMedicine.Enabled = false;
            }



            
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    }


}



