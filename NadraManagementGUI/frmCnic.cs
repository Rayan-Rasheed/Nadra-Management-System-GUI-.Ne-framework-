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
    public partial class frmCnic : Admin
    {
        public frmCnic()
        {
            InitializeComponent();
        }

        private void frmCnic_Load(object sender, EventArgs e)
        {
            pnlCnic.Hide();
            cmdPrint.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlCnic.Show();
            cmdPrint.Show();
            try
            {
                citizen person = citizenCRUD.citizenFromTokenNumber(int.Parse(txtToken.Text));
                if (person != null)
                {
                    lblName.Text = person.Name;
                    lblFatherName.Text = person.FatherName;
                    lblGender.Text = person.Gender;
                    lblCnicNo.Text = person.Cnic;
                    lblDOB.Text = $"{person.Date}-{person.Month}-{person.Year}";


                }

                else
                {
                    MessageBox.Show("Invalid Token Number!");
                }
            }
            catch(Exception rayan)
            {
                MessageBox.Show(rayan.ToString());
            }
             


        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
          
        }

        private void pnlCnic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdPrint_Click_1(object sender, EventArgs e)
        {
            PrintDialog d = new PrintDialog();
            d.ShowDialog();
        }
    }
}
