using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.IO;

namespace SAICP
{
    public partial class frmNewEarningRecord : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;
        bool dateSelected = false;

        public frmNewEarningRecord(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
            MaximizeBox = false;
            cldDate.MaxSelectionCount = 1;
        }
        
        private void frmNewEarningRecord_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNewEarningRecord_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) ? true : false;

            if (e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPrice.Text.Length == 0 || cmbDateNumber.SelectedIndex < 0 || dateSelected == false)
            {
                MessageBox.Show("Llene todos los datos correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);

                

            }
        }

        private void cldDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateSelected = true;
            SqlConnection connection = new SqlConnection("Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT folio FROM medical_querys WHERE medical_query_registered = 0", connection);
            cmbDateNumber.Items.Add(command);
        }
    }
}