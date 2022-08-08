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
    public partial class frmSortedCitizen : Admin
    {
        public frmSortedCitizen()
        {
            InitializeComponent();
        }

        public void dataBind()
        {
            dataGridViewSorted.DataSource = null;
            dataGridViewSorted.DataSource = citizenCRUD.SortedDataList;
            dataGridViewSorted.Refresh();
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSortedCitizen_Load(object sender, EventArgs e)
        {
            citizenCRUD.sortedDatalist();
            dataGridViewSorted.DataSource = citizenCRUD.SortedDataList;


        }

        private void dataGridViewSorted_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridViewSorted_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
