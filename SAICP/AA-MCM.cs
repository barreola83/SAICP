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
        private List<PacientData> pacientsNameList = new List<PacientData>();
        private bool dateSelected = false;
        private bool FormClosingAfterSave = false;

        public frmUpdateMedicalDate(frmMain windowMenu, string name, string contactPhone, DateTime date, TimeSpan time)
        {
            InitializeComponent();
            MaximizeBox = false;

            txtFullName.Text = name;
            txtPhoneNumber.Text = contactPhone;
            cldDate.SelectedDate = date.Date;
            tmsSelectHour.SelectedTime = time;
        }

        private void frmNewMedicalDate_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);

            cldDate.SelectedDate = DateTime.Today.Date;

            SetAutoCompleteCustomSourceByName();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void frmNewMedicalDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FormClosingAfterSave)
            {
                if (MessageBox.Show("¿Seguro que desea salir? Los datos no guardados se perderán", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Hide();
                else
                    e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                if (txtFullName.Text.Length == 0 || txtFullName.Text.Substring(txtFullName.Text.Length - 1) == " ")
                    e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            else
                e.Handled = true;
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
                SqlCommand command = new SqlCommand("INSERT INTO agenda VALUES (@date, @time, @name, @contact_phone, @folio);", connection);

                if (txtFullName.AutoCompleteCustomSource.Contains(txtFullName.Text))
                    command.Parameters.AddWithValue("@folio", pacientsNameList[txtFullName.AutoCompleteCustomSource.IndexOf(txtFullName.Text)].Folio);
                else
                    command.Parameters.AddWithValue("@folio", DBNull.Value);

                command.Parameters.AddWithValue("@date", cldDate.SelectedDate.Date);
                command.Parameters.AddWithValue("@time", tmsSelectHour.SelectedTime);
                command.Parameters.AddWithValue("@name", txtFullName.Text);
                command.Parameters.AddWithValue("@contact_phone", txtPhoneNumber.Text);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                FormClosingAfterSave = true;

                MessageBox.Show("Cita médica guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                Close();
            }
        }

        private void cldDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateSelected = true;
        }

        private void SetAutoCompleteCustomSourceByName()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT folio, name, first_last_name, second_last_name, contact_phone FROM clinical_records;", connection);
            SqlDataReader reader;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            PacientData pacient;

            connection.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pacient = new PacientData();

                    data.Add(reader["name"].ToString() + " " + reader["first_last_name"].ToString() + " " + reader["second_last_name"].ToString());

                    pacient.Folio = reader["folio"].ToString();
                    pacient.Name = reader["name"].ToString() + " " + reader["first_last_name"].ToString() + " " + reader["second_last_name"].ToString();
                    pacient.ContactPhone = reader["contact_phone"].ToString();

                    pacientsNameList.Add(pacient);
                }
            }

            connection.Close();

            txtFullName.AutoCompleteCustomSource = data;
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFullName.AutoCompleteCustomSource.Contains(txtFullName.Text))
                    txtPhoneNumber.Text = pacientsNameList[txtFullName.AutoCompleteCustomSource.IndexOf(txtFullName.Text)].ContactPhone;
            }
        }
    }
}