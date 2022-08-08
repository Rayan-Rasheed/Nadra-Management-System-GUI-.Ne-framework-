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
    public partial class frmDeleteAccount : Admin
    {
        public frmDeleteAccount()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            dataGridViewDeleteAccount.DataSource = null;
            dataGridViewDeleteAccount.DataSource = MUserCRUD.UsersList;
            dataGridViewDeleteAccount.Refresh();
        }


        private void dataGridViewDeleteAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MUser person = (MUser)dataGridViewDeleteAccount.CurrentRow.DataBoundItem;
            if (dataGridViewDeleteAccount.Columns["Delete"].Index == e.ColumnIndex)
            {
                MUserCRUD.deleteUserFromList(person);
                MUserCRUD.storeUserIntoFile(FilePath.credentialPath);
                dataBind();
            }
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

        private void frmDeleteAccount_Load(object sender, EventArgs e)
        {
            dataGridViewDeleteAccount.DataSource = MUserCRUD.UsersList;

        }
    }
}
