using NadraManagementGUI.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadraManagementGUI
{
    public partial class frmApplicantHealth : frmApplicant
    {
        public frmApplicantHealth()
        {
            InitializeComponent();
        }

        private void frmApplicantHealth_Load(object sender, EventArgs e)
        {
            lblNameFront.Text = Communication.Person.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Communication.Person!=null){
                citizenCRUD.SahatAppList.Add(Communication.Person);
            }
        }
    }
}
