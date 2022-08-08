using NadraManagementGUI.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadraManagementGUI.DL
{
    class citizenCRUD
    {
        private static List<citizen> dataList = new List<citizen>();
        private static List<citizen> sortedDataList = new List<citizen>();
        private static List<citizen> sahatAppList = new List<citizen>();
        private static List<citizen> acceptSahatAppList = new List<citizen>();
        public static List<citizen> DataList { get => dataList; }
        
        public static void addCitizenIntoList(citizen c)
        {
            dataList.Add(c);
        }
        public static void addSahatSelectedCitizen(citizen c)
        {
            acceptSahatAppList.Add(c);
        }
        public static void addsahatAppList(citizen c)
        {
            sahatAppList.Add(c);
        }

        static public void  sortedDatalist()
        {
            sortedDataList = dataList.OrderByDescending(o => o.Age).ToList();
            
        }
        public static List<citizen> SortedDataList
        {
            get => sortedDataList;

        }
        public static List<citizen> AcceptSahatAppList
        {
            get => acceptSahatAppList;
        }
        public static List<citizen> SahatAppList
        {
            get => sahatAppList;set => sahatAppList = value;
        }
        public static void storeDataIntoFile(string path)
        {

            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < dataList.Count; i++)
            {
                if (i == dataList.Count - 1)
                {

                    file.Write(dataList[i].Name + ", " + dataList[i].LastName + "," + dataList[i].Gender + "," + dataList[i].City + "," + dataList[i].Cnic + "," + dataList[i].FatherName + "," + dataList[i].Province + "," + dataList[i].Temp_adress + "," + dataList[i].PermanentAdress + "," + dataList[i].VaccineName + "," + dataList[i].Dose + ","+ dataList[i].Date + ","+ dataList[i].Month + ","+ dataList[i].Year + "," + dataList[i].Income + "," + dataList[i].WorthTotal+","+dataList[i].Age+","+ dataList[i].TokenNumber);
                }
                else
                {
                    file.WriteLine(dataList[i].Name + ", " + dataList[i].LastName + "," + dataList[i].Gender + "," + dataList[i].City + "," + dataList[i].Cnic + "," + dataList[i].FatherName + "," + dataList[i].Province + "," + dataList[i].Temp_adress + "," + dataList[i].PermanentAdress + "," + dataList[i].VaccineName + "," + dataList[i].Dose + "," + dataList[i].Date + "," + dataList[i].Month + "," + dataList[i].Year + "," + dataList[i].Income + "," + dataList[i].WorthTotal + "," + dataList[i].Age + "," + dataList[i].TokenNumber);


                }
            }

            file.Flush();
            file.Close();
        }
        public static void load( string path)
        {
            //***********************laoding recorda from file***************************************************


            string line;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);

                while (((line = file.ReadLine())) != null)
                {
                    string[] record = line.Split(',');
                    citizen Add = new citizen(record[0], record[1], record[2], record[3], record[4], record[5], record[6], record[7], record[8], record[9], int.Parse(record[10]), int.Parse(record[11]), int.Parse(record[12]), int.Parse(record[13]), int.Parse(record[14]), double.Parse(record[15]));
                    Add.Age = int.Parse(record[16]);

                    Add.TokenNumber = int.Parse(record[17]);
                    citizenCRUD.addCitizenIntoList(Add);


                    // uploaading temporary arr1ay data into orignal array

                    
                }
                file.Close();
            }
        }
        public static citizen isCitizenExist(string cnic)
        {
            foreach(var person in dataList)
            {
                if (person.Cnic == cnic)
                {
                    return person;
                }
            }
            return null;
        }
        static public void deleteUserFromList(citizen user,List<citizen >person)
        {
            for (int x = 0; x < person.Count; x++)
            {
                if (person[x].Cnic==user.Cnic)
                {
                    person.RemoveAt(x);
                }
            }
        }
       

        public static void StoreIntoFileSahatApp(string path, string path1)
        {
            SahatAppStoreAppCitizen(path);
            SahatAppStoreSelected(path1);


        }
        private static void SahatAppStoreAppCitizen(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < sahatAppList.Count; i++)
            {
                if (i == sahatAppList.Count - 1)
                {
                    file.Write(sahatAppList[i].Cnic);

                }
                else
                {
                    file.WriteLine(sahatAppList[i].Cnic);

                }
            }

            file.Flush();
            file.Close();
        }
        private static void SahatAppStoreSelected(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < acceptSahatAppList.Count; i++)
            {
                if (i == acceptSahatAppList.Count - 1)
                {
                    file.Write(acceptSahatAppList[i].Cnic);

                }
                else
                {
                    file.WriteLine(acceptSahatAppList[i].Cnic);

                }
            }

            file.Flush();
            file.Close();
        }
        public static void loadFromFileSahatApp(string path,string path1)
        {
            SahatAppLoadAppCitizen(path);
            SahatAppLoadSelected(path1);
        }
        private static void SahatAppLoadAppCitizen(string path)
        {
            string line;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);

                while (((line = file.ReadLine())) != null)
                {
                    citizen person = isCitizenExist(line);
                    addsahatAppList(person);

                }
                file.Close();
            }
        }
        private static void SahatAppLoadSelected(string path)
        {
            string line;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);

                while (((line = file.ReadLine())) != null)
                {
                    citizen person = isCitizenExist(line);
                    addSahatSelectedCitizen(person);

                }
                file.Close();
            }
        }
        public static citizen citizenFromTokenNumber(int TokenNumber)
        {
            foreach (var person in dataList)
            {
                if (person.TokenNumber == TokenNumber)
                {
                    return person;
                }
            }
            return null;
        }
        



    }
}
