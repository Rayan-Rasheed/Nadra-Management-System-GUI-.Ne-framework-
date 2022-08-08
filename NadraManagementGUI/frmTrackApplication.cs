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
    public partial class frmTrackApplication : frmApplicant
    {
        public frmTrackApplication()
        {
            InitializeComponent();
        }

        private void frmTrackApplication_Load(object sender, EventArgs e)
        {
            pnlFind1.Hide();
            pnlFind2.Hide();
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            pnlFind1.Show();
            pnlFind2.Show();
        }

        private void cmdFinded_Click(object sender, EventArgs e)
        {
            citizen person = citizenCRUD.isCitizenExist(txtCnic.Text);
            if (person != null)
            {
                if(person.TokenNumber!=0)
                MessageBox.Show("Your tacking id is "+person.TokenNumber);
                else
                MessageBox.Show("No tracing ID found..Your application is in process");



            }
            else
            {
                MessageBox.Show("No registeres application found against this Cnic");
            }
        }

        private void cmdtrack_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtTrack.Text) < 2000 && int.Parse(txtTrack.Text) > 1000)
            {
                citizen person = citizenCRUD.citizenFromTokenNumber(int.Parse(txtTrack.Text));
                if (person != null)
                {
                    MessageBox.Show(person.Name +"your application against tacking id  " + person.TokenNumber+"is in completion mode.");

                }
                else
                {
                    MessageBox.Show("Invalid!");

                }
            }
            else
            {
                MessageBox.Show("Invalid!");
            }
        }

        private void cmdFind_Click_1(object sender, EventArgs e)
        {
            pnlFind1.Show();
            pnlFind2.Show();
        }
    }
}
