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
    public partial class frmNewEarningRecord : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;

        public frmNewEarningRecord(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
        }

        private void frmNewEarningRecord_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void frmNewEarningRecord_FormClosed(object sender, FormClosedEventArgs e)
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