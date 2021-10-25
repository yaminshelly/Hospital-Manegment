using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

namespace Project
{
    //class that represents medicine
    public class MedicineObj
    {

        public string Name { get; set; }
        public string Stock { get; set; }
        public string Dosage { get; set; }
        public string Supplier { get; set; }
        public string Cost { get; set; }

        public MedicineObj()
        {

        }


        public MedicineObj(string name, string Stock, string Dosage, string Supplier, string Cost)
        {
            this.Name = name;
            this.Stock = Stock;
            this.Dosage = Dosage;
            this.Supplier = Supplier;
            this.Cost = Cost;
        }

    }
    // this is class that hold the list of medicine objects
    public class ListOfMedicine
    {

        public ListOfMedicine()
        {

        }

        private static List<MedicineObj> Mlist = new List<MedicineObj>();

        public static List<MedicineObj> getList()
        {

            return Mlist;

        }

        public static void addItemToList(MedicineObj item)
        {

            Mlist.Add(item);

        }
        //serialization-->saves data after closing the app
        public static void BasicSave()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<MedicineObj>));
            string path = @"Medicine.xml";
            System.IO.FileStream file = File.Create(path);


            xs.Serialize(file, Mlist);
            file.Close();

        }

        public static void BasicLoad()
        {
            System.Xml.Serialization.XmlSerializer reader =
        new System.Xml.Serialization.XmlSerializer(typeof(List<MedicineObj>));
            System.IO.StreamReader file = new System.IO.StreamReader(
        (@"Medicine.xml"));


            Mlist = (List<MedicineObj>)reader.Deserialize(file);
            file.Close();
        }



    }
}
