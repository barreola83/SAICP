using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;

namespace SAICP
{
    public partial class frmNewMedicalDate : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;
        Boolean dateSelected = false;

        public frmNewMedicalDate(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
            MaximizeBox = false;
        }

        private void frmNewMedicalDate_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void frmNewMedicalDate_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) ? true : false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFullName.Text == "" || tmsSelectHour.SelectedTime == TimeSpan.Zero || dateSelected == false)
            {
                MessageBox.Show("Ingrese los datos correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand("INSERT INTO agenda VALUES (@folio, @date, @time, @name, @contact_phone)", connection);
                command.Parameters.AddWithValue("@date", cldDate.SelectedDate);
                command.Parameters.AddWithValue("@time", tmsSelectHour.SelectedTime);
                command.Parameters.AddWithValue("@name", txtFullName.Text);
                command.Parameters.AddWithValue("@contact_phone", txtPhoneNumber.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void cldDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateSelected = true;
        }
    }
}