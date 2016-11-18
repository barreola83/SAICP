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
    public partial class frmNewExpenseRecord : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;

        public frmNewExpenseRecord(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
            MaximizeBox = false;
        }

        private void frmNewExpenseRecord_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNewExpenseRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? Los datos no guardados se perderán", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Hide();
                windowMenu.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}