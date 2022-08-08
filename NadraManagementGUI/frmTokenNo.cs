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
    public partial class frmTokenNo : Admin
    {
        public frmTokenNo()
        {
            InitializeComponent();
        }

        private void frmTokenNo_Load(object sender, EventArgs e)
        {
            gvToken.DataSource = citizenCRUD.DataList;

        }
        public void dataBind()
        {
            gvToken.DataSource = null;
            gvToken.DataSource =citizenCRUD.DataList;
            gvToken.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            citizen person = (citizen)gvToken.CurrentRow.DataBoundItem;
            if (gvToken.Columns["Generate"].Index == e.ColumnIndex)
            {
                Random r = new Random();
                person.TokenNumber = r.Next(1000,2000);
                citizenCRUD.storeDataIntoFile(FilePath.dataPath);
                dataBind();
                MessageBox.Show ($"Token Number is: {person.TokenNumber}");
                
            }

        }
    }
}
