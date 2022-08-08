using NadraManagementGUI.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadraManagementGUI.BL
{
        public class MUser
        {
            private string userName;
            private string userPassword;
            private string userRole;
            public string UserName { get => userName; set => userName = value; }
            public string UserPassword { get => userPassword; set => userPassword = value; }
            public string UserRole { get => userRole; set => userRole = value; }


        public MUser(string userName, string userPassword, string userRole)
            {
                this.userName = userName;
                this.userPassword = userPassword;
                this.userRole = userRole;
            }
        public MUser()
        {

        }
            public MUser(string userName, string userPassword)
            {
                this.userName = userName;
                this.userPassword = userPassword;
                this.userRole = "NA";
            }
            public bool isAdmin()
            {
                if (userRole == "Admin")
                {
                    return true;
                }
                return false;
            }
            public static MUser SignIn(MUser user)
            {
                foreach (MUser storedUser in MUserCRUD.usersList)
                {
                    if (storedUser.userName == user.userName && storedUser.userPassword == user.userPassword)
                    {
                        return storedUser;
                    }
                }
                return null;
            }
            


        }
    }

