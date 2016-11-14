using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace SAICP
{
    public partial class frmMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void mnuNewClinicalRecord_Click(object sender, EventArgs e)
        {
            frmNewClinicalRecord windowNewClinicalRecord = new frmNewClinicalRecord(this);

            this.Hide();
            windowNewClinicalRecord.Show();
        }

        // Pruebas
        private void mnuTesting_Click(object sender, EventArgs e)
        {
            frmTest test = new frmTest();
            test.ShowDialog();
        }
        // Fin de pruebas
    }
}