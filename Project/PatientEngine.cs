using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace Project
{

    //class that represents patient
   

        public class PatientObj
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Gender { get; set; }
            public string ID { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string checkInDate { get; set; }
            public string checkOutDate { get; set; }

            public string Room { get; set; }
            public string Bed { get; set; }

            public string Diagnosis { get; set; }
            public string TimeHospitelized { get; set; }


            public PatientObj(string name, string lastname, string gender, string id, string email, string phone, string checkInDate, string room, string bed, string diagnosis)
            {
                this.Name = name;
                this.Surname = lastname;
                this.Gender = gender;
                this.ID = id;
                this.Email = email;
                this.Phone = phone;
                this.checkInDate = checkInDate;
                this.checkOutDate = null;
                this.Room = room;
                this.Bed = bed;
                this.Diagnosis = diagnosis;
                this.TimeHospitelized = null;

            }
            //parameterless constructor for serialization
            public PatientObj()
            {

            }
        }
        // this is class that hold the list of patients objects
        public static class ListOfPatients
        {

            private static List<PatientObj> Plist = new List<PatientObj>();
            //  private static List<bool> BedList = new List<bool>();                            //*****************
            private static bool[] arrOfBedsRoom1 = { false, false, false, false, false, false, false, false, false };


            public static bool[] getArrOfBed()
            {
                return arrOfBedsRoom1;
            }


            //***************************



            public static List<PatientObj> getList()
            {

                return Plist;

            }

            public static void addItemToList(PatientObj item)
            {

                Plist.Add(item);

            }


            //serialization-->saves data after closing the app
            public static void BasicSave()
            {

                XmlSerializer xs = new XmlSerializer(typeof(List<PatientObj>));
                string path = @"Patients.xml";
                using (var file = File.Create(path))
                {
                    xs.Serialize(file, Plist);
                    file.Close();
                }

            }



            public static void BasicLoad()
            {
                XmlSerializer reader =
            new XmlSerializer(typeof(List<PatientObj>));
                StreamReader file = new StreamReader(
            (@"Patients.xml"));


                Plist = (List<PatientObj>)reader.Deserialize(file);
                file.Close();
            }

        }


    }


