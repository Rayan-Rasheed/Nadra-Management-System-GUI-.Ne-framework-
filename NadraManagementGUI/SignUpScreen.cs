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
    public partial class SignUp : Form
    {
        private string path="credentials";
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void cmdSignUp_Click(object sender, EventArgs e)
        {
            MUser user = new MUser(txtUserName.Text, txtPassword.Text, cboUserRole.Text);
            MUserCRUD.addUserIntoList(user);
            MUserCRUD.storeUserIntoFile(FilePath.credentialPath);
            this.Close();
           
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Username")
                txtUserName.Clear();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Password")
                txtUserName.Clear();
        }
    }
}
