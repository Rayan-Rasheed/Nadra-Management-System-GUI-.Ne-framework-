using NadraManagementGUI.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadraManagementGUI.DL
{
    class ComplaintCRUD
    {
        private static List<Complaint> complaintList = new List<Complaint>();
        public static  List<Complaint> ComplaintList
        {
            get => complaintList;
            set => complaintList = value;

        }
        public static void addIntoList(Complaint c)
        {
            complaintList.Add(c);
        }
        public static void storeDataIntoFile(string path)
        {

            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < ComplaintList.Count; i++)
            {
                if (i == ComplaintList.Count - 1)
                {
                    file.Write(ComplaintList[i].Email + "," + ComplaintList[i].Name + ",", ComplaintList[i].Complaints);

                }
                else
                {

                    file.WriteLine(ComplaintList[i].Email + "," + ComplaintList[i].Name + "," + ComplaintList[i].Complaints);

                }
            }

            file.Flush();
            file.Close();
        }
        public static void load(string path)
        {
            //***********************laoding recorda from file***************************************************


            string line;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);

                while (((line = file.ReadLine())) != null)
                {
                    string[] record = line.Split(',');
                    Complaint Add = new Complaint(record[0], record[1], record[2]);
                    addIntoList(Add);

                    // uploaading temporary arr1ay data into orignal array


                }
                file.Close();
            }
           
        }
        public static Complaint getSpecified(MUser user)
        {
            foreach(var cmp in complaintList)
            {
                if (cmp.Name == user.UserName)
                {
                    return cmp;
                }
            }
            return null;
        }

    }
}
