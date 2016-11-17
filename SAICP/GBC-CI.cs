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
    public partial class frmQueryEarningRecords : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;

        public frmQueryEarningRecords(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
        }

        private void frmQueryEarningRecords_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void frmQueryEarningRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("�Seguro que desea cancelar? Los datos no guardados se perder�n", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();
                windowMenu.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�Seguro que desea cancelar? Los datos no guardados se perder�n", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();
                windowMenu.Show();
            }
        }
    }
}