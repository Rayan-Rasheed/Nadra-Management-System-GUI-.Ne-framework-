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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdSignIn_Click(object sender, EventArgs e)
        {
            
            MUser user = MUserCRUD.checkUserValidation(txtUserName.Text, txtPassword.Text);
            if (user != null)
            {
                if (user.UserRole == "Admin")
                {
                    Admin adminForm = new Admin();
                    adminForm.Show();
                    this.Hide();
                }
                else if (user.UserRole == "Applicant")
                {
                    citizen c = citizenCRUD.isCitizenExist(txtUserName.Text);
                    Communication.Person = c;
                    Communication.User = user;
                    frmApplicant form = new frmApplicant();
                    form.Show();
                    this.Hide();

                }
            }
            else
            {
                //MessageBox.Show("Invalid Credentials");
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
            this.Hide();
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtUserName.Text== "Username")
            txtUserName.Clear();

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Clear();
        }
    }
}
