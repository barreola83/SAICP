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
        private bool dateSelected = false;
        private bool FormClosingAfterSaving = false;

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

            cldDate.SelectedDate = DateTime.Today;
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
            if (!FormClosingAfterSaving)
            {
                if (MessageBox.Show("¿Seguro que desea salir? Los datos no guardados se perderán", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Hide();
                    windowMenu.Show();
                }
                else
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
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand("INSERT INTO earnings VALUES (@date, @ID_medical_query, @amount);", connection);
                SqlCommand commandToModify = new SqlCommand("UPDATE medical_querys SET medical_query_registered = 1 WHERE ID=@ID;", connection);

                command.Parameters.AddWithValue("@date", cldDate.SelectedDate.Date);
                command.Parameters.AddWithValue("@ID_medical_query", cmbDateNumber.GetItemText(cmbDateNumber.SelectedItem));
                command.Parameters.AddWithValue("@amount", txtPrice.Text);
                
                commandToModify.Parameters.AddWithValue("@ID", cmbDateNumber.GetItemText(cmbDateNumber.SelectedItem));

                connection.Open();

                command.ExecuteNonQuery();
                commandToModify.ExecuteNonQuery();

                connection.Close();

                FormClosingAfterSaving = true;

                MessageBox.Show("Ingreso guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("¿Desea registrar otro ingreso?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            getMedicalQueryID();
        }

        public void getMedicalQueryID()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT ID FROM medical_querys WHERE medical_query_registered=0;", connection);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            cmbDateNumber.DisplayMember = "ID";
            cmbDateNumber.DataSource = dataTable;
            cmbDateNumber.ValueMember = "ID";
            connection.Close();
        }
    }
}