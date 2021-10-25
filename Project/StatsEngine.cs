using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Project
{
    static class StatsEngine
    {

        private static string[] names = new string[8] { "Bipolar", "Mania", "Depression", "Phobia", "Panic", "PTSD", "Anorexia", "Narcolepsy" };

        private static int[] diagnosisCount = new int[8];
        private static int[] diagnosisDays = new int[8];
        private static int[] diagnosisRechecks = new int[8];

        private static int[] statsArray = new int[24];//first 8 = chart1, second 8 = chart2, third 8 = chart3

        public static string[] getDiagnosisNames()
        {
            return names;
        }
        public static int[] getStatsArrayChart1()
        {
            Array.Copy(statsArray, 0, diagnosisCount, 0, 8);
            return diagnosisCount;
        }

        public static int[] getStatsArrayChart2()
        {
            Array.Copy(statsArray, 8, diagnosisDays, 0, 8);
            return diagnosisDays;
        }

        public static int[] getStatsArrayChart3()
        {
            Array.Copy(statsArray, 16, diagnosisRechecks, 0, 8);
            return diagnosisRechecks;
        }



        public static void saveDiagnosisArray() //saves diagnosis count array
        {
          //  String writeToText = string.Format("{0}", diagnosisArray);
          System.IO.File.WriteAllLines("log.txt", statsArray.Select(i => i.ToString())); // Writes string to text file. chart1
            

            


        }

        public static void loadDiagnosisArray() //loads diagnosis count array
        {
            StreamReader reader = new StreamReader("log.txt");
            for (int i = 0; i < 24; i++)
            {
                statsArray[i] = Convert.ToInt32(reader.ReadLine());
            }
            reader.Close();
        }

        //for first chart
        public static void addDiagnosis(string diagnosis)
        {
            switch (diagnosis)
            {
                case "Bipolar":
                    statsArray[0]++;
                    break;
                case "Mania":
                    statsArray[1]++;
                    break;
                case "Depression":
                    statsArray[2]++;
                    break;
                case "Phobia":
                    statsArray[3]++;
                    break;
                case "Panic":
                    statsArray[4]++;
                    break;
                case "PTSD":
                    statsArray[5]++;
                    break;
                case "Anorexia":
                    statsArray[6]++;
                    break;
                case "Narcolepsy":
                    statsArray[7]++;
                    break;
            }

            saveDiagnosisArray();
        }
        public static void removeDiagnosis(string diagnosis)
        {
            switch (diagnosis)
            {
                case "Bipolar":
                    statsArray[0]--;
                    break;
                case "Mania":
                    statsArray[1]--;
                    break;
                case "Depression":
                    statsArray[2]--;
                    break;
                case "Phobia":
                    statsArray[3]--;
                    break;
                case "Panic":
                    statsArray[4]--;
                    break;
                case "PTSD":
                    statsArray[5]--;
                    break;
                case "Anorexia":
                    statsArray[6]--;
                    break;
                case "Narcolepsy":
                    statsArray[7]--;
                    break;
            }

            saveDiagnosisArray();
        }


        //for second chart
        public static void addDays(string diagnosis, int days)
        {
            switch (diagnosis)
            {
                case "Bipolar":
                    statsArray[8]= statsArray[8] + days;
                    break;
                case "Mania":
                    statsArray[9] = statsArray[9] + days;
                    break;
                case "Depression":
                    statsArray[10] = statsArray[10] + days;
                    break;
                case "Phobia":
                    statsArray[11] = statsArray[11] + days;
                    break;
                case "Panic":
                    statsArray[12] = statsArray[12] + days;
                    break;
                case "PTSD":
                    statsArray[13] = statsArray[13] + days;
                    break;
                case "Anorexia":
                    statsArray[14] = statsArray[14] + days;
                    break;
                case "Narcolepsy":
                    statsArray[15] = statsArray[15] + days;
                    break;
            }

            saveDiagnosisArray();
        }

        public static void removeDays(string diagnosis, int days)
        {
            switch (diagnosis)
            {
                case "Bipolar":
                    statsArray[8] = statsArray[8] - days;
                    break;
                case "Mania":
                    statsArray[9] = statsArray[9] - days;
                    break;
                case "Depression":
                    statsArray[10] = statsArray[10] - days;
                    break;
                case "Phobia":
                    statsArray[11] = statsArray[11] - days;
                    break;
                case "Panic":
                    statsArray[12] = statsArray[12] - days;
                    break;
                case "PTSD":
                    statsArray[13] = statsArray[13] - days;
                    break;
                case "Anorexia":
                    statsArray[14] = statsArray[14] - days;
                    break;
                case "Narcolepsy":
                    statsArray[15] = statsArray[15] - days;
                    break;
            }

            saveDiagnosisArray();
        }


        //for third chart
        public static void addRecheck(string diagnosis)
        {
            switch (diagnosis)
            {
                case "Bipolar":
                    statsArray[16]++;
                    break;
                case "Mania":
                    statsArray[17]++;
                    break;
                case "Depression":
                    statsArray[18]++;
                    break;
                case "Phobia":
                    statsArray[19]++;
                    break;
                case "Panic":
                    statsArray[20]++;
                    break;
                case "PTSD":
                    statsArray[21]++;
                    break;
                case "Anorexia":
                    statsArray[22]++;
                    break;
                case "Narcolepsy":
                    statsArray[23]++;
                    break;
            }

            saveDiagnosisArray();
        }
    }
}
