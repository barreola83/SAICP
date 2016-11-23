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

        private void cldDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            string date;
            //Se asigna la cadena de conexion
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SAICP-Database;Integrated Security=True");

            //Se abre la conexiona la base de datos
            connection.Open();

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dataTable = new DataTable();

            date = cldDate.SelectedDate.ToString();
            // Se crea un SqlAdapter para obtener los datos de la base
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT date, ID_medical_query, amount FROM earnings WHERE date = " + date, connection);

            // Con la información del adaptador se rellena el DataTable
            dataAdapter.Fill(dataTable);

            // Se asigna el DataTable como origen de datos del DataGridView
            dgvData.DataSource = dataTable;

            // Se cierra la conexión a la base de datos
            connection.Close();

        }
    }
}