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
    public partial class frmNewExpenseRecord : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;
        bool dateSelected = false;
        public frmNewExpenseRecord(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
            MaximizeBox = false;
            cldDate.MaxSelectionCount = 1;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Length == 0 || txtPrice.Text.Length == 0 || txtSupplier.Text.Length == 0 || dateSelected == false)
            {
                MessageBox.Show("Debe llenar los datos correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand("INSERT INTO expenditures VALUES(@date, @description, @amount, @supplier)", connection);

                command.Parameters.AddWithValue("@date", cldDate.SelectedDate);
                command.Parameters.AddWithValue("@description", txtDescription.Text);
                command.Parameters.AddWithValue("@amount",txtPrice.Text);
                command.Parameters.AddWithValue("@supplier",txtSupplier.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                txtDescription.Clear();
                txtPrice.Clear();
                txtSupplier.Clear();
                cldDate.SelectedDate = cldDate.TodayDate;

                if (MessageBox.Show("¿Desea registrar otro egreso?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmNewExpenseRecord windowNewExpenseRecord = new frmNewExpenseRecord(windowMenu);
                    Hide();
                    windowNewExpenseRecord.Show();
                    Close();
                }
                else
                {
                    Hide();
                    Close();
                    windowMenu.Show();
                }

            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) ? true : false;

            if (e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                if(e.KeyChar == (char)Keys.Enter)
                {
                    txtSupplier.Focus();
                }
            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                txtPrice.Focus();
            }
        }

        private void txtSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void cldDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateSelected = true;
        }
    }
}