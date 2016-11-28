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
    public partial class frmQueryMedicalQuerys : DevComponents.DotNetBar.Metro.MetroForm
    {
        private enum SearchBy
        {
            Name = 0,
            Date = 1
        };

        private frmMain windowMenu;
        private SearchBy search;
        private bool searchFound = false;

        public frmQueryMedicalQuerys(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
            MaximizeBox = false;
        }

        private void frmQueryMedicalQuerys_Load(object sender, EventArgs e)
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

        private void frmQueryMedicalQuerys_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea regresar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
            else
            {
                Hide();
                windowMenu.Show();
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetAutoCompleteCustomSourceByName()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT folio, name, first_last_name, second_last_name, contact_phone FROM clinical_records", connection);
            SqlDataReader reader;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            connection.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(reader["name"].ToString() + " " + reader["first_last_name"].ToString() + " " + reader["second_last_name"].ToString());
                }
            }

            connection.Close();

            txtSearchByName.AutoCompleteCustomSource = data;
        }

        private void txtSearchByName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (txtSearchByName.Text.Length == 0 || txtSearchByName.Text.Substring(txtSearchByName.Text.Length - 1) == " ")
                    e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            else
                e.Handled = true;
        }

        private void clnDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT folio, name, date FROM medical_querys WHERE date=@date;", connection);
            SqlDataReader reader;

            txtSearchByName.Clear();
            dgvData.Rows.Clear();

            command.Parameters.AddWithValue("@date", clnDate.SelectedDate.Date);

            connection.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                search = SearchBy.Date;
                searchFound = true;

                while (reader.Read())
                {
                    string[] data = { reader["name"].ToString(), reader["folio"].ToString(), reader.GetDateTime(reader.GetOrdinal("date")).Date.ToString("d") };
                    dgvData.Rows.Add(data);
                }
            }
            else
                searchFound = false;

            connection.Close();
        }

        private void txtSearchByName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT folio, name, date FROM medical_querys WHERE name=@name;", connection);
                SqlDataReader reader;

                dgvData.Rows.Clear();

                command.Parameters.AddWithValue("@name", txtSearchByName.Text);

                connection.Open();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    search = SearchBy.Name;
                    searchFound = true;

                    while (reader.Read())
                    {
                        string[] data = { reader["name"].ToString(), reader["folio"].ToString(), reader.GetDateTime(reader.GetOrdinal("date")).Date.ToString("d") };
                        dgvData.Rows.Add(data);
                    }
                }
                else
                    searchFound = false;

                connection.Close();
            }
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            if (dgvData.Rows.GetRowCount(DataGridViewElementStates.Selected) != 0 && searchFound)
            {

            }
        }
    }
}