using NadraManagementGUI.BL;
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
    public partial class frmCovidCard : Form
    {
        private citizen person;
        public frmCovidCard(citizen person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void frmCovidCard_Load(object sender, EventArgs e)
        {
            lblName.Text = person.Name;
            lblCnic.Text = person.Cnic;
            lblDOB.Text = $"{person.Date}-{person.Month}-{person.Year}";
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            PrintDialog d = new PrintDialog();
            d.ShowDialog();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
