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

namespace SAICP
{
    public partial class frmNewMedicalQuery : DevComponents.DotNetBar.Metro.MetroForm
    {
        private bool FlagFromClosingAfterSavingData;
        private frmMain windowMenu;

        public frmNewMedicalQuery(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
        }

        private void frmNewMedicalQuery_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            lblF_Date.Text = lblDate.Text;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void frmNewMedicalQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? Los datos no guardados se perderán", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
            else {
                Hide();
                windowMenu.Show();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar)) {
                if (txtName.Text.Length == 0 || txtName.Text.Substring(txtName.Text.Length - 1) == " ") {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                    if (e.KeyChar == (char)Keys.Enter)
                        txtWeight.Focus();
                }
                else if (e.KeyChar == (char)Keys.Enter)
                    txtWeight.Focus();
            }
            else
                e.Handled = true;
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) {
                if (e.KeyChar == (char)Keys.Enter)
                    txtSize.Focus();
            }
            else
                e.Handled = true;
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) {
                if (e.KeyChar == (char)Keys.Enter)
                    txtIMC.Focus();
            }
            else
                e.Handled = true;
        }

        private void txtIMC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) {
                if (e.KeyChar == (char)Keys.Enter)
                    txtHead_Circunference.Focus();
            }
            else
                e.Handled = true;
        }

        private void txtHead_Circunference_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) {
                if (e.KeyChar == (char)Keys.Enter)
                    txtReason.Focus();
            }
            else
                e.Handled = true;
        }

        private void txtReason_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar)) {
                if (txtReason.Text.Length == 0 )
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                else if (e.KeyChar == (char)Keys.Enter)
                    txtPhysical_Exploration.Focus();
            }
            else
                e.Handled = true;
        }

        private void txtPhysical_Exploration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar)) {
                if (txtPhysical_Exploration.Text.Length == 0 )
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                else if (e.KeyChar == (char)Keys.Enter)
                    txtDiagnostic.Focus();
            }
            else
                e.Handled = true;
        }

        private void txtDiagnostic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar)) {
                if (txtDiagnostic.Text.Length == 0 )
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                else if (e.KeyChar == (char)Keys.Enter)
                    txtTreatment.Focus();
            }
            else
                e.Handled = true;
        }

        private void txtTreatment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar)) {
                if (txtTreatment.Text.Length == 0 )
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                else if (e.KeyChar == (char)Keys.Enter)
                    cmdSave.Focus();
            }
            else
                e.Handled = true;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string buildInsertCommand = @"INSERT INTO medical_querys VALUES (
            @name,
            @date,
            @weight,
            @size,
            @IMC,
            @cephalic_perimeter,
            @reason,
            @physical_exploration,
            @diagnostic,
            @treatment
            );";

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP;Integrated Security=True");
            SqlCommand command = new SqlCommand(buildInsertCommand, connection);

            pgrSaving.Visible = true;

            if (ValidateDataAndAsignSqlCommandParameters(command)) {

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                pgrSaving.PerformStep(); 
                pgrSaving.Visible = false;

                MessageBox.Show("Consulta médica guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FlagFromClosingAfterSavingData = true;

                if (MessageBox.Show("¿Desea registrar otra consulta médica?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    frmNewClinicalRecord windowNewClinicalRecord = new frmNewClinicalRecord(windowMenu);
                    Hide();
                    windowNewClinicalRecord.Show();
                    Close();
                }
                else {
                    Hide();
                    windowMenu.Show();
                    Close();
                }
            }
            else
                MessageBox.Show("Faltan campos obligatorios por llenar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateDataAndAsignSqlCommandParameters(SqlCommand command)
        {

            // Validacion del nombre
            if (txtName.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@name", txtName.Text);

            // Validacion de la fecha
            if (lblF_Date.Text == "")
                return false;
            else
                command.Parameters.AddWithValue("@date", lblF_Date.Text);

            // Validacion del peso del paciente
            if (txtWeight.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@weight", txtWeight.Text);

            // Validacion de la talla del paciente
            if (txtSize.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@size", txtSize.Text);

            // Validacion del IMC del paciente
            if (txtIMC.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@IMC", txtIMC.Text);

            // Validacion del perimetro cefalico al nacimiento del paciente
            if (txtHead_Circunference.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@cephalic_perimeter", txtHead_Circunference.Text);

            // Validacion de la motivo
            if (txtReason.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@reason", txtReason.Text);

            // Validacion de la explaración física del paciente
            if (txtPhysical_Exploration.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@physical_exploration", txtPhysical_Exploration.Text);

            // Validacion del diagnóstico
            if (txtDiagnostic.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@diagnostic", txtDiagnostic.Text);

            // Validacion del tratamiento
            if (txtTreatment.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@treatment", txtTreatment.Text);

            pgrSaving.PerformStep(); 

            return true;
        }

        private void stiTable_Click(object sender, EventArgs e)
        {

        }

    }
}