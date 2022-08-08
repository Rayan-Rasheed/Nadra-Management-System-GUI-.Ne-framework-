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
    public partial class frmInvoice : Admin
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            int bill = 0;
            try
            {
                citizen person = citizenCRUD.citizenFromTokenNumber(int.Parse(txtToken.Text));
                if (chkCnic.Checked)
                {
                    if (rdUrgent.Checked)
                    {


                        bill = 2500;
                        lblAppFront.Text = "Urgent";
                        lblName.Text = "Total Invoice:";
                        //lblNameFront.Text = person.Name;
                        lblApp.Text = "Application Status:";
                        lblID.Text = "ID No.";
                        lblIDNo.Text = person.Cnic;
                        //lblInvoice.Text = "Name";
                        lblNameFront.Text = $"{ bill}";

                    }
                    else if (rdRegular.Checked)
                    {
                        bill = 1500;
                        lblAppFront.Text = "Regular";
                        lblName.Text = "Total Invoice:";
                        //lblNameFront.Text = person.Name;
                        lblApp.Text = "Application Status:";
                        lblID.Text = "ID No.";
                        lblIDNo.Text = person.Cnic;
                        //lblInvoice.Text = "Name";
                        lblNameFront.Text = $"{ bill}";

                    }
                    else
                    {
                        MessageBox.Show("Select Urgent or Regular");
                       
                    }
                }
                else
                {
                    MessageBox.Show("Invalid");
                }

            }
            catch(Exception exe)
            {
                MessageBox.Show("Invalid");
            }


            
        }
    }
}
