using NadraManagementGUI.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadraManagementGUI
{
    class Communication
    {
        private static citizen person;
        private static string delStatus;
        private static MUser user;
        
        public static citizen Person { get => person; set => person = value; }
        public static string DelStatus { get => delStatus; set => delStatus = value; }
        public static MUser User { get => user; set => user = value; }

    }
}
