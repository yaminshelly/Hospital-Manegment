using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


namespace Project
{

    //class that represents a doctor

    public class DoctorObj

    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string ID { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public DoctorObj(string name, string lastname, string address, string email, string phone, string id, string workstatus, string dateadded)
        {
            this.Name = name;
            this.Surname = lastname;
            this.Address = address;
            this.Email = email;
            this.ID = id;
            this.Phone = phone;
            this.Status = workstatus;
            this.Date = dateadded;
        }



        //parameterless constructor for serialization
        public DoctorObj()
        {

        }
    }


    // this is class that hold the list of doctors objects
    public static class ListOfDoctors
    {

        private static List<DoctorObj> Dlist = new List<DoctorObj>();

        public static List<DoctorObj> getList()
        {

            return Dlist;

        }

        public static void addItemToList(DoctorObj item)
        {

            Dlist.Add(item);

        }

        //serialization-->saves data after closing the app
        public static void BasicSave()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<DoctorObj>));
            string path = @"Doctors.xml";
            System.IO.FileStream file = System.IO.File.Create(path);


            xs.Serialize(file, Dlist);
            file.Close();

        }

        public static void BasicLoad()
        {
            System.Xml.Serialization.XmlSerializer reader =
        new System.Xml.Serialization.XmlSerializer(typeof(List<DoctorObj>));
            System.IO.StreamReader file = new System.IO.StreamReader(
        (@"Doctors.xml"));


            Dlist = (List<DoctorObj>)reader.Deserialize(file);
        }



    }

}






