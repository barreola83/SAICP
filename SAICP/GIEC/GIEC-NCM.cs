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
        private frmMain windowMenu;
        private List<PacientData> pacientsList = new List<PacientData>();
        private bool FlagFromClosingAfterSavingData = false;

        public frmNewMedicalQuery(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
            MaximizeBox = false;
        }

        private void frmNewMedicalQuery_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);

            SetAutoCompleteCustomSourceToFolioAndName();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void frmNewMedicalQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FlagFromClosingAfterSavingData)
            {
                if (MessageBox.Show("¿Seguro que desea salir? Los datos no guardados se perderán", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    e.Cancel = true;
                else
                {
                    Hide();
                    windowMenu.Show();
                }
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (txtName.Text.Length == 0 || txtName.Text.Substring(txtName.Text.Length - 1) == " ")
                    e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            else
                e.Handled = true;
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txtSize.Focus();
            }
            else
                e.Handled = true;
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                    SqlCommand command = new SqlCommand("SELECT ");

                    txtIMC.Focus();
                }
            }
            else
                e.Handled = true;
        }

        private void txtIMC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txtHead_Circunference.Focus();
            }
            else
                e.Handled = true;
        }

        private void txtHead_Circunference_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txtReason.Focus();
            }
            else
                e.Handled = true;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string buildInsertCommand = @"INSERT INTO medical_querys VALUES (
            @folio,
            @name,
            @date,
            @reason,
            @physical_exploration,
            @diagnostic,
            @treatment,
            @weight,
            @size,
            @IMC,
            @cephalic_perimeter,
            @medical_query_registered
            );";

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand(buildInsertCommand, connection);

            pgrSaving.Visible = true;

            if (ValidateDataAndAsignSqlCommandParameters(command))
            {

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                pgrSaving.PerformStep();
                pgrSaving.Visible = false;

                MessageBox.Show("Consulta médica guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FlagFromClosingAfterSavingData = true;

                if (MessageBox.Show("¿Desea registrar otra consulta médica?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmNewClinicalRecord windowNewClinicalRecord = new frmNewClinicalRecord(windowMenu);
                    Hide();
                    windowNewClinicalRecord.Show();
                    Close();
                }
                else
                {
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

            // Validacion del folio
            if (txtFolio.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@folio", txtFolio.Text);

            // Validacion de la fecha
            command.Parameters.AddWithValue("@date", DateTime.Today.Date);

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

            // Asignar a 0 el parametro de medical_query_registered
            command.Parameters.AddWithValue("@medical_query_registered", 0);

            pgrSaving.PerformStep();

            return true;
        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
            {
                if (Char.IsLetter(e.KeyChar))
                    e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void SetAutoCompleteCustomSourceToFolioAndName()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT folio, name, first_last_name, second_last_name FROM clinical_records;", connection);
            SqlDataReader reader;
            AutoCompleteStringCollection dataNames = new AutoCompleteStringCollection(), dataFolio = new AutoCompleteStringCollection();
            PacientData pacient;

            connection.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pacient = new PacientData();

                    dataNames.Add(reader["name"].ToString() + " " + reader["first_last_name"].ToString() + " " + reader["second_last_name"].ToString());
                    dataFolio.Add(reader["folio"].ToString());

                    pacient.Name = reader["name"].ToString() + " " + reader["first_last_name"].ToString() + " " + reader["second_last_name"].ToString();
                    pacient.Folio = reader["folio"].ToString();

                    pacientsList.Add(pacient);
                }
            }

            connection.Close();

            txtName.AutoCompleteCustomSource = dataNames;
            txtFolio.AutoCompleteCustomSource = dataFolio;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtName.AutoCompleteCustomSource.Contains(txtName.Text))
                {
                    txtFolio.Text = pacientsList[txtName.AutoCompleteCustomSource.IndexOf(txtName.Text)].Folio;
                    txtWeight.Focus();
                }
            }
        }

        private void txtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFolio.AutoCompleteCustomSource.Contains(txtFolio.Text))
                {
                    txtName.Text = pacientsList[txtFolio.AutoCompleteCustomSource.IndexOf(txtFolio.Text)].Name;
                    txtWeight.Focus();
                }
            }
        }

        private void stiGraphics_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 && txtFolio.Text.Length == 0 && txtSize.Text.Length == 0 && txtIMC.Text.Length == 0)
                MessageBox.Show("Falta información para generar gráficas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT size, IMC FROM medical_querys WHERE folio=@folio", connection);
                SqlDataReader reader;
                int NumberOfMedicalQuery = 0;

                sptSize.Focus();

                // Limpiamos las graficas
                chrSize.Titles.Clear();
                chrSize.Legends.Clear();
                chrSize.Series.Clear();

                chrIMC.Titles.Clear();
                chrIMC.Legends.Clear();
                chrIMC.Series.Clear();

                // Titulos de la graficas
                chrSize.Titles.Add(txtName.Text);

                chrIMC.Titles.Add(txtName.Text);

                // Agregar leyendas
                chrSize.Legends.Add("Talla");
                chrIMC.Legends.Add("IMC");

                // Agregar series
                chrSize.Series.Add("Talla");
                chrSize.Series.Add("TallaPoint").IsVisibleInLegend = false;
                chrSize.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chrSize.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chrSize.ChartAreas[0].AxisX.IsMarginVisible = false;
                chrSize.ChartAreas[0].AxisY.Title = "Centímetros";
                chrSize.ChartAreas[0].AxisX.Title = "Número de consulta";
                chrSize.Series["Talla"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                chrSize.Series["TallaPoint"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chrSize.Series["TallaPoint"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                chrSize.Series["TallaPoint"].MarkerColor = Color.Red;
                chrSize.Series["Talla"].BorderWidth = 2;
                chrSize.Series["Talla"].BorderColor = Color.Gray;
                chrSize.Series["Talla"].Color = Color.LightBlue;

                chrIMC.Series.Add("IMC");
                chrIMC.Series.Add("IMCPoint").IsVisibleInLegend = false;
                chrIMC.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chrIMC.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chrIMC.ChartAreas[0].AxisX.IsMarginVisible = false;
                chrIMC.ChartAreas[0].AxisY.Title = "Kg / M^2";
                chrIMC.ChartAreas[0].AxisX.Title = "Número de consulta";
                chrIMC.Series["IMC"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                chrIMC.Series["IMCPoint"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chrIMC.Series["IMCPoint"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                chrIMC.Series["IMCPoint"].MarkerSize = 10;
                chrIMC.Series["IMCPoint"].MarkerColor = Color.DarkBlue;
                chrIMC.Series["IMC"].BorderWidth = 2;
                chrIMC.Series["IMC"].BorderColor = Color.Gray;
                chrIMC.Series["IMC"].Color = Color.LightSalmon;

                chrSize.Series["Talla"].Points.AddXY("0", 0);
                chrSize.Series["TallaPoint"].Points.AddY(0);

                chrIMC.Series["IMC"].Points.AddXY("0", 0);
                chrIMC.Series["IMCPoint"].Points.AddY(0);

                command.Parameters.AddWithValue("@folio", txtFolio.Text);

                connection.Open();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        NumberOfMedicalQuery++;

                        chrSize.Series["Talla"].Points.AddXY(NumberOfMedicalQuery.ToString(), reader.GetFloat(reader.GetOrdinal("size")));
                        chrSize.Series["TallaPoint"].Points.AddY(reader.GetFloat(reader.GetOrdinal("size")));

                        chrIMC.Series["IMC"].Points.AddXY(NumberOfMedicalQuery.ToString(), reader.GetFloat(reader.GetOrdinal("IMC")));
                        chrIMC.Series["IMCPoint"].Points.AddY(reader.GetFloat(reader.GetOrdinal("IMC")));
                    }
                }

                connection.Close();

                NumberOfMedicalQuery++;

                chrSize.Series["Talla"].Points.AddXY(NumberOfMedicalQuery.ToString(), float.Parse(txtSize.Text));
                chrSize.Series["TallaPoint"].Points.AddY(float.Parse(txtSize.Text));

                chrIMC.Series["IMC"].Points.AddXY(NumberOfMedicalQuery.ToString(), float.Parse(txtIMC.Text));
                chrIMC.Series["IMCPoint"].Points.AddY(float.Parse(txtIMC.Text));
            }
        }

        private void stiTable_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtFolio.Text.Length == 0 || txtWeight.Text.Length == 0 || txtSize.Text.Length == 0)
                MessageBox.Show("Falta información para generar tabla de comparación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand commandClinicalRecords = new SqlCommand("SELECT date_birth, sex, pacient_weight, pacient_size FROM clinical_records WHERE folio=@folio;", connection);
                SqlCommand commandMedicalQuerys = new SqlCommand("SELECT weight, size FROM medical_querys WHERE folio=@folio;");
                SqlDataReader reader;
                DatesDifference difference;

                dgvPercentilTable.Rows.Clear();

                commandClinicalRecords.Parameters.AddWithValue("@folio", txtFolio.Text);

                commandMedicalQuerys.Parameters.AddWithValue("@folio", txtFolio.Text);

                connection.Open();

                reader = commandClinicalRecords.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        difference = DateDifference(reader.GetDateTime(reader.GetOrdinal("date_birth")), DateTime.Now.Date);

                        string[] data = { txtName.Text, "Recién nacido", reader["pacient_weight"].ToString(), "", reader["pacient_size"].ToString(), "" };
                        dgvPercentilTable.Rows.Add(data);
                    }
                }

                connection.Close();
            }
        }

        private DatesDifference DateDifference(DateTime d1, DateTime d2)
        {
            DatesDifference difference = new DatesDifference();
            int[] monthDay = new int[12] { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            DateTime fromDate;
            DateTime toDate;

            if (d1 > d2)
            {
                fromDate = d2;
                toDate = d1;
            }
            else
            {
                fromDate = d1;
                toDate = d2;
            }

            int increment = 0;

            if (fromDate.Day > toDate.Day)
            {
                increment = monthDay[fromDate.Month - 1];
            }

            if (increment == -1)
            {
                if (DateTime.IsLeapYear(fromDate.Year))
                {
                    increment = 29;
                }
                else
                {
                    increment = 28;
                }
            }

            if (increment != 0)
            {
                difference.Days = (toDate.Day + increment) - fromDate.Day;
                increment = 1;
            }
            else
            {
                difference.Days = toDate.Day - fromDate.Day;
            }

            if ((fromDate.Month + increment) > toDate.Month)
            {
                difference.Months = (toDate.Month + 12) - (fromDate.Month + increment);
                increment = 1;
            }
            else
            {
                difference.Months = (toDate.Month) - (fromDate.Month + increment);
                increment = 0;
            }

            difference.Years = toDate.Year - (fromDate.Year + increment);

            return difference;
        }

        //private float CalculatePercentilWeight(DatesDifference difference, string sex)
        //{
        //    if (sex == "M")
        //    {

        //    }
        //    else
        //    {

        //    }
        //}

        //private float CalculatePercentilSize(DatesDifference difference, string sex)
        //{
        //    if (sex == "M")
        //    {

        //    }
        //    else
        //    {

        //    }
        //}
    }

    public class DatesDifference
    {
        public int Years { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }
    }
}