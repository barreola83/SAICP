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
    public partial class frmClinicalGraphicTracing : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;

        public frmClinicalGraphicTracing(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
        }

        private void frmClinicalGraphicTracing_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void frmClinicalGraphicTracing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            windowMenu.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt");
        }
    }
}