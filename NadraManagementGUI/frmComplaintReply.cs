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
    public partial class frmComplaintReply : Form
    {
        Complaint comp;
        public frmComplaintReply(Complaint comp)
        {
            this.comp = comp;
            InitializeComponent();
        }

        private void frmComplaintReply_Load(object sender, EventArgs e)
        {
            pnlReply.Hide();
            lblEmail.Text = comp.Email;
            lblComplaint.Text = comp.Complaints;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlReply.Show();

        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            comp.Reply = txtReply.Text;
            pnlReply.Hide();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
