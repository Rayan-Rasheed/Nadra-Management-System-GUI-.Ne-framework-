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
    public partial class frmHealthInspect : Form
    {
        public frmHealthInspect()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHealthInspect_Load(object sender, EventArgs e)
        {
            citizen person=Communication.Person;
            lblCnic.Text = "Cnic";
            lblCnicFront.Text = person.Cnic;
            lblName.Text = "Name";
            lblNameFront.Text = person.Name;
            lblFather.Text = "Father Name";
            lblFatherFront.Text = person.FatherName;
            lblAdress.Text = person.PermanentAdress;
            lblAdressFront.Text = person.PermanentAdress;
            chartSearchAge.Series["Age"].Points.AddXY($"{person.Name}(Age in years)",person.Age);
            chartSearchIncome.Series["Income"].Points.AddXY($"{person.Name}(Income in PKR)",person.Income);




        }
    }
}
