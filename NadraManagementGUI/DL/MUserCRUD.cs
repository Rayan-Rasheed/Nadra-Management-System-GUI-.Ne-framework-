using NadraManagementGUI.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadraManagementGUI.DL
{
    class MUserCRUD
    {

        public static List<MUser> usersList = new List<MUser>();
        public static void addUserIntoList(MUser user)
        {
            usersList.Add(user);
        }
        public static List<MUser> UsersList { get => usersList; }
        public static bool readDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string userName = parseData(record, 1);
                    string userPassword = parseData(record, 2);
                    string userRole = parseData(record, 3);
                    MUser user = new MUser(userName, userPassword, userRole);
                    addUserIntoList(user);
                }
                fileVariable.Close();
                return true;
            }

            return false;


        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static public void storeUserIntoFile( string path)
        {
            //StreamWriter file = new StreamWriter(path, true);
            //file.WriteLine(user.UserName+ "," + user.UserPassword + "," + user.UserRole);
            //file.Flush();
            //file.Close();
            StreamWriter file = new StreamWriter(path);
            foreach (MUser storedUser in usersList)
            {

                file.WriteLine(storedUser.UserName + "," + storedUser.UserPassword + "," + storedUser.UserRole);
            }
            file.Flush();
            file.Close();
        }
        static public MUser checkUserValidation(string userName,string password)
        {
            foreach(var user in usersList)
            {
                if (user.UserName == userName && user.UserPassword == password)
                {
                    return user;
                }
            }
            return null;
        }
        static public void deleteUserFromList(MUser user)
        {
            for (int x = 0; x < usersList.Count; x++)
            {
                if (usersList[x].UserName == user.UserName && usersList[x].UserPassword == user.UserPassword && usersList[x].UserRole == user.UserRole)
                {
                    usersList.RemoveAt(x);
                }
            }
        }
    }
}
