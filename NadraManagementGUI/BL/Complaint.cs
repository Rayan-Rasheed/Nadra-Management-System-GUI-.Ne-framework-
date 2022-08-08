using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadraManagementGUI.BL
{
    public class Complaint
    {

        private string email;
        private string username;
        private string complaint;
        private string reply;
        public Complaint(string email,string username,string complaint)
        {
            this.email = email;
            this.username = username;
            this.complaint = complaint;
        }
        public string Name { get => username; set => username = value; }

        public string Complaints { get => complaint; set => complaint = value; }
        public string Email { get => email; set => email = value; }
        public string Reply { get => reply; set => reply = value; }


    }
}
