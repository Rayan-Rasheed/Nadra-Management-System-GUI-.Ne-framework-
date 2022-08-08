using NadraManagementGUI.BL;
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
    public partial class frmApplicantCovid : frmApplicant
    {
        public frmApplicantCovid()
        {
            InitializeComponent();
        }

        private void frmApplicantCovid_Load(object sender, EventArgs e)
        {

        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            citizen person = citizenCRUD.isCitizenExist(txtToken.Text);

            if (person != null)
            {
                frmCovidCard form = new frmCovidCard(person);
                form.Show();




            }
            else
            {
                MessageBox.Show("Not Registered!");
            }

        }
    }
}
