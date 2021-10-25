using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;



namespace Project
{

    public partial class Doctors : UserControl
    {


        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";//איך המייל צריך להיות רשום
        bool edit_or_new_flag;
        bool panel_is_opened;


        public Doctors()
        {

            ListOfDoctors.BasicLoad();
            InitializeComponent();
            ListUpdate();

        }
        //updating the list everytime an object is added
        private void ListUpdate()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ListOfDoctors.getList();
            doctorsgrid.DataSource = bs;
            doctorsgrid.ClearSelection();

        }



        //when form is loaded
        private void Doctors_Load(object sender, EventArgs e)
        {
            pnlNewDoctor.Hide();
            btnRemoveDoctor.Enabled = false;
            btnEditDoctor.Enabled = false;
            emptyfields_label.Hide();

            //columns lenght
            for(int i=0;i<8; i++)
            this.doctorsgrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            doctorsgrid.ClearSelection();




        }
        //new button
        private void btnNewDoctor_Click(object sender, EventArgs e)
        {
            emptyfields_label.Hide();

            this.panel_is_opened = true;
            this.edit_or_new_flag = true;
            this.pnlNewDoctor.Show();
            this.btnRemoveDoctor.Enabled = false;
            this.btnEditDoctor.Enabled = false;
            this.txtDateAdded.Value = DateTime.Today;

        }
        // cancel button

        private void btnCancelDoctor_Click(object sender, EventArgs e)
        {
            this.pnlNewDoctor.Hide();
            this.panel_is_opened = false;

            if (doctorsgrid.SelectedRows.Count == 1)
            {
                btnRemoveDoctor.Enabled = true;
                btnEditDoctor.Enabled = true;
            }

            emptyfields_label.Hide();

            txtName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtID.Clear();
            txtWorkStatus.Text = "";
        }
        //ok button for new/edit options

        private void btnOkDoctor_Click(object sender, EventArgs e)
        {

            if ((txtName.Text == "") || (txtLastName.Text == "") || (txtAddress.Text == "") || (txtEmail.Text == "") || (txtPhone.Text == "") || (txtID.Text == "") || (txtWorkStatus.Text == "") || (txtDateAdded.Text == ""))
            {
                emptyfields_label.Show();

            }
            else if (!Regex.IsMatch(txtEmail.Text, pattern))//בדיקה אם המייל תקין

            {
                MessageBox.Show("Please provide valid email");


            }
            else
            {

                if (edit_or_new_flag == true) //if new
                {
                    DoctorObj newDoctor = new DoctorObj
                       (txtName.Text,
                        txtLastName.Text,
                        txtAddress.Text,
                        txtEmail.Text,
                        txtPhone.Text,
                        txtID.Text,
                        txtWorkStatus.Text,
                        txtDateAdded.Text
                        );

                    ListOfDoctors.addItemToList(newDoctor);

                    ListUpdate();


                }

                else // if edit
                {
                    doctorsgrid.SelectedRows[0].Cells[0].Value = txtName.Text;
                    doctorsgrid.SelectedRows[0].Cells[1].Value = txtLastName.Text;
                    doctorsgrid.SelectedRows[0].Cells[2].Value = txtAddress.Text;
                    doctorsgrid.SelectedRows[0].Cells[3].Value = txtEmail.Text;
                    doctorsgrid.SelectedRows[0].Cells[4].Value = txtPhone.Text;
                    doctorsgrid.SelectedRows[0].Cells[5].Value = txtID.Text;
                    doctorsgrid.SelectedRows[0].Cells[6].Value = txtWorkStatus.Text;
                    doctorsgrid.SelectedRows[0].Cells[7].Value = txtDateAdded.Text;
                }

                txtName.Clear();
                txtLastName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtID.Clear();
                txtWorkStatus.Text= "";
                //txtDateAdded.Text = time.today;

                panel_is_opened = false;
                this.pnlNewDoctor.Hide();
                ListOfDoctors.BasicSave();
                emptyfields_label.Hide();

            }

            if (doctorsgrid.SelectedRows.Count == 1)
            {
                btnRemoveDoctor.Enabled = true;
                btnEditDoctor.Enabled = true;
            }

        }
        //edit button
        private void btnEditDoctor_Click(object sender, EventArgs e)
        {

            panel_is_opened = true;
            edit_or_new_flag = false;

            txtName.Text = doctorsgrid.SelectedRows[0].Cells[0].Value.ToString();
            txtLastName.Text = doctorsgrid.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = doctorsgrid.SelectedRows[0].Cells[2].Value.ToString();
            txtEmail.Text = doctorsgrid.SelectedRows[0].Cells[3].Value.ToString();
            txtPhone.Text = doctorsgrid.SelectedRows[0].Cells[4].Value.ToString();
            txtID.Text = doctorsgrid.SelectedRows[0].Cells[5].Value.ToString();
            txtWorkStatus.Text = doctorsgrid.SelectedRows[0].Cells[6].Value.ToString();
            txtDateAdded.Text = doctorsgrid.SelectedRows[0].Cells[7].Value.ToString();


            this.pnlNewDoctor.Show();
            this.btnRemoveDoctor.Enabled = false;
            this.btnEditDoctor.Enabled = false;
        }

        
        //remove button
        private void btnRemoveDoctor_Click(object sender, EventArgs e)
        {
            doctorsgrid.Rows.RemoveAt(doctorsgrid.SelectedRows[0].Index);
            ListOfDoctors.BasicSave();

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void doctorsgrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //what happens to edit and remove buttons when row selected
            if ((doctorsgrid.SelectedRows.Count == 1) && (panel_is_opened == false))
            {
                btnEditDoctor.Enabled = true;
                btnRemoveDoctor.Enabled = true;
            }
            else
            {
                btnEditDoctor.Enabled = false;
                btnRemoveDoctor.Enabled = false;
            }
        }

        
    }
}
