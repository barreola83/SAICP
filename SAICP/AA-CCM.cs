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
    public partial class frmQueryMedicalDates : DevComponents.DotNetBar.Metro.MetroForm
    {
        private enum SearchBy
        {
            Name = 0,
            Date = 1
        };

        private frmMain windowMenu;
        private SearchBy search;
        private List<PacientData> pacientList = new List<PacientData>();
        private bool searchFound = false;

        public frmQueryMedicalDates(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
            MaximizeBox = false;
        }

        private void frmQueryMedicalDates_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);

            SetAutoCompleteCustomSourceByName();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void frmQueryMedicalDates_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtSearchByName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                if (txtSearchByName.Text.Length == 0 || txtSearchByName.Text.Substring(txtSearchByName.Text.Length - 1) == " ")
                    e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            else
                e.Handled = true;
        }

        private void SetAutoCompleteCustomSourceByName()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT folio, name, first_last_name, second_last_name, contact_phone FROM clinical_records", connection);
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

                    pacientList.Add(pacient);
                }
            }

            connection.Close();

            txtSearchByName.AutoCompleteCustomSource = data;
        }

        private void cldDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT date, time, name, contact_phone, folio FROM agenda WHERE date=@date;", connection);
            SqlDataReader reader;

            command.Parameters.AddWithValue("@date", cldDate.SelectedDate.Date);

            dgvData.Rows.Clear();
            txtSearchByName.Clear();

            connection.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                search = SearchBy.Date;
                searchFound = true;

                while (reader.Read())
                {
                    string[] data = { reader["name"].ToString(), reader.GetDateTime(reader.GetOrdinal("date")).ToString("d"), reader.GetTimeSpan(reader.GetOrdinal("time")).ToString(), reader["contact_phone"].ToString() };
                    dgvData.Rows.Add(data);
                }

                btnDelete.Enabled = true;
            }
            else
            {
                searchFound = false;
                btnDelete.Enabled = false;
            }

            connection.Close();
        }

        private void txtSearchByName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT name, date, time, contact_phone FROM agenda WHERE name=@name;", connection);
                SqlDataReader reader;

                command.Parameters.AddWithValue("@name", txtSearchByName.Text);

                dgvData.Rows.Clear();

                connection.Open();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    search = SearchBy.Name;
                    searchFound = true;

                    while (reader.Read())
                    {
                        string[] data = { reader["name"].ToString(), reader.GetDateTime(reader.GetOrdinal("date")).ToString("d"), reader.GetTimeSpan(reader.GetOrdinal("time")).ToString(), reader["contact_phone"].ToString() };
                        dgvData.Rows.Add(data);
                    }

                    btnDelete.Enabled = true;
                }
                else
                {
                    searchFound = false;
                    btnDelete.Enabled = false;
                }

                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.GetRowCount(DataGridViewElementStates.Selected) != 0 && searchFound)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar la cita médica?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                    SqlCommand command = new SqlCommand("DELETE FROM agenda WHERE name=@name AND (date=@date AND time=@time);", connection);

                    command.Parameters.AddWithValue("@name", dgvData.Rows[dgvData.CurrentCell.RowIndex].Cells["name"].Value.ToString());
                    command.Parameters.AddWithValue("@date", DateTime.Parse(dgvData.Rows[dgvData.CurrentCell.RowIndex].Cells["date"].Value.ToString()).Date);
                    command.Parameters.AddWithValue("@time", TimeSpan.Parse(dgvData.Rows[dgvData.CurrentCell.RowIndex].Cells["time"].Value.ToString()));

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();

                    dgvData.Rows.RemoveAt(dgvData.CurrentCell.RowIndex);
                }
            }
            else
                MessageBox.Show("Seleccione una cita", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            if (dgvData.Rows.GetRowCount(DataGridViewElementStates.Selected) != 0 && searchFound)
            {
                frmUpdateMedicalDate updateMedicalDate = new frmUpdateMedicalDate(dgvData.Rows[dgvData.CurrentCell.RowIndex].Cells["name"].Value.ToString(), 
                                                                                  dgvData.Rows[dgvData.CurrentCell.RowIndex].Cells["contact_phone"].Value.ToString(), 
                                                                                  DateTime.Parse(dgvData.Rows[dgvData.CurrentCell.RowIndex].Cells["date"].Value.ToString()).Date, 
                                                                                  TimeSpan.Parse(dgvData.Rows[dgvData.CurrentCell.RowIndex].Cells["time"].Value.ToString()));

                updateMedicalDate.ShowDialog();

                RefreshDataGridView();
            }
        }

        private void RefreshDataGridView()
        {
            if (search == SearchBy.Date)
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT date, time, name, contact_phone, folio FROM agenda WHERE date=@date;", connection);
                SqlDataReader reader;

                command.Parameters.AddWithValue("@date", cldDate.SelectedDate.Date);

                dgvData.Rows.Clear();
                txtSearchByName.Clear();

                connection.Open();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    search = SearchBy.Date;
                    searchFound = true;

                    while (reader.Read())
                    {
                        string[] data = { reader["name"].ToString(), reader.GetDateTime(reader.GetOrdinal("date")).ToString("d"), reader.GetTimeSpan(reader.GetOrdinal("time")).ToString(), reader["contact_phone"].ToString() };
                        dgvData.Rows.Add(data);
                    }

                    btnDelete.Enabled = true;
                }
                else
                {
                    searchFound = false;
                    btnDelete.Enabled = false;
                }

                connection.Close();
            }
            else if (search == SearchBy.Name)
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT name, date, time, contact_phone FROM agenda WHERE name=@name;", connection);
                SqlDataReader reader;

                command.Parameters.AddWithValue("@name", txtSearchByName.Text);

                dgvData.Rows.Clear();

                connection.Open();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    search = SearchBy.Name;
                    searchFound = true;

                    while (reader.Read())
                    {
                        string[] data = { reader["name"].ToString(), reader.GetDateTime(reader.GetOrdinal("date")).ToString("d"), reader.GetTimeSpan(reader.GetOrdinal("time")).ToString(), reader["contact_phone"].ToString() };
                        dgvData.Rows.Add(data);
                    }

                    btnDelete.Enabled = true;
                }
                else
                {
                    searchFound = false;
                    btnDelete.Enabled = false;
                }

                connection.Close();
            }
        }
    }
}