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
    public partial class frmGraphicalStat : Form
    {
        public frmGraphicalStat()
        {
            InitializeComponent();
        }

        private void frmGraphicalStat_Load(object sender, EventArgs e)
        {
            
            

        }

        private void chartAge_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void sortedCitizenWithAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSortedCitizen form = new frmSortedCitizen();
            form.Show();
            this.Hide();
        }

        private void citizenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSearchCitizen form = new frmSearchCitizen();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int detect_18 = 0;
            int detect_40 = 0;
            int detect_60 = 0;
            int detect_80 = 0;
            int detect_100 = 0;


            // cout << ageA[0];
            for (int i = 0; i < citizenCRUD.DataList.Count; i++)
            {
                if (citizenCRUD.DataList[i].City == txtCity.Text)
                {
                    if ((citizenCRUD.DataList[i].Age <= 18))
                    {
                        detect_18++;
                    }
                    if ((citizenCRUD.DataList[i].Age > 20 && citizenCRUD.DataList[i].Age <= 40))
                    {
                        detect_40++;
                    }
                    if ((citizenCRUD.DataList[i].Age > 40 && citizenCRUD.DataList[i].Age <= 60))
                    {
                        detect_60++;
                    }
                    if ((citizenCRUD.DataList[i].Age > 60 && citizenCRUD.DataList[i].Age <= 80))
                    {
                        detect_80++;
                    }
                    if ((citizenCRUD.DataList[i].Age > 80))
                    {
                        detect_100++;
                    }
                }
            }
            chartAge.Series["Age"].Points.AddXY("<18", detect_18);
            chartAge.Series["Age"].Points.AddXY("18<Age>40", detect_40);
            chartAge.Series["Age"].Points.AddXY("40<Age>60", detect_60);
            chartAge.Series["Age"].Points.AddXY("60<Age>80", detect_80);
            chartAge.Series["Age"].Points.AddXY("40<Age>60", detect_100);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
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
