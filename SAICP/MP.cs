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
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void mnuNewClinicalRecord_Click(object sender, EventArgs e)
        {
            frmNewClinicalRecord windowNewClinicalRecord = new frmNewClinicalRecord(this);

            Hide();
            windowNewClinicalRecord.Show();
        }

        // Pruebas
        private void mnuTesting_Click(object sender, EventArgs e)
        {
            frmTest test = new frmTest();
            test.ShowDialog();
        }
        // Fin de pruebas

        private void mnuQueryClinicalRecords_Click(object sender, EventArgs e)
        {
            frmQueryClinicalRecords windowQueryClinicalRecords = new frmQueryClinicalRecords(this);

            Hide();
            windowQueryClinicalRecords.Show();
        }

        private void mnuNewMedicalQuery_Click(object sender, EventArgs e)
        {
            frmNewMedicalQuery windowNewMedicalQuery = new frmNewMedicalQuery(this);

            Hide();
            windowNewMedicalQuery.Show();
        }

        private void mnuClinicalGraphicTracing_Click(object sender, EventArgs e)
        {
            frmClinicalGraphicTracing windowClinicalGraphicTracing = new frmClinicalGraphicTracing(this);

            Hide();
            windowClinicalGraphicTracing.Show();
        }

        private void mnuNewEarmingRecord_Click(object sender, EventArgs e)
        {
            frmNewEarningRecord windowNewEarningRecord = new frmNewEarningRecord(this);

            Hide();
            windowNewEarningRecord.Show();
        }

        private void mnuQueryEarningRecords_Click(object sender, EventArgs e)
        {
            frmQueryEarningRecords windowQueryEarningRecords = new frmQueryEarningRecords(this);

            Hide();
            windowQueryEarningRecords.Show();
        }

        private void mnuNewExpenseRecord_Click(object sender, EventArgs e)
        {
            frmNewExpenseRecord windowNewExpensesRecord = new frmNewExpenseRecord(this);

            Hide();
            windowNewExpensesRecord.Show();
        }

        private void mnuQueryExpenseRecords_Click(object sender, EventArgs e)
        {
            frmQueryExpenseRecords windowQueryExpenseRecords = new frmQueryExpenseRecords(this);

            Hide();
            windowQueryExpenseRecords.Show();
        }

        private void mnuNewMedicalDate_Click(object sender, EventArgs e)
        {
            frmNewMedicalDate windowNewMedicalDate = new frmNewMedicalDate(this);

            Hide();
            windowNewMedicalDate.Show();
        }

        private void mnuQueryMedicalDates_Click(object sender, EventArgs e)
        {
            frmQueryMedicalDates windowQueryMedicalDates = new frmQueryMedicalDates(this);

            Hide();
            windowQueryMedicalDates.Show();
        }
    }
}