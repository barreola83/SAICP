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
    public partial class frmPatientData : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;
        
        public frmPatientData(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
        }

        private void frmQueryMedicalQuerysPatientData_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void frmPatientData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
            else {
                frmQueryMedicalQuerys windowQueryMedicalQuerys = new frmQueryMedicalQuerys(windowMenu);

                Hide();
                windowQueryMedicalQuerys.Show();
            }
        }

        private void cmdBCM_Back_Click(object sender, EventArgs e)
        {
            frmQueryMedicalQuerys windowQueryMedicalQuerys = new frmQueryMedicalQuerys(windowMenu);
            if (MessageBox.Show("¿Seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) { 
                Hide();
                windowQueryMedicalQuerys.Show();
            }
            else{}
        }

        private void cmdBCMDP_Save_Click(object sender, EventArgs e)
        {
            frmQueryMedicalQuerys windowQueryMedicalQuerys = new frmQueryMedicalQuerys(windowMenu);
            if (MessageBox.Show("¿Desea guardar los cambios realizados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Hide();
                windowQueryMedicalQuerys.Show();
            }
            else { }
        }
    }
}