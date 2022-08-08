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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSignUp_Click(object sender, EventArgs e)
        {
            MUser user = new MUser(txtUserName.Text, txtPassword.Text, cboUserRole.Text);
            MUserCRUD.addUserIntoList(user);
            MUserCRUD.storeUserIntoFile(FilePath.credentialPath);
            MessageBox.Show("SuccessFully Done!");
            this.Close();
        }
    }
}
