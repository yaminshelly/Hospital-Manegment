using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Project
{
    public partial class Patients : UserControl
    {


        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";//איך המייל צריך להיות רשום

        string previousDiagnosis; //שומר את האבחנה הקודמת של המטופל בשביל הסטטיסטיקה
        public static event EventHandler OkClicked;

        bool rechecking = false;//דגל בשביל לדעת מה המטופל חוזר לטיפול נוסף
        bool edit_or_new_flag;// false= panel opened for edit patient, true= panel opened for new patient
        bool panel_is_opened;//בשביל לדעת מתי פאנל של פרטי המטופל פתוח
        public Patients()
        {
            ListOfPatients.BasicLoad();//טוען את קובץ הXML
            InitializeComponent();
            ListUpdate();    
            
            lblerroeEa.Hide();    lblerrorBn.Hide();     lblerrordate.Hide();    lblerrorDiag.Hide();
            lblerrorFn.Hide();  lblerrorGd.Hide();    lblerrorId.Hide();     lblerrorLn.Hide();      lblerrorPn.Hide();
            lblerrorRn.Hide();   

        }


        //updating the list everytime an object is added
        private void ListUpdate()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ListOfPatients.getList();
            patientGrid.DataSource = bs;
            patientGrid.ClearSelection();

            
        }
        private void Patients_Load(object sender, EventArgs e)
        {
            //buttons on load
            reCheckBtn.Enabled = false;
            checkOutBtn.Enabled = false;
            new_patient.Hide();
            removeBtn_patient.Enabled = false;
            editBtn_patient.Enabled = false;

            //columns lenght
            for (int i = 0; i < 11; i++)
                this.patientGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            //setting columns headers
            patientGrid.Columns[1].HeaderText = "Last Name";
            patientGrid.Columns[6].HeaderText = "Check In Date";
            patientGrid.Columns[7].HeaderText = "Check Out Date";
            patientGrid.Columns[11].HeaderText = "Time Hospitolized";


            patientGrid.ClearSelection();
        }


        
        private void ok_button_Click(object sender, EventArgs e)//when OK clicked = two options. OK after EDIT or OK after NEW 
        {

            //no empty fields allowed
            if ((name_box.Text == "") || (lastname_box.Text == "") || (Cmb_Gender.Text == "") || (email_box.Text == "") || (id_box.Text == "") || (phone_box.Text == "") || (cmbRoomNumber.Text == "") || (cmbBedNumber.Text == "") || (diagnosis_box.Text == "") || (checkInDateBox.Text == ""))
            {


                emptyfields_label.Show();// error messege if some fields are empty

            }
            else if (Rooms.isBedTaken(cmbRoomNumber.Text, cmbBedNumber.Text))//בדיקה האם המיטה תפוסה
            {
                MessageBox.Show("The bed is taken!");// אם המיטה תפוסה קופצת ההודעה הזאת


            }
            else if (!Regex.IsMatch(email_box.Text, pattern))//בדיקה אם המייל תקין

            {
                MessageBox.Show("Please provide valid email");


            }// אחרת זה מוסיף מטופל כרגיל
            else   
            {


                if (edit_or_new_flag == true) // first option= if its OK click after NEW clicked before
                {
                    PatientObj newPatient = new PatientObj //creates new patiens object
                        (name_box.Text,
                         lastname_box.Text,
                         Cmb_Gender.Text,
                         id_box.Text,
                         email_box.Text,
                         phone_box.Text,
                         checkInDateBox.Text,
                         cmbRoomNumber.Text,
                         cmbBedNumber.Text,
                         diagnosis_box.Text);

                    ListOfPatients.addItemToList(newPatient); // add object to the list of patients
                    StatsEngine.addDiagnosis(newPatient.Diagnosis); //adds diagnosis for STATISTIC count
                    

                    ListUpdate();//updates patients table

                    OkClicked?.Invoke(sender, e);//tells other classes that new patient was added

                    DialogResult dialogResult = MessageBox.Show("Do you want to send Email?", "New Patient", MessageBoxButtons.YesNo);//שואל את המשתמש האם לשלוח מייל בעת יצירת מטופל חדש
                    if (dialogResult == DialogResult.Yes)
                    {
                        SendEmail.sendWelcomeMessage(email_box.Text, name_box.Text, cmbRoomNumber.Text, cmbBedNumber.Text, diagnosis_box.Text);//send email to the patient
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //פשוט לא שולח
                    }






                }
                else //second option= if its OK click after EDIT clicked before
                {


                        //copies patient info from panel to table
                        patientGrid.SelectedRows[0].Cells[0].Value = name_box.Text;
                        patientGrid.SelectedRows[0].Cells[1].Value = lastname_box.Text;
                        patientGrid.SelectedRows[0].Cells[2].Value = Cmb_Gender.Text;
                        patientGrid.SelectedRows[0].Cells[3].Value = id_box.Text;
                        patientGrid.SelectedRows[0].Cells[4].Value = email_box.Text;
                        patientGrid.SelectedRows[0].Cells[5].Value = phone_box.Text;
                        patientGrid.SelectedRows[0].Cells[6].Value = checkInDateBox.Text;
                        patientGrid.SelectedRows[0].Cells[8].Value = cmbRoomNumber.Text;
                        patientGrid.SelectedRows[0].Cells[9].Value = cmbBedNumber.Text;
                        patientGrid.SelectedRows[0].Cells[10].Value = diagnosis_box.Text;
                    

                    if ((previousDiagnosis != diagnosis_box.Text)&&(patientGrid.SelectedRows[0].Cells[11].Value==null)) //makes changes in chart1 if diagnosis changed
                    {
                        StatsEngine.removeDiagnosis(previousDiagnosis);
                        StatsEngine.addDiagnosis(diagnosis_box.Text);  
                    }
                  






                    if (rechecking == true) //edit panel is used for editing and rechecking. this is the recheck case
                    {
                        patientGrid.SelectedRows[0].Cells[11].Value = null;
                        StatsEngine.addDiagnosis(diagnosis_box.Text);
                        StatsEngine.addRecheck(previousDiagnosis);


                        DialogResult dialogResult = MessageBox.Show("Do you want to send Email?", "New Patient", MessageBoxButtons.YesNo);//שואל את המשתמש האם לשלוח מייל בעת חזרת המטופל למחלקה
                        if (dialogResult == DialogResult.Yes)
                        {
                            SendEmail.sendWelcomeMessage(email_box.Text, name_box.Text, cmbRoomNumber.Text, cmbBedNumber.Text, diagnosis_box.Text);//send email to the patient
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //פשוט לא שולח
                        }

                    }

                    if ((previousDiagnosis != diagnosis_box.Text) && (patientGrid.SelectedRows[0].Cells[11].Value != null)&& (rechecking==false)) //makes changes in chart2 if diagnosis was changed
                    {
                        StatsEngine.removeDays(previousDiagnosis, Convert.ToInt32(patientGrid.SelectedRows[0].Cells[11].Value));
                        StatsEngine.addDays(diagnosis_box.Text, Convert.ToInt32(patientGrid.SelectedRows[0].Cells[11].Value));
                    }



                    OkClicked?.Invoke(sender, e); //tells other classes that patient was edited
                }
            


            //clears all boxes 
            name_box.Clear();
            lastname_box.Clear();
            email_box.Clear();
            phone_box.Clear();
            checkInDateBox.Value = DateTime.Now;
            id_box.Clear();
            cmbRoomNumber.Text = "";
            cmbBedNumber.Text = "";
            diagnosis_box.Text = "";
            rechecking = false;
            reCheckBtn.Enabled = false;
            panel_is_opened = false;
            new_patient.Hide();
            ListOfPatients.BasicSave();

            }







        }


        //new button click
        private void newBtn_Click(object sender, EventArgs e)
        {
            emptyfields_label.Hide();

            this.panel_is_opened = true;
            this.edit_or_new_flag = true;
            this.new_patient.Show();
            this.removeBtn_patient.Enabled = false;
            this.editBtn_patient.Enabled = false;
            this.checkInDateBox.Enabled = false;//check in date always set for today
        }

        //remove button click
        private void removeBtn_Click(object sender, EventArgs e)
        {

            if (patientGrid.SelectedRows[0].Cells[7].Value == null)//removes diagnosis from statistics
            StatsEngine.removeDiagnosis(patientGrid.SelectedRows[0].Cells[10].Value.ToString());


            patientGrid.Rows.RemoveAt(patientGrid.SelectedRows[0].Index);//removes patient from the table
            ListOfPatients.BasicSave();


            for (int i = 0; i < 4; i++) //אתחול מערך מספר המיטות המאויישות בכל חדר
            {
                Rooms.numberOfFullBadRoom[i] = 0;
            }




            OkClicked?.Invoke(sender, e);//tells other classes that patient was removed

        }

        


        //edit button click
        private void editBtn_Click(object sender, EventArgs e)
        {
            panel_is_opened = true;
            edit_or_new_flag = false;
            checkInDateBox.Enabled = false;

            for (int i = 0; i < 4; i++) //אתחול מערך מספר המיטות המאויישות בכל חדר
            {
                Rooms.numberOfFullBadRoom[i] = 0;
            }





            if (rechecking == true) //edit panel is used for editing and rechecking. this is the recheck case
            {
                patientGrid.SelectedCells[7].Value = null;
                checkOutBtn.Enabled = true;
                checkInDateBox.Text = DateTime.Today.ToString();
            }
            else
            checkInDateBox.Text = patientGrid.SelectedRows[0].Cells[6].Value.ToString();


            //copies patient info from table to panel
            name_box.Text = patientGrid.SelectedRows[0].Cells[0].Value.ToString();
            lastname_box.Text = patientGrid.SelectedRows[0].Cells[1].Value.ToString();
            Cmb_Gender.Text = patientGrid.SelectedRows[0].Cells[2].Value.ToString();
            id_box.Text = patientGrid.SelectedRows[0].Cells[3].Value.ToString();
            email_box.Text = patientGrid.SelectedRows[0].Cells[4].Value.ToString();
            phone_box.Text = patientGrid.SelectedRows[0].Cells[5].Value.ToString();
            cmbRoomNumber.Text = patientGrid.SelectedRows[0].Cells[8].Value.ToString();
            cmbBedNumber.Text = patientGrid.SelectedRows[0].Cells[9].Value.ToString();
            diagnosis_box.Text = patientGrid.SelectedRows[0].Cells[10].Value.ToString();
            previousDiagnosis = patientGrid.SelectedRows[0].Cells[10].Value.ToString();


            new_patient.Show();
            this.removeBtn_patient.Enabled = false;
            this.editBtn_patient.Enabled = false;
        }


        


        // cancel button click - clears all boxes
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.panel_is_opened = false;
            new_patient.Hide();
            name_box.Clear();
            lastname_box.Clear();
            email_box.Clear();
            phone_box.Clear();
            checkInDateBox.Value = DateTime.Now;
            id_box.Clear();
            cmbRoomNumber.Text = "";
            cmbBedNumber.Text = "";
            diagnosis_box.Text = "";

            if (patientGrid.SelectedRows.Count == 1)
            {
                editBtn_patient.Enabled = true;
                removeBtn_patient.Enabled = true;
            }
        }


        //check out button click
        private void checkOutBtn_Click(object sender, EventArgs e)
        {

            //calculates time that the patient stayed
            DateTime checkOut = DateTime.Today;
            DateTime checkIn = Convert.ToDateTime(patientGrid.SelectedCells[6].Value.ToString());
            TimeSpan tspan = checkOut - checkIn;
            patientGrid.SelectedRows[0].Cells[11].Value = tspan.Days;

            patientGrid.SelectedCells[7].Value = DateTime.Today;
            patientGrid.SelectedCells[8].Value = 0;
            patientGrid.SelectedCells[9].Value = 0;
            reCheckBtn.Enabled = true;
            editBtn_patient.Enabled = true;
            removeBtn_patient.Enabled = true;
            checkOutBtn.Enabled = false;
            ListOfPatients.BasicSave();

            //removes patient from current stay statistics, and adds the time stayed to the second chart
            StatsEngine.removeDiagnosis(patientGrid.SelectedRows[0].Cells[10].Value.ToString());
            StatsEngine.addDays(patientGrid.SelectedCells[10].Value.ToString(), Convert.ToInt32(tspan.Days));

            OkClicked?.Invoke(sender, e);//tells other classes that patient was checked out



        }
        //recheck button
        private void reCheckBtn_Click(object sender, EventArgs e)
        {
            rechecking = true;
           // checkInDateBox.Text = DateTime.Today.ToString();
            editBtn_Click(sender, e);// edit panel is used for rechecking also
        }

        private void Patients_MouseMove(object sender, MouseEventArgs e)
        {


        }

        //buttons state changes according to patient and interface status
        private void patientGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

            //recheck button
            if ((patientGrid.SelectedRows.Count > 0) && (patientGrid.SelectedCells[7].Value != null))
                reCheckBtn.Enabled = true;
            else
                reCheckBtn.Enabled = false;

            //what happens to edit and remove buttons when row selected
            if ((patientGrid.SelectedRows.Count == 1) && (panel_is_opened == false))
            {
                editBtn_patient.Enabled = true;
                removeBtn_patient.Enabled = true;
            }
            else
            {
                editBtn_patient.Enabled = false;
                removeBtn_patient.Enabled = false;
            }



            //what happens to check out button when row selected
            if ((patientGrid.SelectedRows.Count == 1) && (patientGrid.SelectedCells[7].Value == null))
                checkOutBtn.Enabled = true;

            else
            {
                checkOutBtn.Enabled = false;
            }
        }

        private void id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void phone_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void name_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void lastname_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

       
    }
}
