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
    public partial class frmUpdateMedicalDate : DevComponents.DotNetBar.Metro.MetroForm
    {
        private bool dateSelected = false;
        private bool FormClosingAfterSave = false;
        private DateTime oldDate;
        private TimeSpan oldTime;

        public frmUpdateMedicalDate(string name, string contactPhone, DateTime date, TimeSpan time)
        {
            InitializeComponent();
            MaximizeBox = false;

            txtFullName.Text = name;
            txtPhoneNumber.Text = contactPhone;
            cldDate.SelectedDate = date.Date;
            tmsSelectHour.SelectedTime = time;

            oldDate = date.Date;
            oldTime = time;

            cldDate.DisplayMonth = date.Date;

        }

        private void frmUpdateMedicalDate_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void frmUpdateMedicalDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FormClosingAfterSave)
            {
                if (MessageBox.Show("¿Seguro que desea salir? Los datos no guardados se perderán", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Hide();
                }
                else
                    e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || tmsSelectHour.SelectedTime == TimeSpan.Zero || dateSelected == false)
            {
                MessageBox.Show("Ingrese los datos correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand("UPDATE agenda SET date=@date, time=@time, contact_phone=@contact_phone WHERE name=@name AND (date=@old_date AND time=@old_time);", connection);

                command.Parameters.AddWithValue("@date", cldDate.SelectedDate.Date);
                command.Parameters.AddWithValue("@time", tmsSelectHour.SelectedTime);
                command.Parameters.AddWithValue("@contact_phone", txtPhoneNumber.Text);

                command.Parameters.AddWithValue("@name", txtFullName.Text);
                command.Parameters.AddWithValue("@old_date", oldDate.Date);
                command.Parameters.AddWithValue("@old_time", oldTime);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                FormClosingAfterSave = true;

                MessageBox.Show("Cita médica actualizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                Close();
            }
        }

        private void cldDate_DateChanged(object sender, EventArgs e)
        {
            dateSelected = true;
        }
    }
}