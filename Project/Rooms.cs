using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace Project
{
    public partial class Rooms : UserControl
    {


        private static bool[,] bedsRoom = new bool[4, 8];//מערך בוליאני לדעת אם מיטה תפוסה או לא
        public static int[] numberOfFullBadRoom = new int[4];

       

        public static bool isBedTaken(string room, string bed)//שיטה שבודקת האם מיטה תפוסה, נקראת כשנוצר מטופל חדש
        {
            if (bedsRoom[Convert.ToInt32(room)-1, Convert.ToInt32(bed)-1] == true)
                return true;
            else
                return false;
        }



        public Rooms()
        {
            InitializeComponent();
            

            if (ListOfPatients.getList().Count > 0) //מריץ את השיטה המעדכנת רק אם יש יותר מ0 מטופלים, אחרת זה יעשה שגיאה
                roomUpdate(null, null);

            for(int i = 0; i<4; i++) //אתחול מערך מספר המיטות המאויישות בכל חדר
            {
                numberOfFullBadRoom[i] = 0;
            }

            SidePanel2.Height = btnRoom1.Height;
            SidePanel2.Top = btnRoom1.Top;

            Patients.OkClicked += roomUpdate;

        }

      
           

public static bool[,] getBedSRoom()
        {
            return bedsRoom;
        }

        public void roomUpdate(object sender, EventArgs e)
        {
           
            Button[,] rooms = new Button[4,8] 
            {
            { btnBed1_R1, btnBed2_R1, btnBed3_R1, btnBed4_R1, btnBed5_R1, btnBed6_R1, btnBed7_R1, btnBed8_R1 },
            { btnBed1_R2, btnBed2_R2, btnBed3_R2, btnBed4_R2, btnBed5_R2, btnBed6_R2, btnBed7_R2, btnBed8_R2 },
            { btnBed1_R3, btnBed2_R3, btnBed3_R3, btnBed4_R3, btnBed5_R3, btnBed6_R3, btnBed7_R3, btnBed8_R3 },
            { btnBed1_R4, btnBed2_R4, btnBed3_R4, btnBed4_R4, btnBed5_R4, btnBed6_R4, btnBed7_R4, btnBed8_R4}  
            };

            Button[] BtnOfRooms = new Button[4] { btnRoom1, btnRoom2, btnRoom3, btnRoom4 };
            

            for (int i = 0; i < 4; i++)// מאתחל את הכפתורים בעזרת המערכת שנוצרה בשורה למעלה
            {
                 for(int j=0; j<8; j++)
                {
                    rooms[i, j].BackColor = Color.MediumAquamarine;
                    rooms[i, j].Text = null;
                }
            }

          for(int i =0; i<4; i++) //מאתחל את הכפתורים של החדרים 
            {
                BtnOfRooms[i].BackColor = Color.LightSteelBlue;
            }




            foreach (PatientObj patientObj in ListOfPatients.getList())// לולאה עוברת על מערך המטופלים ומעדכנת מיטות בהתאם
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        
                        if (patientObj.Bed == (j+1).ToString() && patientObj.Room == (i+1).ToString())
                        {
                            rooms[i,j].BackColor = Color.Red;
                            rooms[i,j].Text= patientObj.Name + " " + patientObj.Surname;
                           
                            bedsRoom[i,j] = true;
                            numberOfFullBadRoom[i]++; //סופר את המיטות התפוסות ומכניס למערך 
                        }

                    }
                    if (numberOfFullBadRoom[0] == 8) btnRoom1.BackColor = Color.Red;
                    if (numberOfFullBadRoom[1] == 8) btnRoom2.BackColor = Color.Red;
                    if (numberOfFullBadRoom[2] == 8) btnRoom3.BackColor = Color.Red;
                    if (numberOfFullBadRoom[3] == 8) btnRoom4.BackColor = Color.Red;
                }
            }
           

        }


      //panel shows when we prass on the buttun of the room : 

        private void btnRoom2_Click(object sender, EventArgs e)
        {

            SidePanel2.Height = btnRoom2.Height;
            SidePanel2.Top = btnRoom2.Top;

            pnlRoom2.Show();
            pnlRoom1.Hide();
            pnlRoom3.Hide();
            pnlRoom4.Hide();
            
       
            
        }

        private void btnRoom3_Click(object sender, EventArgs e)
        {
            SidePanel2.Height = btnRoom3.Height;
            SidePanel2.Top = btnRoom3.Top;

            pnlRoom2.Hide();
            pnlRoom1.Hide();
            pnlRoom3.Show();
            pnlRoom4.Hide();


        }

        private void btnRoom4_Click(object sender, EventArgs e)
        {
            SidePanel2.Height = btnRoom4.Height;
            SidePanel2.Top = btnRoom4.Top;

            pnlRoom2.Hide();
            pnlRoom1.Hide();
            pnlRoom3.Hide();
            pnlRoom4.Show();

        }

        private void btnRoom1_Click_1(object sender, EventArgs e)
        {
            SidePanel2.Height = btnRoom1.Height;
            SidePanel2.Top = btnRoom1.Top;

            pnlRoom2.Hide();
            pnlRoom1.Show();
            pnlRoom3.Hide();
            pnlRoom4.Hide();
        }

        private void pnlRoom4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRoom3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        }
 