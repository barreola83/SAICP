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
    public partial class frmNewClinicalRecord : DevComponents.DotNetBar.Metro.MetroForm
    {
        private Folio folio;
        private string OfficialConsentPath;
        private bool FlagFormClosingBecauseNoOfficialConsent;
        private bool FlagFromClosingAfterSavingData;

        private frmMain windowMenu;

        /*
         * Constructor de la clase frmNewClinicalRecord
         */
        public frmNewClinicalRecord(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
        }

        /*
         * Este método se ejecuta cuando se carga el formulario en memoria
         */
        private void frmNewClinicalRecord_Load(object sender, EventArgs e)
        {
            folio = new Folio();

            folio.Sex = "M";

            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);

            cmbMaternalHemotype.SelectedIndex = 0;
            cmbPaternalHemotype.SelectedIndex = 0;
            cmbPacientBirthForm.SelectedIndex = 0;
            cmbPacientApgarEvaluation.SelectedIndex = 0;

            FlagFormClosingBecauseNoOfficialConsent = false;
            FlagFromClosingAfterSavingData = false;

            clnDateBirth.SelectedDate = DateTime.Today;

            lblFolio.Text = "   Folio: " + folio.GetFolio();
        }

        /*
         * Este método se ejecuta cada 100 milisengundos, en el se actualizan la fecha y hora mostrada.
         */
        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        /*
         * Este método se manda a llamar cuando se ejecute el metodo Close() o se cierre el formulario. En el se pregunta al usuario
         * la confirmacion de dicha operación. En caso de que no desee cerrar el formulario, se cancela la operación.
         */
        private void frmNewClinicalRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FlagFormClosingBecauseNoOfficialConsent && !FlagFromClosingAfterSavingData)
            {
                if (MessageBox.Show("¿Seguro que desea salir? Los datos no guardados se perderán", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    e.Cancel = true;
                else
                {
                    Hide();
                    windowMenu.Show();
                }
            }
            else if (!FlagFromClosingAfterSavingData)
                windowMenu.Show();
        }

        /*
         * Este método mandara a llamar el método Close() para cerrar el formulario.
         */
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         * Este método abrira un cuadro de diálogo para seleccionar la foto del paciente.
         */
        private void cmdSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();

            openImage.Title = "Seleccionar foto del paciente";
            openImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openImage.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg";

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                pctPhoto.Image = Image.FromFile(openImage.FileName);
            }
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox del nombre del paciente
         */
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                // Para generar el folio
                if (txtName.Text.Length == 0)
                {
                    folio.NameFirstLetter = Char.ToString(Char.ToUpper(e.KeyChar));
                    lblFolio.Text = "   Folio: " + folio.GetFolio();
                }

                if (txtName.Text.Length == 0 || txtName.Text.Substring(txtName.Text.Length - 1) == " ")
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                else if (e.KeyChar == (char)Keys.Enter)
                    txtFirstLastName.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox del apellido paterno del paciente
         */
        private void txtFirstLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                // Para generar el folio
                if (txtFirstLastName.Text.Length == 0)
                {
                    folio.FirstLastNameFirstLetter = Char.ToString(Char.ToUpper(e.KeyChar));
                    lblFolio.Text = "   Folio: " + folio.GetFolio();
                }

                if (txtFirstLastName.Text.Length == 0 || txtFirstLastName.Text.Substring(txtFirstLastName.Text.Length - 1) == " ")
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                else if (e.KeyChar == (char)Keys.Enter)
                    txtSecondLastName.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox del apellido materno del paciente
         */
        private void txtSecondLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                // Para generar el folio
                if (txtSecondLastName.Text.Length == 0)
                {
                    folio.SecondLastNameFirstLetter = Char.ToString(Char.ToUpper(e.KeyChar));
                    lblFolio.Text = "   Folio: " + folio.GetFolio();
                }

                if (txtSecondLastName.Text.Length == 0 || txtSecondLastName.Text.Substring(txtSecondLastName.Text.Length - 1) == " ")
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                else if (e.KeyChar == (char)Keys.Enter)
                    txtBirthPlace.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox del lugar de nacimiento
         */
        private void txtBirthPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                if (txtBirthPlace.Text.Length == 0 || txtBirthPlace.Text.Substring(txtBirthPlace.Text.Length - 1) == " ")
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                else if (e.KeyChar == (char)Keys.Enter)
                    txtFatherName.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox del nombre completo del padre o tutor
         */
        private void txtFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (txtFatherName.Text.Length == 0 || txtFatherName.Text.Substring(txtFatherName.Text.Length - 1) == " ")
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                else if (e.KeyChar == (char)Keys.Enter)
                    txtHomeAddress.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox del domicilio
         */
        private void txtHomeAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtHomeAddress.Text.Length == 0 || txtHomeAddress.Text.Substring(txtHomeAddress.Text.Length - 1) == " ")
                e.KeyChar = Char.ToUpper(e.KeyChar);
            else if (e.KeyChar == (char)Keys.Enter)
                txtContactPhone.Focus();
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox del teléfono de contacto
         */
        private void txtContactPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    clnDateBirth.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de la edad de la madre
         */
        private void txtMotherAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txtMotherNumberOfPregnancies.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox del número de embarazos de la madre
         */
        private void txtMotherNumberOfPregnancies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txtMotherNumberOfPrenatalQuerys.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox del número de consultas prenatales de la madre
         */
        private void txtMotherNumberOfPrenatalQuerys_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    cmbMaternalHemotype.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para los riesgos durante el embarazo de la madre
         */
        private void swtMotherHadRisksPregnancy_ValueChanged(object sender, EventArgs e)
        {
            if (swtMotherHadRisksPregnancy.Value)
            {
                txtMotherRisksPregnancy.Enabled = true;
                txtMotherRisksPregnancy.Focus();
            }
            else
            {
                txtMotherRisksPregnancy.Enabled = false;
                txtMotherRisksPregnancy.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para los tratamientos de la madre
         */
        private void swtMotherHadTreatments_ValueChanged(object sender, EventArgs e)
        {
            if (swtMotherHadTreatments.Value)
            {
                txtMotherTreatments.Enabled = true;
                txtMotherTreatments.Focus();
            }
            else
            {
                txtMotherTreatments.Enabled = false;
                txtMotherTreatments.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para las toxicomanías de la madre
         */
        private void swtMotherHadDrugAddictions_ValueChanged(object sender, EventArgs e)
        {
            if (swtMotherHadDrugAddictions.Value)
            {
                txtMotherDrugAddictions.Enabled = true;
                txtMotherDrugAddictions.Focus();
            }
            else
            {
                txtMotherDrugAddictions.Enabled = false;
                txtMotherDrugAddictions.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para las alergias de la madre
         */
        private void swtMotherHadAllergies_ValueChanged(object sender, EventArgs e)
        {
            if (swtMotherHadAllergies.Value)
            {
                txtMotherAllergies.Enabled = true;
                txtMotherAllergies.Focus();
            }
            else
            {
                txtMotherAllergies.Enabled = false;
                txtMotherAllergies.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de la edad gestacional al nacimiento del paciente
         */
        private void txtPacientGestationalAgeAtBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    cmbPacientBirthForm.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox del peso del paciente
         */
        private void txtPacientWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txtPacientSize.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de la talla del paciente
         */
        private void txtPacientSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txtPacientCephalicPerimeterAtBirth.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox del perímetro cefálico del paciente
         */
        private void txtPacientCephalicPerimeterAtBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == (char)Keys.Enter)
                    swtPacientHadBirthComplications.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para las complicaciones al nacimiento del paciente
         */
        private void swtPacientHadBirthComplications_ValueChanged(object sender, EventArgs e)
        {
            if (swtPacientHadBirthComplications.Value)
            {
                txtPacientBirthComplications.Enabled = true;
                txtPacientBirthComplications.Focus();
            }
            else
            {
                txtPacientBirthComplications.Enabled = false;
                txtPacientBirthComplications.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para las detecciones neonatales
         */
        private void swtPacientHadNeonatalDetection_ValueChanged(object sender, EventArgs e)
        {
            if (swtPacientHadNeonatalDetection.Value)
            {
                txtPacientNeonatalDetection.Enabled = true;
                txtPacientNeonatalDetection.Focus();
            }
            else
            {
                txtPacientNeonatalDetection.Enabled = false;
                txtPacientNeonatalDetection.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para las alergias del paciente
         */
        private void swtPacientHadAllergies_ValueChanged(object sender, EventArgs e)
        {
            if (swtPacientHadAllergies.Value)
            {
                txtPacientAllergies.Enabled = true;
                txtPacientAllergies.Focus();
            }
            else
            {
                txtPacientAllergies.Enabled = false;
                txtPacientAllergies.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para ablactación
         */
        private void swtAblactation_ValueChanged(object sender, EventArgs e)
        {
            if (swtAblactation.Value)
            {
                txtAgeAblactationStarts.Enabled = true;
                txtAgeAblactationStarts.Focus();
            }
            else
            {
                txtAgeAblactationStarts.Enabled = false;
                txtAgeAblactationStarts.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de edad de comienzo de la ablactación
         */
        private void txtAgeAblactationStarts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    swtWeaning.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para el destete
         */
        private void swtWeaning_ValueChanged(object sender, EventArgs e)
        {
            if (swtWeaning.Value)
            {
                txtAgeWeaningStarts.Enabled = true;
                txtAgeWeaningStarts.Focus();
            }
            else
            {
                txtAgeWeaningStarts.Enabled = false;
                txtAgeWeaningStarts.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para las enfermedades previas
         */
        private void swtPreviousDiseases_ValueChanged(object sender, EventArgs e)
        {
            if (swtPreviousDiseases.Value)
            {
                txtPreviousDiseases.Enabled = true;
                txtPreviousDiseases.Focus();
            }
            else
            {
                txtPreviousDiseases.Enabled = false;
                txtPreviousDiseases.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para las transfusiones
         */
        private void swtTransfusions_ValueChanged(object sender, EventArgs e)
        {
            if (swtTransfusions.Value)
            {
                txtTransfusionsCauses.Enabled = true;
                txtTransfusionsCauses.Focus();
            }
            else
            {
                txtTransfusionsCauses.Enabled = false;
                txtTransfusionsCauses.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para las transfusiones
         */
        private void swtHospitalizations_ValueChanged(object sender, EventArgs e)
        {
            if (swtHospitalizations.Value)
            {
                txtHospitalizationCauses.Enabled = true;
                txtHospitalizationCauses.Focus();
            }
            else
            {
                txtHospitalizationCauses.Enabled = false;
                txtHospitalizationCauses.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para las cirugías
         */
        private void swtSurgerie_ValueChanged(object sender, EventArgs e)
        {
            if (swtSurgerie.Value)
            {
                txtSurgeriesCauses.Enabled = true;
                txtSurgeriesCauses.Focus();
            }
            else
            {
                txtSurgeriesCauses.Enabled = false;
                txtSurgeriesCauses.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para los traumatismos
         */
        private void swtTrauma_ValueChanged(object sender, EventArgs e)
        {
            if (swtTrauma.Value)
            {
                txtTraumaCauses.Enabled = true;
                txtTraumaCauses.Focus();
            }
            else
            {
                txtTraumaCauses.Enabled = false;
                txtTraumaCauses.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para el tratamiento actual
         */
        private void swtActualTreatment_ValueChanged(object sender, EventArgs e)
        {
            if (swtActualTreatment.Value)
            {
                txtActualTreatment.Enabled = true;
                txtActualTreatment.Focus();
            }
            else
            {
                txtActualTreatment.Enabled = false;
                txtActualTreatment.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para el sostén cefálico
         */
        private void swtCephalicSupport_ValueChanged(object sender, EventArgs e)
        {
            if (swtCephalicSupport.Value)
            {
                txtAgeCephalicSupportStarts.Enabled = true;
                txtAgeCephalicSupportStarts.Focus();
            }
            else
            {
                txtAgeCephalicSupportStarts.Enabled = false;
                txtAgeCephalicSupportStarts.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para la bipedestación
         */
        private void swtBipedestation_ValueChanged(object sender, EventArgs e)
        {
            if (swtBipedestation.Value)
            {
                txtAgeBipedestationStarts.Enabled = true;
                txtAgeBipedestationStarts.Focus();
            }
            else
            {
                txtAgeBipedestationStarts.Enabled = false;
                txtAgeBipedestationStarts.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para el gateo
         */
        private void swtCrawl_ValueChanged(object sender, EventArgs e)
        {
            if (swtCrawl.Value)
            {
                txtAgeCrawlStarts.Enabled = true;
                txtAgeCrawlStarts.Focus();
            }
            else
            {
                txtAgeCrawlStarts.Enabled = false;
                txtAgeCrawlStarts.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para el control de esfinteres
         */
        private void swtSphincterControl_ValueChanged(object sender, EventArgs e)
        {
            if (swtSphincterControl.Value)
            {
                txtAgeSphincterControlStarts.Enabled = true;
                txtAgeSphincterControlStarts.Focus();
            }
            else
            {
                txtAgeSphincterControlStarts.Enabled = false;
                txtAgeSphincterControlStarts.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para la sedestación
         */
        private void swtSedestation_ValueChanged(object sender, EventArgs e)
        {
            if (swtSedestation.Value)
            {
                txtAgeSedestationStarts.Enabled = true;
                txtAgeSedestationStarts.Focus();
            }
            else
            {
                txtAgeSedestationStarts.Enabled = false;
                txtAgeSedestationStarts.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para la deambulación
         */
        private void swtWandering_ValueChanged(object sender, EventArgs e)
        {
            if (swtWandering.Value)
            {
                txtAgeWanderingStarts.Enabled = true;
                txtAgeWanderingStarts.Focus();
            }
            else
            {
                txtAgeWanderingStarts.Enabled = false;
                txtAgeWanderingStarts.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para el desarrollo del lenguaje
         */
        private void swtLanguageDevelopment_ValueChanged(object sender, EventArgs e)
        {
            if (swtLanguageDevelopment.Value)
            {
                txtAgeLanguageDevelopmentStarts.Enabled = true;
                txtAgeLanguageDevelopmentStarts.Focus();
            }
            else
            {
                txtAgeLanguageDevelopmentStarts.Enabled = false;
                txtAgeLanguageDevelopmentStarts.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para la aparición de la dentición
         */
        private void swtDentation_ValueChanged(object sender, EventArgs e)
        {
            if (swtDentation.Value)
            {
                txtAgeDentationStarts.Enabled = true;
                txtAgeDentationStarts.Focus();
            }
            else
            {
                txtAgeDentationStarts.Enabled = false;
                txtAgeDentationStarts.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de edad de comienzo del destete
         */
        private void txtAgeWeaningStarts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    swtPreviousDiseases.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de edad de comienzo del sostén cefálico
         */
        private void txtAgeCephalicSupportStarts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    swtBipedestation.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de edad de comienzo de la bipedestación
         */
        private void txtAgeBipedestationStarts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    swtCrawl.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de edad de comienzo del gateo
         */
        private void txtAgeCrawlStarts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    swtSphincterControl.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de edad de comienzo del control de esfínteres
         */
        private void txtAgeSphincterControlStarts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    swtSedestation.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de edad de comienzo de la sedestación
         */
        private void txtAgeSedestationStarts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    swtWandering.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de edad de comienzo de la deambulación
         */
        private void txtAgeWanderingStarts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    swtLanguageDevelopment.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de edad de comienzo del desarrollo del lenguaje
         */
        private void txtAgeLanguageDevelopmentStarts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    swtDentation.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se presione una tecla sobre el TextBox de edad de comienzo del desarrollo del lenguaje
         */
        private void txtAgeDentationStarts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    swtDevelopmentProblems.Focus();
            }
            else
                e.Handled = true;
        }

        /*
         * Este método se ejecuta cuando se cambie el estado del Switch para problemas en el desarrollo
         */
        private void swtDevelopmentProblems_ValueChanged(object sender, EventArgs e)
        {
            if (swtDevelopmentProblems.Value)
            {
                txtProblemsInDevelopment.Enabled = true;
                txtProblemsInDevelopment.Focus();
            }
            else
            {
                txtProblemsInDevelopment.Enabled = false;
                txtProblemsInDevelopment.Clear();
            }
        }

        /*
         * Este método se ejecuta cuando se seleccione la fecha de nacimiento del paciente
         */
        private void clnDateBirth_DateSelected(object sender, DateRangeEventArgs e)
        {
            folio.Day = (clnDateBirth.SelectedDate.ToString("d")[0].ToString() + clnDateBirth.SelectedDate.ToString("d")[1].ToString());
            folio.Month = (clnDateBirth.SelectedDate.ToString("d")[3].ToString() + clnDateBirth.SelectedDate.ToString("d")[4].ToString());
            folio.Year = (clnDateBirth.SelectedDate.ToString("d")[8].ToString() + clnDateBirth.SelectedDate.ToString("d")[9].ToString());

            lblFolio.Text = "   Folio: " + folio.GetFolio();
        }

        /*
         * Este método se ejecuta cuando se seleccione el RadioButton del sexo masculino
         */
        private void rdbMale_Click(object sender, EventArgs e)
        {
            folio.Sex = "M";

            lblFolio.Text = "   Folio: " + folio.GetFolio();
        }

        /*
         * Este método se ejecuta cuando se seleccione el RadioButton del sexo femenino
         */
        private void rdbFemale_Click(object sender, EventArgs e)
        {
            folio.Sex = "F";

            lblFolio.Text = "   Folio: " + folio.GetFolio();
        }

        /*
         * Este método se ejecuta cuando se de click sobre el botón para guardar
         */
        private void cmdSave_Click(object sender, EventArgs e)
        {
            // Declarar las variables aqui
            string buildInsertCommand = @"INSERT INTO clinical_records VALUES (
            @folio,
            @official_consent,
            @photo,
            @name,
            @first_last_name,
            @second_last_name,
            @birth_place,
            @father_name,
            @home_address,
            @contact_phone,
            @date_birth,
            @sex,
            @family_hereditary_antecedents,
            @mother_age,
            @mother_number_of_pregnancies,
            @mother_number_of_prenatal_querys,
            @maternal_hemotype,
            @paternal_hemotype,
            @mother_risks_pregnancy,
            @mother_treatments,
            @mother_drug_addictions,
            @mother_allergies,
            @pacient_gestational_age_at_birth,
            @pacient_birth_form,
            @pacient_apgar_evaluation,
            @pacient_weight,
            @pacient_size,
            @pacient_cephalic_perimeter_at_birth,
            @pacient_birth_complications,
            @pacient_neonatal_detection,
            @pacient_allergies,
            @vaccine_history,
            @initial_feed,
            @actual_feed,
            @hygine_rutines,
            @age_ablactation_starts,
            @age_weaning_starts,
            @previous_diseases,
            @hospitalization_causes,
            @trauma_causes,
            @transfusions_causes,
            @surgeries_causes,
            @actual_treatment,
            @age_cephalic_support_starts,
            @age_sedestation_starts,
            @age_bipedestation_starts,
            @age_wandering_starts,
            @age_crawl_starts,
            @age_language_development_starts,
            @age_sphincter_control_starts,
            @age_dentation_appears,
            @problems_in_development
            );";

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command = new SqlCommand(buildInsertCommand, connection);

            pgrSaving.Visible = true;

            if (ValidateDataAndAsignSqlCommandParameters(command))
            {

                lblFolio.Text = "   Folio: " + folio.GetFolio();

                // 75%

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                pgrSaving.PerformStep(); // 100%
                pgrSaving.Visible = false;

                MessageBox.Show("Expediente clínico guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FlagFromClosingAfterSavingData = true;

                if (MessageBox.Show("¿Desea registrar otro expediente clínico?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        /*
         * Este método nos permite validar que la informacion de caracter obligatorio en el formulario se encuentre ingresada
         */
        private bool ValidateDataAndAsignSqlCommandParameters(SqlCommand command)
        {
            // Declarar variables aqui
            FileStream file;
            StreamReader fileReader;
            MemoryStream photo;

            // Validacion del documento de consentimiento official
            file = new FileStream(OfficialConsentPath, FileMode.Open);
            fileReader = new StreamReader(file);

            command.Parameters.AddWithValue("@official_consent", fileReader.ReadToEnd());

            fileReader.Close();
            file.Close();

            // Validacion de la foto
            if (pctPhoto.Image == null)
            {
                command.Parameters.Add("@photo", SqlDbType.Image);
                command.Parameters["@photo"].Value = DBNull.Value;
            }
            else
            {
                photo = new MemoryStream();

                command.Parameters.Add("@photo", SqlDbType.Image);
                pctPhoto.Image.Save(photo, System.Drawing.Imaging.ImageFormat.Png);
                command.Parameters["@photo"].Value = photo.GetBuffer();
            }

            // Validacion del nombre
            if (txtName.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@name", txtName.Text);

            // Validación del apellido paterno
            if (txtFirstLastName.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@first_last_name", txtFirstLastName.Text);

            // Validacion del apellido materno
            if (txtSecondLastName.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@second_last_name", txtSecondLastName.Text);

            // Validacion del lugar de nacimiento
            if (txtBirthPlace.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@birth_place", txtBirthPlace.Text);

            // Validacion del nombre del padre o tutor
            if (txtFatherName.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@father_name", txtFatherName.Text);

            // Validacion del domicilio
            if (txtHomeAddress.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@home_address", txtHomeAddress.Text);

            // Validacion del telefono de contacto
            if (txtContactPhone.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@contact_phone", txtContactPhone.Text);

            // Validacion de la fecha de nacimiento
            command.Parameters.AddWithValue("@date_birth", clnDateBirth.SelectedDate);

            // Validacion del sexo
            if (rdbMale.Checked)
                command.Parameters.AddWithValue("@sex", "M");
            else
                command.Parameters.AddWithValue("@sex", "F");

            // Validacion de los antecedentes familiares y hereditarios
            if (txtFamilyHereditaryAntecedents.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@family_hereditary_antecedents", txtFamilyHereditaryAntecedents.Text);

            // Validacion de la edad de la madre
            if (txtMotherAge.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@mother_age", txtMotherAge.Text);

            // Validacion del number de embarazos de la madre
            if (txtMotherNumberOfPregnancies.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@mother_number_of_pregnancies", txtMotherNumberOfPregnancies.Text);

            // Validacion del numero de consultas prenatales
            if (txtMotherNumberOfPrenatalQuerys.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@mother_number_of_prenatal_querys", txtMotherNumberOfPrenatalQuerys.Text);

            // Validacion hemotipo materno
            switch (cmbMaternalHemotype.SelectedIndex)
            {
                case 0:
                    command.Parameters.AddWithValue("@maternal_hemotype", Ominus.Text);
                    break;

                case 1:
                    command.Parameters.AddWithValue("@maternal_hemotype", Oplus.Text);
                    break;

                case 2:
                    command.Parameters.AddWithValue("@maternal_hemotype", Aminus.Text);
                    break;

                case 3:
                    command.Parameters.AddWithValue("@maternal_hemotype", Aplus.Text);
                    break;

                case 4:
                    command.Parameters.AddWithValue("@maternal_hemotype", Bminus.Text);
                    break;

                case 5:
                    command.Parameters.AddWithValue("@maternal_hemotype", Bplus.Text);
                    break;

                case 6:
                    command.Parameters.AddWithValue("@maternal_hemotype", ABminus.Text);
                    break;

                default:
                    command.Parameters.AddWithValue("@maternal_hemotype", ABplus.Text);
                    break;
            }

            // Validacion hemotipo paterno
            switch (cmbPaternalHemotype.SelectedIndex)
            {
                case 0:
                    command.Parameters.AddWithValue("@paternal_hemotype", Ominus.Text);
                    break;

                case 1:
                    command.Parameters.AddWithValue("@paternal_hemotype", Oplus.Text);
                    break;

                case 2:
                    command.Parameters.AddWithValue("@paternal_hemotype", Aminus.Text);
                    break;

                case 3:
                    command.Parameters.AddWithValue("@paternal_hemotype", Aplus.Text);
                    break;

                case 4:
                    command.Parameters.AddWithValue("@paternal_hemotype", Bminus.Text);
                    break;

                case 5:
                    command.Parameters.AddWithValue("@paternal_hemotype", Bplus.Text);
                    break;

                case 6:
                    command.Parameters.AddWithValue("@paternal_hemotype", ABminus.Text);
                    break;

                default:
                    command.Parameters.AddWithValue("@paternal_hemotype", ABplus.Text);
                    break;
            }

            pgrSaving.PerformStep(); //25%

            // Validacion de los riesgos durante el embarazo de la madre
            if (swtMotherHadRisksPregnancy.Value)
            {
                if (txtMotherRisksPregnancy.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@mother_risks_pregnancy", txtMotherRisksPregnancy.Text);
            }
            else
                command.Parameters.AddWithValue("@mother_risks_pregnancy", DBNull.Value);

            // Validacion de los tratamientos de la madre
            if (swtMotherHadTreatments.Value)
            {
                if (txtMotherTreatments.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@mother_treatments", txtMotherTreatments.Text);
            }
            else
                command.Parameters.AddWithValue("@mother_treatments", DBNull.Value);

            // Validacion de las toxicomanias de la madre
            if (swtMotherHadDrugAddictions.Value)
            {
                if (txtMotherDrugAddictions.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@mother_drug_addictions", txtMotherDrugAddictions.Text);
            }
            else
                command.Parameters.AddWithValue("@mother_drug_addictions", DBNull.Value);

            // Validacion de las alergias de la madre
            if (swtMotherHadAllergies.Value)
            {
                if (txtMotherAllergies.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@mother_allergies", txtMotherAllergies.Text);
            }
            else
                command.Parameters.AddWithValue("@mother_allergies", DBNull.Value);

            // Validacion de la edad gestacional al nacimiento del paciente
            if (txtPacientGestationalAgeAtBirth.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@pacient_gestational_age_at_birth", txtPacientGestationalAgeAtBirth.Text);

            // Validacion de la forma de nacimiento
            switch (cmbPacientBirthForm.SelectedIndex)
            {
                case 0:
                    command.Parameters.AddWithValue("@pacient_birth_form", naturalBirth.Text);
                    break;

                case 1:
                    command.Parameters.AddWithValue("@pacient_birth_form", caesareanBirth.Text);
                    break;

                default:
                    command.Parameters.AddWithValue("@pacient_birth_form", onWaterBirth.Text);
                    break;
            }

            // Validacion de la evaluacion de apgar
            switch (cmbPacientApgarEvaluation.SelectedIndex)
            {
                case 0:
                    command.Parameters.AddWithValue("@pacient_apgar_evaluation", cero.Text);
                    break;

                case 1:
                    command.Parameters.AddWithValue("@pacient_apgar_evaluation", one.Text);
                    break;

                case 2:
                    command.Parameters.AddWithValue("@pacient_apgar_evaluation", two.Text);
                    break;

                case 3:
                    command.Parameters.AddWithValue("@pacient_apgar_evaluation", tree.Text);
                    break;

                case 4:
                    command.Parameters.AddWithValue("@pacient_apgar_evaluation", four.Text);
                    break;

                case 5:
                    command.Parameters.AddWithValue("@pacient_apgar_evaluation", five.Text);
                    break;

                case 6:
                    command.Parameters.AddWithValue("@pacient_apgar_evaluation", six.Text);
                    break;

                case 7:
                    command.Parameters.AddWithValue("@pacient_apgar_evaluation", seven.Text);
                    break;

                case 8:
                    command.Parameters.AddWithValue("@pacient_apgar_evaluation", eight.Text);
                    break;

                case 9:
                    command.Parameters.AddWithValue("@pacient_apgar_evaluation", nine.Text);
                    break;

                default:
                    command.Parameters.AddWithValue("@pacient_apgar_evaluation", ten.Text);
                    break;
            }

            // Validacion del peso del paciente
            if (txtPacientWeight.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@pacient_weight", txtPacientWeight.Text);

            // Validacion de la talla del paciente
            if (txtPacientSize.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@pacient_size", txtPacientSize.Text);

            // Validacion del perimetro cefalico al nacimiento del paciente
            if (txtPacientCephalicPerimeterAtBirth.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@pacient_cephalic_perimeter_at_birth", txtPacientCephalicPerimeterAtBirth.Text);

            // Validacion de las complicaciones al nacimiento del paciente
            if (swtPacientHadBirthComplications.Value)
            {
                if (txtPacientBirthComplications.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@pacient_birth_complications", txtPacientBirthComplications.Text);
            }
            else
                command.Parameters.AddWithValue("@pacient_birth_complications", DBNull.Value);

            // Validacion de las detecciones neonatales del paciente
            if (swtPacientHadNeonatalDetection.Value)
            {
                if (txtPacientNeonatalDetection.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@pacient_neonatal_detection", txtPacientNeonatalDetection.Text);
            }
            else
                command.Parameters.AddWithValue("@pacient_neonatal_detection", DBNull.Value);

            // Validacion de las alergias del paciente
            if (swtPacientHadAllergies.Value)
            {
                if (txtPacientAllergies.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@pacient_allergies", txtPacientAllergies.Text);
            }
            else
                command.Parameters.AddWithValue("@pacient_allergies", DBNull.Value);

            // Validacion del historial de vacunas
            if (txtVaccineHistory.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@vaccine_history", txtVaccineHistory.Text);

            // Validacion de la alimentacion inicial
            if (txtInitialFeed.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@initial_feed", txtInitialFeed.Text);

            // Validacion de la alimentacion actual
            if (txtActualFeed.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@actual_feed", txtActualFeed.Text);

            // Validacion de las rutinas de higiene
            if (txtHygineRutines.Text.Length == 0)
                return false;
            else
                command.Parameters.AddWithValue("@hygine_rutines", txtHygineRutines.Text);

            pgrSaving.PerformStep(); //50%

            // Validacion de la edad de comienzo de la ablactacion
            if (swtAblactation.Value)
            {
                if (txtAgeAblactationStarts.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@age_ablactation_starts", txtAgeAblactationStarts.Text);
            }
            else
                command.Parameters.AddWithValue("@age_ablactation_starts", DBNull.Value);

            // Validacion de la edad de comienzo del destete
            if (swtWeaning.Value)
            {
                if (txtAgeWeaningStarts.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@age_weaning_starts", txtAgeWeaningStarts.Text);
            }
            else
                command.Parameters.AddWithValue("@age_weaning_starts", DBNull.Value);

            // Validacion de las enfermedades previas
            if (swtPreviousDiseases.Value)
            {
                if (txtPreviousDiseases.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@previous_diseases", txtPreviousDiseases.Text);
            }
            else
                command.Parameters.AddWithValue("@previous_diseases", DBNull.Value);

            // Validacion de las hospitalizaciones
            if (swtHospitalizations.Value)
            {
                if (txtHospitalizationCauses.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@hospitalization_causes", txtHospitalizationCauses.Text);
            }
            else
                command.Parameters.AddWithValue("@hospitalization_causes", DBNull.Value);

            // Validacion de los traumatismos
            if (swtTrauma.Value)
            {
                if (txtTraumaCauses.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@trauma_causes", txtTraumaCauses.Text);
            }
            else
                command.Parameters.AddWithValue("@trauma_causes", DBNull.Value);

            // Validacion de las transfusiones
            if (swtTransfusions.Value)
            {
                if (txtTransfusionsCauses.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@transfusions_causes", txtTransfusionsCauses.Text);
            }
            else
                command.Parameters.AddWithValue("@transfusions_causes", DBNull.Value);

            // Validacion de las cirugías
            if (swtSurgerie.Value)
            {
                if (txtSurgeriesCauses.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@surgeries_causes", txtSurgeriesCauses.Text);
            }
            else
                command.Parameters.AddWithValue("@surgeries_causes", DBNull.Value);

            // Validacion del tratamiento actual
            if (swtActualTreatment.Value)
            {
                if (txtActualTreatment.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@actual_treatment", txtActualTreatment.Text);
            }
            else
                command.Parameters.AddWithValue("@actual_treatment", DBNull.Value);

            // Validacion del sosten cefalico
            if (swtCephalicSupport.Value)
            {
                if (txtAgeCephalicSupportStarts.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@age_cephalic_support_starts", txtAgeCephalicSupportStarts.Text);
            }
            else
                command.Parameters.AddWithValue("@age_cephalic_support_starts", DBNull.Value);

            // Validacion de la sedestacion
            if (swtSedestation.Value)
            {
                if (txtAgeSedestationStarts.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@age_sedestation_starts", txtAgeSedestationStarts.Text);
            }
            else
                command.Parameters.AddWithValue("@age_sedestation_starts", DBNull.Value);

            // Validacion de la bipedestacion
            if (swtBipedestation.Value)
            {
                if (txtAgeBipedestationStarts.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@age_bipedestation_starts", txtAgeBipedestationStarts.Text);
            }
            else
                command.Parameters.AddWithValue("@age_bipedestation_starts", DBNull.Value);

            // Validacion de la deambulacion
            if (swtWandering.Value)
            {
                if (txtAgeWanderingStarts.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@age_wandering_starts", txtAgeWanderingStarts.Text);
            }
            else
                command.Parameters.AddWithValue("@age_wandering_starts", DBNull.Value);

            // Validacion del gateo
            if (swtCrawl.Value)
            {
                if (txtAgeCrawlStarts.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@age_crawl_starts", txtAgeCrawlStarts.Text);
            }
            else
                command.Parameters.AddWithValue("@age_crawl_starts", DBNull.Value);

            // Validacion del desarrollo del lenguaje
            if (swtLanguageDevelopment.Value)
            {
                if (txtAgeLanguageDevelopmentStarts.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@age_language_development_starts", txtAgeLanguageDevelopmentStarts.Text);
            }
            else
                command.Parameters.AddWithValue("@age_language_development_starts", DBNull.Value);

            // Validacion del control de esfinteres
            if (swtSphincterControl.Value)
            {
                if (txtAgeSphincterControlStarts.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@age_sphincter_control_starts", txtAgeSphincterControlStarts.Text);
            }
            else
                command.Parameters.AddWithValue("@age_sphincter_control_starts", DBNull.Value);

            // Validacion de la aparicion de la denticion
            if (swtDentation.Value)
            {
                if (txtAgeDentationStarts.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@age_dentation_appears", txtAgeDentationStarts.Text);
            }
            else
                command.Parameters.AddWithValue("@age_dentation_appears", DBNull.Value);

            // Validacion de los problemas en el desarrollo
            if (swtDevelopmentProblems.Value)
            {
                if (txtProblemsInDevelopment.Text.Length == 0)
                    return false;
                else
                    command.Parameters.AddWithValue("@problems_in_development", txtProblemsInDevelopment.Text);
            }
            else
                command.Parameters.AddWithValue("@problems_in_development", DBNull.Value);

            // Validacion del folio

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand selectCommand = new SqlCommand("SELECT Folio FROM clinical_records WHERE Folio=@folio", connection);
            SqlDataReader reader;

            selectCommand.Parameters.AddWithValue("@folio", folio.GetFolio());

            while (true)
            {
                connection.Open();

                reader = selectCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    connection.Close();

                    folio.ChangeLastTwoNumbers();

                    selectCommand.Parameters["@folio"].Value = folio.GetFolio();
                }
                else
                {
                    connection.Close();
                    break;
                }
            }

            command.Parameters.AddWithValue("@folio", folio.GetFolio());

            pgrSaving.PerformStep(); // 75%

            return true;
        }

        /* 
         * Este método se ejecuta cuando se muestre la ventana por primera vez
         */
        private void frmNewClinicalRecord_Shown(object sender, EventArgs e)
        {
            if (!FlagFormClosingBecauseNoOfficialConsent)
            {
                OpenFileDialog openOfficialConsent = new OpenFileDialog();

                openOfficialConsent.Title = "Seleccionar documento de consentimiento oficial";
                openOfficialConsent.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openOfficialConsent.Filter = "Archivos de texto (*.txt)|*.txt";

                if (openOfficialConsent.ShowDialog() == DialogResult.OK)
                    OfficialConsentPath = openOfficialConsent.FileName;
                else
                {
                    FlagFormClosingBecauseNoOfficialConsent = true;
                    Close();
                }
            }
        }
    }

    public class Folio
    {
        public string NameFirstLetter { get; set; }
        public string FirstLastNameFirstLetter { get; set; }
        public string SecondLastNameFirstLetter { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Sex { get; set; }
        public string FirstRandonNumber { get; set; }
        public string SecondRandomNumber { get; set; }

        public Folio()
        {
            Random randomNumber = new Random();

            NameFirstLetter = "-";
            FirstLastNameFirstLetter = "-";
            SecondLastNameFirstLetter = "-";
            Day = "-";
            Month = "-";
            Year = "-";
            Sex = "-";

            FirstRandonNumber = randomNumber.Next(0, 10).ToString();
            SecondRandomNumber = randomNumber.Next(0, 10).ToString();
        }

        public string GetFolio()
        {
            return (NameFirstLetter + FirstLastNameFirstLetter + SecondLastNameFirstLetter + Day + Month + Year + Sex + FirstRandonNumber + SecondRandomNumber);
        }

        public void ChangeLastTwoNumbers()
        {
            Random randomNumber = new Random();

            FirstRandonNumber = randomNumber.Next(0, 10).ToString();
            SecondRandomNumber = randomNumber.Next(0, 10).ToString();
        }
    }
}