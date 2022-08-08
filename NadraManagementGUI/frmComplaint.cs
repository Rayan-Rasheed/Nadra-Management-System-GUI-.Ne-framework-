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
    public partial class frmComplaint : Admin
    {
        public frmComplaint()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            gvComplaint.DataSource = null;
            gvComplaint.DataSource = ComplaintCRUD.ComplaintList;
            gvComplaint.Refresh();
        }

        private void frmComplaint_Load(object sender, EventArgs e)
        {
            gvComplaint.DataSource = ComplaintCRUD.ComplaintList;

        }

        private void gvComplaint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Complaint cmp = (Complaint)gvComplaint.CurrentRow.DataBoundItem;
            if (gvComplaint.Columns["Reply"].Index == e.ColumnIndex)
            {
                frmComplaintReply form = new frmComplaintReply(cmp);
                form.Show();

            }
        }
    }
}
