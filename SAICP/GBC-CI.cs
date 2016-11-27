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
    public partial class frmQueryEarningRecords : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;

        public frmQueryEarningRecords(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
            MaximizeBox = false;
        }

        private void frmQueryEarningRecords_Load(object sender, EventArgs e)
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

        private void frmQueryEarningRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea regresar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Hide();
                windowMenu.Show();
            }
            else
                e.Cancel = true;
        }

        private void cldDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            //Se asigna la cadena de conexion
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT date, ID_medical_query, amount FROM earnings WHERE date=@date", connection);
            SqlDataReader reader;

            command.Parameters.AddWithValue("@date", cldDate.SelectedDate.Date);

            dgvData.Rows.Clear();

            //Se abre la conexiona la base de datos
            connection.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    string[] data = { reader["ID_medical_query"].ToString(), "$ " + reader["amount"].ToString(), reader.GetDateTime(reader.GetOrdinal("date")).ToString("d") };
                    dgvData.Rows.Add(data);
                }
            }

            // Se cierra la conexión a la base de datos
            connection.Close();
        }
    }
}