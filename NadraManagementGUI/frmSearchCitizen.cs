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
    public partial class frmSearchCitizen : Form
    {
        public frmSearchCitizen()
        {
            InitializeComponent();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            citizen person=citizenCRUD.isCitizenExist(txtCity.Text);
            if (person != null)
            {
                
                lblName.Text = "Name";
                lblNameFront.Text = person.Name;
                lblFather.Text = "Father Name";
                //lblAdressFront.Text = person.Temp_adress;
                lblAdress.Text = "Home Address";
                lblFatherFront.Text = person.FatherName;
                chartSearchAge.Series["Age"].Points.AddXY(person.Name, person.Age);
                chartSearchIncome.Series["Income"].Points.AddXY(person.Name, person.Income);



            }
            else
            {
                MessageBox.Show("No Citizen exist against this Cnic!");
                
            }
        }

        private void sortedCitizenWithAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSortedCitizen form = new frmSortedCitizen();
            form.Show();
            this.Hide();
        }

        private void graphicalStatisticsOfCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraphicalStat form = new frmGraphicalStat();
            form.Show();
            this.Hide();
        }

        private void applicantRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCitizen form = new frmAddCitizen();
            form.Show();
            this.Hide();
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser form = new frmAddUser();
            form.Show();
            this.Hide();
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin form = new Admin();
            form.Show();
            this.Hide();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void userLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDeleteAccount form = new frmDeleteAccount();
            form.Show();
            this.Hide();
        }

        private void citizenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDelete form = new frmDelete();
            form.Show();
            this.Hide();
        }
    }
}
