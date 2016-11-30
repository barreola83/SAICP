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
    public partial class frmClinicalGraphicTracing : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;
        private List<PacientData> pacientsList = new List<PacientData>();

        public frmClinicalGraphicTracing(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
            MaximizeBox = false;
        }

        private void frmClinicalGraphicTracing_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);

            cmbSearchBy.SelectedIndex = 0;

            SetAutoCompleteCustomSourceByFolio();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void frmClinicalGraphicTracing_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SetAutoCompleteCustomSourceByFolio()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT folio, name, first_last_name, second_last_name FROM clinical_records;", connection);
            SqlDataReader reader;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            PacientData pacient;

            pacientsList.Clear();

            connection.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pacient = new PacientData();

                    data.Add(reader["folio"].ToString());

                    pacient.Name = reader["name"].ToString() + " " + reader["first_last_name"].ToString() + " " + reader["second_last_name"].ToString();
                    pacient.Folio = reader["folio"].ToString();

                    pacientsList.Add(pacient);
                }
            }

            connection.Close();

            txtSearchBy.AutoCompleteCustomSource = data;
        }

        private void SetAutoCompleteCustomSourceByName()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT folio, name, first_last_name, second_last_name FROM clinical_records;", connection);
            SqlDataReader reader;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            PacientData pacient;

            pacientsList.Clear();

            connection.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pacient = new PacientData();

                    data.Add(reader["name"].ToString() + " " + reader["first_last_name"].ToString() + " " + reader["second_last_name"].ToString());

                    pacient.Name = reader["name"].ToString() + " " + reader["first_last_name"].ToString() + " " + reader["second_last_name"].ToString();
                    pacient.Folio = reader["folio"].ToString();

                    pacientsList.Add(pacient);
                }
            }

            connection.Close();

            txtSearchBy.AutoCompleteCustomSource = data;
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedIndex == 0)
            {
                SetAutoCompleteCustomSourceByFolio();
                txtSearchBy.MaxLength = 12;
            }
            else
            {
                SetAutoCompleteCustomSourceByName();
                txtSearchBy.MaxLength = 50;
            }

            txtSearchBy.Clear();
        }

        private void txtSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbSearchBy.SelectedIndex == 0)
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                {
                    if (Char.IsLetter(e.KeyChar))
                        e.KeyChar = Char.ToUpper(e.KeyChar);
                }
                else
                    e.Handled = true;
            }
            else
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar))
                {
                    if (txtSearchBy.Text.Length == 0 || txtSearchBy.Text.Substring(txtSearchBy.Text.Length - 1) == " ")
                        e.KeyChar = Char.ToUpper(e.KeyChar);
                }
                else
                    e.Handled = true;
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");

            if (cmbSearchBy.SelectedIndex == 0)
            {
                if (txtSearchBy.AutoCompleteCustomSource.Contains(txtSearchBy.Text))
                {
                    SqlCommand commandClinicalRecords = new SqlCommand("SELECT pacient_weight, pacient_size, pacient_cephalic_perimeter_at_birth FROM clinical_records WHERE folio=@folio", connection);
                    SqlCommand commandMedicalQuerys = new SqlCommand("SELECT weight, size, IMC, cephalic_perimeter FROM medical_querys WHERE folio=@folio", connection);
                    SqlDataReader reader;
                    int MedicalQuerysCounter = 0;

                    chrGraphic.Titles.Clear();
                    chrGraphic.Legends.Clear();
                    chrGraphic.Series.Clear();
                    chrGraphic.ChartAreas.Clear();

                    chrGraphic.Legends.Add("Peso");
                    chrGraphic.Legends.Add("Talla");
                    chrGraphic.Legends.Add("Perímetro cefálico");
                    chrGraphic.Legends.Add("IMC");

                    chrGraphic.Series.Add("Peso");
                    chrGraphic.Series.Add("PesoPoint").IsVisibleInLegend = false;
                    chrGraphic.Series.Add("Talla");
                    chrGraphic.Series.Add("TallaPoint").IsVisibleInLegend = false;
                    chrGraphic.Series.Add("PerimetroCefalico");
                    chrGraphic.Series.Add("PerimetroCefalicoPoint").IsVisibleInLegend = false;
                    chrGraphic.Series.Add("IMC");
                    chrGraphic.Series.Add("IMCPoint").IsVisibleInLegend = false;

                    chrGraphic.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chrGraphic.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chrGraphic.ChartAreas[0].AxisX.IsMarginVisible = false;

                    chrGraphic.ChartAreas[0].AxisX.Title = "Número de consulta";

                    chrGraphic.Series["Peso"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    chrGraphic.Series["PesoPoint"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chrGraphic.Series["Talla"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    chrGraphic.Series["TallaPoint"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chrGraphic.Series["PerimetroCefalico"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    chrGraphic.Series["PerimetroCefalicoPoint"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chrGraphic.Series["IMC"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    chrGraphic.Series["IMCPoint"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                    chrGraphic.Series["PesoPoint"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                    chrGraphic.Series["TallaPoint"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                    chrGraphic.Series["PerimetroCefalicoPoint"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                    chrGraphic.Series["IMCPoint"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;

                    chrGraphic.Series["Peso"].BorderWidth = 2;
                    chrGraphic.Series["Talla"].BorderWidth = 2;
                    chrGraphic.Series["PerimetroCefalico"].BorderWidth = 2;
                    chrGraphic.Series["IMC"].BorderWidth = 2;

                    commandClinicalRecords.Parameters.AddWithValue("@folio", txtSearchBy.Text);
                    commandMedicalQuerys.Parameters.AddWithValue("@folio", txtSearchBy.Text);

                    connection.Open();

                    reader = commandClinicalRecords.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            chrGraphic.Series["Peso"].Points.AddXY("0", float.Parse(reader["pacient_weight"].ToString()));
                            chrGraphic.Series["PesoPoint"].Points.AddY(float.Parse(reader["pacient_weight"].ToString()));
                            chrGraphic.Series["Talla"].Points.AddXY("0", float.Parse(reader["pacient_size"].ToString()));
                            chrGraphic.Series["TallaPoint"].Points.AddY(float.Parse(reader["pacient_size"].ToString()));
                            chrGraphic.Series["PerimetroCefalico"].Points.AddXY("0", float.Parse(reader["pacient_cephalic_perimeter_at_birth"].ToString()));
                            chrGraphic.Series["PerimetroCefalicoPoint"].Points.AddY(float.Parse(reader["pacient_cephalic_perimeter_at_birth"].ToString()));
                            chrGraphic.Series["IMC"].Points.AddXY("0", 0);
                            chrGraphic.Series["IMCPoint"].Points.AddY(0);
                        }
                    }

                    connection.Close();

                    connection.Open();

                    reader = commandMedicalQuerys.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            MedicalQuerysCounter++;

                            chrGraphic.Series["Peso"].Points.AddXY(MedicalQuerysCounter.ToString(), float.Parse(reader["weight"].ToString()));
                            chrGraphic.Series["PesoPoint"].Points.AddY(float.Parse(reader["weight"].ToString()));
                            chrGraphic.Series["Talla"].Points.AddXY(MedicalQuerysCounter.ToString(), float.Parse(reader["size"].ToString()));
                            chrGraphic.Series["TallaPoint"].Points.AddY(float.Parse(reader["size"].ToString()));
                            chrGraphic.Series["PerimetroCefalico"].Points.AddXY(MedicalQuerysCounter.ToString(), float.Parse(reader["cephalic_perimeter"].ToString()));
                            chrGraphic.Series["PerimetroCefalicoPoint"].Points.AddY(float.Parse(reader["cephalic_perimeter"].ToString()));
                            chrGraphic.Series["IMC"].Points.AddXY(MedicalQuerysCounter.ToString(), float.Parse(reader["IMC"].ToString()));
                            chrGraphic.Series["IMCPoint"].Points.AddY(float.Parse(reader["IMC"].ToString()));
                        }
                    }

                    connection.Close();
                }
                else
                    MessageBox.Show("No se encontro el registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtSearchBy.AutoCompleteCustomSource.Contains(txtSearchBy.Text))
                {
                    SqlCommand commandClinicalRecords = new SqlCommand("SELECT pacient_weight, pacient_size, pacient_cephalic_perimeter_at_birth FROM clinical_records WHERE folio=@folio", connection);
                    SqlCommand commandMedicalQuerys = new SqlCommand("SELECT weight, size, IMC, cephalic_perimeter FROM medical_querys WHERE folio=@folio", connection);
                    SqlDataReader reader;
                    int MedicalQuerysCounter = 0;

                    chrGraphic.Titles.Clear();
                    chrGraphic.Legends.Clear();
                    chrGraphic.Series.Clear();
                    chrGraphic.ChartAreas.Clear();

                    chrGraphic.Legends.Add("Peso");
                    chrGraphic.Legends.Add("Talla");
                    chrGraphic.Legends.Add("Perímetro cefálico");
                    chrGraphic.Legends.Add("IMC");

                    chrGraphic.Series.Add("Peso");
                    chrGraphic.Series.Add("PesoPoint").IsVisibleInLegend = false;
                    chrGraphic.Series.Add("Talla");
                    chrGraphic.Series.Add("TallaPoint").IsVisibleInLegend = false;
                    chrGraphic.Series.Add("PerimetroCefalico");
                    chrGraphic.Series.Add("PerimetroCefalicoPoint").IsVisibleInLegend = false;
                    chrGraphic.Series.Add("IMC");
                    chrGraphic.Series.Add("IMCPoint").IsVisibleInLegend = false;

                    chrGraphic.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chrGraphic.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chrGraphic.ChartAreas[0].AxisX.IsMarginVisible = false;

                    chrGraphic.ChartAreas[0].AxisX.Title = "Número de consulta";

                    chrGraphic.Series["Peso"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    chrGraphic.Series["PesoPoint"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chrGraphic.Series["Talla"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    chrGraphic.Series["TallaPoint"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chrGraphic.Series["PerimetroCefalico"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    chrGraphic.Series["PerimetroCefalicoPoint"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chrGraphic.Series["IMC"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    chrGraphic.Series["IMCPoint"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                    chrGraphic.Series["PesoPoint"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                    chrGraphic.Series["TallaPoint"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                    chrGraphic.Series["PerimetroCefalicoPoint"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                    chrGraphic.Series["IMCPoint"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;

                    chrGraphic.Series["Peso"].BorderWidth = 2;
                    chrGraphic.Series["Talla"].BorderWidth = 2;
                    chrGraphic.Series["PerimetroCefalico"].BorderWidth = 2;
                    chrGraphic.Series["IMC"].BorderWidth = 2;

                    commandClinicalRecords.Parameters.AddWithValue("@folio", pacientsList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].Folio);
                    commandMedicalQuerys.Parameters.AddWithValue("@folio", pacientsList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].Folio);

                    connection.Open();

                    reader = commandClinicalRecords.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            chrGraphic.Series["Peso"].Points.AddXY("0", float.Parse(reader["pacient_weight"].ToString()));
                            chrGraphic.Series["PesoPoint"].Points.AddY(float.Parse(reader["pacient_weight"].ToString()));
                            chrGraphic.Series["Talla"].Points.AddXY("0", float.Parse(reader["pacient_size"].ToString()));
                            chrGraphic.Series["TallaPoint"].Points.AddY(float.Parse(reader["pacient_size"].ToString()));
                            chrGraphic.Series["PerimetroCefalico"].Points.AddXY("0", float.Parse(reader["pacient_cephalic_perimeter_at_birth"].ToString()));
                            chrGraphic.Series["PerimetroCefalicoPoint"].Points.AddY(float.Parse(reader["pacient_cephalic_perimeter_at_birth"].ToString()));
                            chrGraphic.Series["IMC"].Points.AddXY("0", 0);
                            chrGraphic.Series["IMCPoint"].Points.AddY(0);
                        }
                    }

                    connection.Close();

                    connection.Open();

                    reader = commandMedicalQuerys.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            MedicalQuerysCounter++;

                            chrGraphic.Series["Peso"].Points.AddXY(MedicalQuerysCounter.ToString(), float.Parse(reader["weight"].ToString()));
                            chrGraphic.Series["PesoPoint"].Points.AddY(float.Parse(reader["weight"].ToString()));
                            chrGraphic.Series["Talla"].Points.AddXY(MedicalQuerysCounter.ToString(), float.Parse(reader["size"].ToString()));
                            chrGraphic.Series["TallaPoint"].Points.AddY(float.Parse(reader["size"].ToString()));
                            chrGraphic.Series["PerimetroCefalico"].Points.AddXY(MedicalQuerysCounter.ToString(), float.Parse(reader["cephalic_perimeter"].ToString()));
                            chrGraphic.Series["PerimetroCefalicoPoint"].Points.AddY(float.Parse(reader["cephalic_perimeter"].ToString()));
                            chrGraphic.Series["IMC"].Points.AddXY(MedicalQuerysCounter.ToString(), float.Parse(reader["IMC"].ToString()));
                            chrGraphic.Series["IMCPoint"].Points.AddY(float.Parse(reader["IMC"].ToString()));
                        }
                    }

                    connection.Close();
                }
                else
                    MessageBox.Show("No se encontro el registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}