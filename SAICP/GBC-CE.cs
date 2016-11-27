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
    public partial class frmQueryExpenseRecords : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;

        public frmQueryExpenseRecords(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
            MaximizeBox = false;
        }

        private void newQueryExpenseRecords_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);

            cldDate.SelectedDate = DateTime.Today.Date;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmQueryExpenseRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea regresar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Hide();
                windowMenu.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void cldDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            // SELECT CAST(ROUND(123.4567, 2) AS MONEY)
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT date, description, amount, supplier FROM expenditures WHERE date=@date", connection);
            SqlDataReader reader;

            command.Parameters.AddWithValue("@date", cldDate.SelectedDate.Date);

            dgvData.Rows.Clear();

            connection.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    string[] data = { reader["supplier"].ToString(), reader["description"].ToString(), "$ " + reader.GetSqlMoney(reader.GetOrdinal("amount")).ToString(), reader.GetDateTime(reader.GetOrdinal("date")).ToString("d") };
                    dgvData.Rows.Add(data);
                }
            }

            connection.Close();
        }
    }
}