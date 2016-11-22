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
using System.Collections;

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
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand("INSERT INTO earnings VALUES (@date, @ID_medical_query, @amount)", connection);
                SqlCommand commandToModify = new SqlCommand("UPDATE medical_querys SET medical_query_registered = 1 WHERE folio = " + cmbDateNumber.SelectedItem.ToString(), connection);
                command.Parameters.AddWithValue("@date", cldDate.SelectedDate);
                command.Parameters.AddWithValue("@ID_medical_query", int.Parse(cmbDateNumber.SelectedItem.ToString()));
                command.Parameters.AddWithValue("@amount", int.Parse(txtPrice.Text));

                connection.Open();
                command.ExecuteNonQuery();
                commandToModify.ExecuteNonQuery();
                connection.Close();

                if (MessageBox.Show("¿Desea registrar otro egreso?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmNewEarningRecord windowNewEarningRecord = new frmNewEarningRecord(windowMenu);
                    Hide();
                    windowNewEarningRecord.Show();
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

        private void cldDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateSelected = true;
            getFolio();
        }

        public void getFolio()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT folio FROM medical_querys WHERE medical_query_registered = 0", connection);
            connection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet);
            cmbDateNumber.DataSource = dataSet.Tables[0].DefaultView;
            cmbDateNumber.ValueMember = "folio";
            connection.Close();
        }
    }
}