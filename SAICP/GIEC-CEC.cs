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
    public partial class frmQueryClinicalRecords : DevComponents.DotNetBar.Metro.MetroForm
    {
        private enum State
        {
            Search = 0,
            Modify = 1
        };

        private State formState;
        private Folio folio;
        private frmMain windowMenu;
        private List<SearchByFolio> foliosList;
        private List<SearchByName> namesList;
        private int selectedID;

        /*
         * Constructor de la clase frmNewClinicalRecord
         */
        public frmQueryClinicalRecords(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
        }

        /*
         * Este método se ejecuta cuando se carga el formulario en memoria
         */
        private void frmQueryClinicalRecords_Load(object sender, EventArgs e)
        {
            folio = new Folio();
            foliosList = new List<SearchByFolio>();
            namesList = new List<SearchByName>();

            formState = State.Search;

            folio.Sex = "M";

            lblDate.Text = DateTime.Today.ToString("d");
            lblHour.Text = DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);

            cmbSearchBy.SelectedIndex = 0;
            cmbMaternalHemotype.SelectedIndex = 0;
            cmbPaternalHemotype.SelectedIndex = 0;
            cmbPacientBirthForm.SelectedIndex = 0;
            cmbPacientApgarEvaluation.SelectedIndex = 0;

            lblFolio.Text = "   Folio: ";

            txtSearchBy.Focus();

            SetAutoCompleteCustomSourceByFolio();
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
        private void frmQueryClinicalRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formState == State.Search)
            {
                if (MessageBox.Show("¿Seguro que desea regresar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    e.Cancel = true;
                else
                    windowMenu.Show();
            }
            else if (formState == State.Modify)
            {
                if (MessageBox.Show("¿Seguro que desea salir? Los datos no guardados se perderán", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    e.Cancel = true;
                else
                    windowMenu.Show();
            }
        }

        /*
         * Este método mandara a llamar el método Close() para cerrar el formulario.
         */
        private void cmdReturnCancel_Click(object sender, EventArgs e)
        {
            if (formState == State.Modify)
            {
                if (MessageBox.Show("¿Seguro que desea cancelar? Los datos no guardados se perderán", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Search();

                    EnableComponents(false);

                    cmbSearchBy.Enabled = true;
                    cmdSearch.Enabled = true;

                    cmdModifySave.Text = "Modificar";

                    cmdReturnCancel.Text = "Regresar";

                    cmbSearchBy.Enabled = true;
                    txtSearchBy.Enabled = true;
                    cmdSearch.Enabled = true;

                    formState = State.Search;
                }
            }
            else
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
        private void cmdModifySave_Click(object sender, EventArgs e)
        {
            if (formState == State.Search)
            {
                formState = State.Modify;

                EnableComponents(true);

                cmbSearchBy.Enabled = false;

                txtSearchBy.Enabled = false;

                cmdSearch.Enabled = false;
                cmdModifySave.Text = "Guardar";
                cmdReturnCancel.Text = "Cancelar";
            }
            else
            {
                // Declarar las variables aqui
                string buildUpdateCommandForClinicalRecords = @"UPDATE clinical_records SET
                folio=@folio,
                photo=@photo,
                name=@name,
                first_last_name=@first_last_name,
                second_last_name=@second_last_name,
                birth_place=@birth_place,
                father_name=@father_name,
                home_address=@home_address,
                contact_phone=@contact_phone,
                date_birth=@date_birth,
                sex=@sex,
                family_hereditary_antecedents=@family_hereditary_antecedents,
                mother_age=@mother_age,
                mother_number_of_pregnancies=@mother_number_of_pregnancies,
                mother_number_of_prenatal_querys=@mother_number_of_prenatal_querys,
                maternal_hemotype=@maternal_hemotype,
                paternal_hemotype=@paternal_hemotype,
                mother_risks_pregnancy=@mother_risks_pregnancy,
                mother_treatments=@mother_treatments,
                mother_drug_addictions=@mother_drug_addictions,
                mother_allergies=@mother_allergies,
                pacient_gestational_age_at_birth=@pacient_gestational_age_at_birth,
                pacient_birth_form=@pacient_birth_form,
                pacient_apgar_evaluation=@pacient_apgar_evaluation,
                pacient_weight=@pacient_weight,
                pacient_size=@pacient_size,
                pacient_cephalic_perimeter_at_birth=@pacient_cephalic_perimeter_at_birth,
                pacient_birth_complications=@pacient_birth_complications,
                pacient_neonatal_detection=@pacient_neonatal_detection,
                pacient_allergies=@pacient_allergies,
                vaccine_history=@vaccine_history,
                initial_feed=@initial_feed,
                actual_feed=@actual_feed,
                hygine_rutines=@hygine_rutines,
                age_ablactation_starts=@age_ablactation_starts,
                age_weaning_starts=@age_weaning_starts,
                previous_diseases=@previous_diseases,
                hospitalization_causes=@hospitalization_causes,
                trauma_causes=@trauma_causes,
                transfusions_causes=@transfusions_causes,
                surgeries_causes=@surgeries_causes,
                actual_treatment=@actual_treatment,
                age_cephalic_support_starts=@age_cephalic_support_starts,
                age_sedestation_starts=@age_sedestation_starts,
                age_bipedestation_starts=@age_bipedestation_starts,
                age_wandering_starts=@age_wandering_starts,
                age_crawl_starts=@age_crawl_starts,
                age_language_development_starts=@age_language_development_starts,
                age_sphincter_control_starts=@age_sphincter_control_starts,
                age_dentation_appears=@age_dentation_appears,
                problems_in_development=@problems_in_development
                WHERE ID=@ID;";

                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand command = new SqlCommand(buildUpdateCommandForClinicalRecords, connection);

                if (MessageBox.Show("¿Seguro que desea guardar los cambios?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

                formState = State.Search;

                pgrSaving.Visible = true;

                if (ValidateDataAndAsignSqlCommandParameters(command))
                {
                    lblFolio.Text = "   Folio: " + folio.GetFolio();

                    // 75%

                    connection.Open();

                    command.ExecuteNonQuery();

                    // Actualizar registros en la tabla de medical_querys
                    UpdateMedicalQuerys(connection);

                    // Actualizar registros en la tabla de agenda
                    UpdateAgenda(connection);

                    connection.Close();

                    pgrSaving.PerformStep(); // 100%
                    pgrSaving.Visible = false;

                    MessageBox.Show("Expediente clínico guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EnableComponents(false);

                    cmdModifySave.Text = "Modificar";

                    cmdReturnCancel.Text = "Regresar";

                    cmbSearchBy.Enabled = true;

                    txtSearchBy.Enabled = true;

                    cmdSearch.Enabled = true;
                }
                else
                    MessageBox.Show("Faltan campos obligatorios por llenar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*
         * Este método nos permite validar que la informacion de caracter obligatorio en el formulario se encuentre ingresada
         */
        private bool ValidateDataAndAsignSqlCommandParameters(SqlCommand command)
        {
            // Declarar variables aqui
            MemoryStream photo;

            if (foliosList.Count != 0)
                command.Parameters.AddWithValue("@ID", foliosList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].ID);
            else if (namesList.Count != 0) // --pendiente de revisar
                command.Parameters.AddWithValue("@ID", namesList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].ID);

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
            if ((foliosList.Count != 0 && folio.GetFolio() != foliosList[selectedID].folio) || (namesList.Count != 0 && folio.GetFolio() != namesList[selectedID].folio))
            {
                SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
                SqlCommand selectCommand = new SqlCommand("SELECT ID FROM clinical_records WHERE folio=@folio", connection);
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
            }

            command.Parameters.AddWithValue("@folio", folio.GetFolio());

            pgrSaving.PerformStep(); // 75%

            return true;
        }

        /*
         * Este método se ejecutara cuando se cambie el campo por el que se desea buscar
         */
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
                txtSearchBy.MaxLength = 100;
            }

            txtSearchBy.Clear();
        }

        /*
         * Este metodo se debe mandar a llamar cuando se desee que el autocompletado sea para la opcion de folio
         */
        private void SetAutoCompleteCustomSourceByFolio()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand commnad = new SqlCommand("SELECT ID, folio FROM clinical_records;", connection);
            SqlDataReader reader;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            SearchByFolio folioData;

            foliosList = new List<SearchByFolio>();

            connection.Open();

            reader = commnad.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    folioData = new SearchByFolio();

                    data.Add(reader["folio"].ToString());

                    folioData.ID = int.Parse(reader["ID"].ToString());
                    folioData.folio = reader["folio"].ToString();

                    foliosList.Add(folioData);
                }
            }

            connection.Close();

            txtSearchBy.AutoCompleteCustomSource = data;

            if (namesList != null)
                namesList.Clear();
        }

        /*
         * Este metodo se debe mandar a llamar cuando se desee que el autocompletado sea por nombre
         */
        private void SetAutoCompleteCustomSourceByName()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand commnad = new SqlCommand("SELECT ID, folio, name, first_last_name, second_last_name FROM clinical_records;", connection);
            SqlDataReader reader;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            SearchByName nameData;

            namesList = new List<SearchByName>();

            connection.Open();

            reader = commnad.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    nameData = new SearchByName();

                    data.Add(reader["name"].ToString() + " " + reader["first_last_name"].ToString() + " " + reader["second_last_name"].ToString());

                    nameData.ID = int.Parse(reader["ID"].ToString());
                    nameData.folio = reader["folio"].ToString();
                    nameData.Name = reader["name"].ToString();
                    nameData.FirstLastName = reader["first_last_name"].ToString();
                    nameData.SecondLastName = reader["second_last_name"].ToString();

                    namesList.Add(nameData);
                }
            }

            connection.Close();

            txtSearchBy.AutoCompleteCustomSource = data;

            if (foliosList != null)
                foliosList.Clear();
        }

        /*
         * Este metodo se ejecutara cuando se presione una tecla en el TextBox para ingresar el folio o el nombre
         */
        private void txtSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbSearchBy.SelectedIndex == 0)
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
                else
                {
                    if (Char.IsLetter(e.KeyChar))
                        e.KeyChar = Char.ToUpper(e.KeyChar);
                    else if (e.KeyChar == (char)Keys.Enter)
                        cmdSearch.PerformClick();
                }
            }
            else if (cmbSearchBy.SelectedIndex == 1)
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
                {
                    if (txtSearchBy.Text.Length == 0 || txtSearchBy.Text.Substring(txtSearchBy.Text.Length - 1) == " ")
                        e.KeyChar = Char.ToUpper(e.KeyChar);
                    else if (e.KeyChar == (char)Keys.Enter)
                        cmdSearch.PerformClick();
                }
                else
                    e.Handled = true;
            }
        }

        /*
         * Este metodo se ejecutara cuando se realize clic sobre el boton de buscar
         */
        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        /*
         * Este metodo nos permite desplegar la informacion en el formulario
         */
        private void DisplayData(SqlDataReader reader)
        {
            // Variables
            MemoryStream photo;

            // Mostramos el folio
            lblFolio.Text = "   Folio: " + reader["folio"].ToString();

            // Guardamos el folio internamente
            folio.NameFirstLetter = reader["folio"].ToString()[0].ToString();
            folio.FirstLastNameFirstLetter = reader["folio"].ToString()[1].ToString();
            folio.SecondLastNameFirstLetter = reader["folio"].ToString()[2].ToString();
            folio.Day = reader["folio"].ToString()[3].ToString() + reader["folio"].ToString()[4].ToString();
            folio.Month = reader["folio"].ToString()[5].ToString() + reader["folio"].ToString()[6].ToString();
            folio.Year = reader["folio"].ToString()[7].ToString() + reader["folio"].ToString()[8].ToString();
            folio.Sex = reader["folio"].ToString()[9].ToString();
            folio.FirstRandonNumber = reader["folio"].ToString()[10].ToString();
            folio.SecondRandomNumber = reader["folio"].ToString()[11].ToString();

            // Mostramos la foto si es que hay --pendiente
            if (!reader.IsDBNull(reader.GetOrdinal("photo")))
            {
                photo = new MemoryStream((byte[])reader["photo"]);
                pctPhoto.Image = Image.FromStream(photo);
            }
            else
                pctPhoto.Image = null;

            // Mostramos el nombre
            txtName.Text = reader["name"].ToString();

            // Mostramos el apellid paterno
            txtFirstLastName.Text = reader["first_last_name"].ToString();

            // Mostramos el apellido materno
            txtSecondLastName.Text = reader["second_last_name"].ToString();

            // Mostramos el lugar de nacimiento
            txtBirthPlace.Text = reader["birth_place"].ToString();

            // Mostramos el nombre del padre o tutor
            txtFatherName.Text = reader["father_name"].ToString();

            // Mostramos el domicilio
            txtHomeAddress.Text = reader["home_address"].ToString();

            // Mostramos el numero de telefono de contacto
            txtContactPhone.Text = reader["contact_phone"].ToString();

            // Mostramos la fecha de nacimiento
            clnDateBirth.SelectedDate = reader.GetDateTime(reader.GetOrdinal("date_birth"));

            // Mostramos el sexo
            if (reader["sex"].ToString() == "M")
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;

            // Mostramos los antecedentes familiares y hereditarios
            txtFamilyHereditaryAntecedents.Text = reader["family_hereditary_antecedents"].ToString();

            // Mostramos la edad de la madre
            txtMotherAge.Text = reader["mother_age"].ToString();

            // Mostramos el número de embarazos
            txtMotherNumberOfPregnancies.Text = reader["mother_number_of_pregnancies"].ToString();

            // Mostramos el número de consultas prenatales
            txtMotherNumberOfPrenatalQuerys.Text = reader["mother_number_of_prenatal_querys"].ToString();

            // Mostramos el hemotipo materno
            switch (reader["maternal_hemotype"].ToString())
            {
                case "O-":
                    cmbMaternalHemotype.SelectedIndex = 0;
                    break;

                case "O+":
                    cmbMaternalHemotype.SelectedIndex = 1;
                    break;

                case "A-":
                    cmbMaternalHemotype.SelectedIndex = 2;
                    break;

                case "A+":
                    cmbMaternalHemotype.SelectedIndex = 3;
                    break;

                case "B-":
                    cmbMaternalHemotype.SelectedIndex = 4;
                    break;

                case "B+":
                    cmbMaternalHemotype.SelectedIndex = 5;
                    break;

                case "AB-":
                    cmbMaternalHemotype.SelectedIndex = 6;
                    break;

                default:
                    cmbMaternalHemotype.SelectedIndex = 7;
                    break;
            }

            // Mostramos el hemotipo paterno
            switch (reader["paternal_hemotype"].ToString())
            {
                case "O-":
                    cmbPaternalHemotype.SelectedIndex = 0;
                    break;

                case "O+":
                    cmbPaternalHemotype.SelectedIndex = 1;
                    break;

                case "A-":
                    cmbPaternalHemotype.SelectedIndex = 2;
                    break;

                case "A+":
                    cmbPaternalHemotype.SelectedIndex = 3;
                    break;

                case "B-":
                    cmbPaternalHemotype.SelectedIndex = 4;
                    break;

                case "B+":
                    cmbPaternalHemotype.SelectedIndex = 5;
                    break;

                case "AB-":
                    cmbPaternalHemotype.SelectedIndex = 6;
                    break;

                default:
                    cmbPaternalHemotype.SelectedIndex = 7;
                    break;
            }

            // Mostramos los riesgos durante el embarazo de la madre
            if (!reader.IsDBNull(reader.GetOrdinal("mother_risks_pregnancy")))
            {
                swtMotherHadRisksPregnancy.Value = true;
                txtMotherRisksPregnancy.Text = reader["mother_risks_pregnancy"].ToString();
                txtMotherRisksPregnancy.Enabled = false;
            }

            // Mostramos los tratamientos de la madre
            if (!reader.IsDBNull(reader.GetOrdinal("mother_treatments")))
            {
                swtMotherHadTreatments.Value = true;
                txtMotherTreatments.Text = reader["mother_treatments"].ToString();
                txtMotherTreatments.Enabled = false;
            }

            // Mostramos las toxicomanías de la madre
            if (!reader.IsDBNull(reader.GetOrdinal("mother_drug_addictions")))
            {
                swtMotherHadDrugAddictions.Value = true;
                txtMotherDrugAddictions.Text = reader["mother_drug_addictions"].ToString();
                txtMotherDrugAddictions.Enabled = false;
            }

            // Mostramos las alergias de la madre
            if (!reader.IsDBNull(reader.GetOrdinal("mother_allergies")))
            {
                swtMotherHadAllergies.Value = true;
                txtMotherAllergies.Text = reader["mother_allergies"].ToString();
                txtMotherAllergies.Enabled = false;
            }

            // Mostramos la edad gestacional al nacimiento del paciente
            txtPacientGestationalAgeAtBirth.Text = reader["pacient_gestational_age_at_birth"].ToString();

            // Mostramos la forma de nacimiento
            switch (reader["pacient_birth_form"].ToString())
            {
                case "Parto natural":
                    cmbPacientBirthForm.SelectedIndex = 0;
                    break;

                case "Cesárea":
                    cmbPacientBirthForm.SelectedIndex = 1;
                    break;

                default:
                    cmbPacientBirthForm.SelectedIndex = 2;
                    break;
            }

            // Mostramos la evaluacion de apgar del paciente
            switch (reader["pacient_apgar_evaluation"].ToString())
            {
                case "0":
                    cmbPacientApgarEvaluation.SelectedIndex = 0;
                    break;

                case "1":
                    cmbPacientApgarEvaluation.SelectedIndex = 1;
                    break;

                case "2":
                    cmbPacientApgarEvaluation.SelectedIndex = 2;
                    break;

                case "3":
                    cmbPacientApgarEvaluation.SelectedIndex = 3;
                    break;

                case "4":
                    cmbPacientApgarEvaluation.SelectedIndex = 4;
                    break;

                case "5":
                    cmbPacientApgarEvaluation.SelectedIndex = 5;
                    break;

                case "6":
                    cmbPacientApgarEvaluation.SelectedIndex = 6;
                    break;

                case "7":
                    cmbPacientApgarEvaluation.SelectedIndex = 7;
                    break;

                case "8":
                    cmbPacientApgarEvaluation.SelectedIndex = 8;
                    break;

                case "9":
                    cmbPacientApgarEvaluation.SelectedIndex = 9;
                    break;

                case "10":
                    cmbPacientApgarEvaluation.SelectedIndex = 10;
                    break;
            }

            // Mostramos el peso del paciente
            txtPacientWeight.Text = reader["pacient_weight"].ToString();

            // Mostramos la talla del paciente
            txtPacientSize.Text = reader["pacient_size"].ToString();

            // Mostramos el perimetro cefalico al nacimiento del paciente
            txtPacientCephalicPerimeterAtBirth.Text = reader["pacient_cephalic_perimeter_at_birth"].ToString();

            // Mostramos las complicaciones al nacimiento del pacient
            if (!reader.IsDBNull(reader.GetOrdinal("pacient_birth_complications")))
            {
                swtPacientHadBirthComplications.Value = true;
                txtPacientBirthComplications.Text = reader["pacient_birth_complications"].ToString();
                txtPacientBirthComplications.Enabled = false;
            }

            // Mostramos las detecciones neonatales del paciente
            if (!reader.IsDBNull(reader.GetOrdinal("pacient_neonatal_detection")))
            {
                swtPacientHadNeonatalDetection.Value = true;
                txtPacientNeonatalDetection.Text = reader["pacient_neonatal_detection"].ToString();
                txtPacientNeonatalDetection.Enabled = false;
            }

            // Mostramos las alergias del paciente
            if (!reader.IsDBNull(reader.GetOrdinal("pacient_allergies")))
            {
                swtPacientHadAllergies.Value = true;
                txtPacientAllergies.Text = reader["pacient_allergies"].ToString();
                txtPacientAllergies.Enabled = false;
            }

            // Historial de vacunas
            txtVaccineHistory.Text = reader["vaccine_history"].ToString();

            // Alimentacion inicial
            txtInitialFeed.Text = reader["initial_feed"].ToString();

            // Alimentacion actual
            txtActualFeed.Text = reader["actual_feed"].ToString();

            // Rutinas de higiene
            txtHygineRutines.Text = reader["hygine_rutines"].ToString();

            // Ablactacion
            if (!reader.IsDBNull(reader.GetOrdinal("age_ablactation_starts")))
            {
                swtAblactation.Value = true;
                txtAgeAblactationStarts.Text = reader["age_ablactation_starts"].ToString();
                txtAgeAblactationStarts.Enabled = false;
            }

            // Destete
            if (!reader.IsDBNull(reader.GetOrdinal("age_weaning_starts")))
            {
                swtWeaning.Value = true;
                txtAgeWeaningStarts.Text = reader["age_weaning_starts"].ToString();
                txtAgeWeaningStarts.Enabled = false;
            }

            // Enfermedades previas
            if (!reader.IsDBNull(reader.GetOrdinal("previous_diseases")))
            {
                swtPreviousDiseases.Value = true;
                txtPreviousDiseases.Text = reader["previous_diseases"].ToString();
                txtPreviousDiseases.Enabled = false;
            }

            // Hospitalizaciones
            if (!reader.IsDBNull(reader.GetOrdinal("hospitalization_causes")))
            {
                swtHospitalizations.Value = true;
                txtHospitalizationCauses.Text = reader["hospitalization_causes"].ToString();
                txtHospitalizationCauses.Enabled = false;
            }

            // Traumas
            if (!reader.IsDBNull(reader.GetOrdinal("trauma_causes")))
            {
                swtTrauma.Value = true;
                txtTraumaCauses.Text = reader["trauma_causes"].ToString();
                txtTraumaCauses.Enabled = false;
            }

            // Transfusiones
            if (!reader.IsDBNull(reader.GetOrdinal("transfusions_causes")))
            {
                swtTransfusions.Value = true;
                txtTransfusionsCauses.Text = reader["transfusions_causes"].ToString();
                txtTransfusionsCauses.Enabled = false;
            }

            // Cirugias
            if (!reader.IsDBNull(reader.GetOrdinal("surgeries_causes")))
            {
                swtSurgerie.Value = true;
                txtSurgeriesCauses.Text = reader["surgeries_causes"].ToString();
                txtSurgeriesCauses.Enabled = false;
            }

            // Tratamiento actual
            if (!reader.IsDBNull(reader.GetOrdinal("actual_treatment")))
            {
                swtActualTreatment.Value = true;
                txtActualTreatment.Text = reader["actual_treatment"].ToString();
                txtActualTreatment.Enabled = false;
            }

            // Tratamiento actual
            if (!reader.IsDBNull(reader.GetOrdinal("actual_treatment")))
            {
                swtActualTreatment.Value = true;
                txtActualTreatment.Text = reader["actual_treatment"].ToString();
                txtActualTreatment.Enabled = false;
            }

            // Sosten cefalico
            if (!reader.IsDBNull(reader.GetOrdinal("age_cephalic_support_starts")))
            {
                swtCephalicSupport.Value = true;
                txtAgeCephalicSupportStarts.Text = reader["age_cephalic_support_starts"].ToString();
                txtAgeCephalicSupportStarts.Enabled = false;
            }

            // Sedestacion
            if (!reader.IsDBNull(reader.GetOrdinal("age_sedestation_starts")))
            {
                swtSedestation.Value = true;
                txtAgeSedestationStarts.Text = reader["age_sedestation_starts"].ToString();
                txtAgeSedestationStarts.Enabled = false;
            }

            // Bipedestacion
            if (!reader.IsDBNull(reader.GetOrdinal("age_bipedestation_starts")))
            {
                swtBipedestation.Value = true;
                txtAgeBipedestationStarts.Text = reader["age_bipedestation_starts"].ToString();
                txtAgeBipedestationStarts.Enabled = false;
            }

            // Deambulacion
            if (!reader.IsDBNull(reader.GetOrdinal("age_wandering_starts")))
            {
                swtWandering.Value = true;
                txtAgeWanderingStarts.Text = reader["age_wandering_starts"].ToString();
                txtAgeWanderingStarts.Enabled = false;
            }

            // Gateo
            if (!reader.IsDBNull(reader.GetOrdinal("age_crawl_starts")))
            {
                swtCrawl.Value = true;
                txtAgeCrawlStarts.Text = reader["age_crawl_starts"].ToString();
                txtAgeCrawlStarts.Enabled = false;
            }

            // Desarrollo del lenguaje
            if (!reader.IsDBNull(reader.GetOrdinal("age_language_development_starts")))
            {
                swtLanguageDevelopment.Value = true;
                txtAgeLanguageDevelopmentStarts.Text = reader["age_language_development_starts"].ToString();
                txtAgeLanguageDevelopmentStarts.Enabled = false;
            }

            // Control de esfinteres
            if (!reader.IsDBNull(reader.GetOrdinal("age_sphincter_control_starts")))
            {
                swtSphincterControl.Value = true;
                txtAgeSphincterControlStarts.Text = reader["age_sphincter_control_starts"].ToString();
                txtAgeSphincterControlStarts.Enabled = false;
            }

            // Aparicion de la denticion
            if (!reader.IsDBNull(reader.GetOrdinal("age_dentation_appears")))
            {
                swtDentation.Value = true;
                txtAgeDentationStarts.Text = reader["age_dentation_appears"].ToString();
                txtAgeDentationStarts.Enabled = false;
            }

            // Problemas en el desarrollo
            if (!reader.IsDBNull(reader.GetOrdinal("problems_in_development")))
            {
                swtDevelopmentProblems.Value = true;
                txtProblemsInDevelopment.Text = reader["problems_in_development"].ToString();
                txtProblemsInDevelopment.Enabled = false;
            }

            // Activamos los botones
            cmdModifySave.Enabled = true;
        }

        private void EnableComponents(bool enable)
        {
            if (enable)
            {
                cmdSelectPhoto.Visible = true;

                txtName.Enabled = true;
                txtFirstLastName.Enabled = true;
                txtSecondLastName.Enabled = true;
                txtBirthPlace.Enabled = true;
                txtFatherName.Enabled = true;
                txtHomeAddress.Enabled = true;
                txtContactPhone.Enabled = true;

                clnDateBirth.Enabled = true;

                grpSex.Enabled = true;

                txtFamilyHereditaryAntecedents.Enabled = true;
                txtMotherAge.Enabled = true;
                txtMotherNumberOfPregnancies.Enabled = true;
                txtMotherNumberOfPrenatalQuerys.Enabled = true;

                cmbMaternalHemotype.Enabled = true;
                cmbPaternalHemotype.Enabled = true;

                swtMotherHadRisksPregnancy.Enabled = true;
                swtMotherHadTreatments.Enabled = true;
                swtMotherHadDrugAddictions.Enabled = true;
                swtMotherHadAllergies.Enabled = true;

                txtPacientGestationalAgeAtBirth.Enabled = true;

                cmbPacientBirthForm.Enabled = true;
                cmbPacientApgarEvaluation.Enabled = true;

                txtPacientWeight.Enabled = true;
                txtPacientSize.Enabled = true;
                txtPacientCephalicPerimeterAtBirth.Enabled = true;

                swtPacientHadBirthComplications.Enabled = true;
                swtPacientHadNeonatalDetection.Enabled = true;
                swtPacientHadAllergies.Enabled = true;

                txtVaccineHistory.Enabled = true;
                txtInitialFeed.Enabled = true;
                txtActualFeed.Enabled = true;
                txtHygineRutines.Enabled = true;

                swtAblactation.Enabled = true;
                swtWeaning.Enabled = true;

                swtPreviousDiseases.Enabled = true;
                swtHospitalizations.Enabled = true;
                swtTrauma.Enabled = true;
                swtTransfusions.Enabled = true;
                swtSurgerie.Enabled = true;
                swtActualTreatment.Enabled = true;

                swtCephalicSupport.Enabled = true;
                swtSedestation.Enabled = true;
                swtBipedestation.Enabled = true;
                swtWandering.Enabled = true;
                swtCrawl.Enabled = true;
                swtLanguageDevelopment.Enabled = true;
                swtSphincterControl.Enabled = true;
                swtDentation.Enabled = true;
                swtDevelopmentProblems.Enabled = true;
            }
            else
            {
                cmdSelectPhoto.Visible = false;

                txtName.Enabled = false;
                txtFirstLastName.Enabled = false;
                txtSecondLastName.Enabled = false;
                txtBirthPlace.Enabled = false;
                txtFatherName.Enabled = false;
                txtHomeAddress.Enabled = false;
                txtContactPhone.Enabled = false;

                clnDateBirth.Enabled = false;

                grpSex.Enabled = false;

                txtFamilyHereditaryAntecedents.Enabled = false;
                txtMotherAge.Enabled = false;
                txtMotherNumberOfPregnancies.Enabled = false;
                txtMotherNumberOfPrenatalQuerys.Enabled = false;

                cmbMaternalHemotype.Enabled = false;
                cmbPaternalHemotype.Enabled = false;

                swtMotherHadRisksPregnancy.Enabled = false;
                txtMotherRisksPregnancy.Enabled = false;

                swtMotherHadTreatments.Enabled = false;
                txtMotherTreatments.Enabled = false;

                swtMotherHadDrugAddictions.Enabled = false;
                txtMotherDrugAddictions.Enabled = false;

                swtMotherHadAllergies.Enabled = false;
                txtMotherAllergies.Enabled = false;

                txtPacientGestationalAgeAtBirth.Enabled = false;

                cmbPacientBirthForm.Enabled = false;
                cmbPacientApgarEvaluation.Enabled = false;

                txtPacientWeight.Enabled = false;
                txtPacientSize.Enabled = false;
                txtPacientCephalicPerimeterAtBirth.Enabled = false;

                swtPacientHadBirthComplications.Enabled = false;
                txtPacientBirthComplications.Enabled = false;

                swtPacientHadNeonatalDetection.Enabled = false;
                txtPacientNeonatalDetection.Enabled = false;

                swtPacientHadAllergies.Enabled = false;
                txtPacientAllergies.Enabled = false;

                txtVaccineHistory.Enabled = false;
                txtInitialFeed.Enabled = false;
                txtActualFeed.Enabled = false;
                txtHygineRutines.Enabled = false;

                swtAblactation.Enabled = false;
                txtAgeAblactationStarts.Enabled = false;

                swtWeaning.Enabled = false;
                txtAgeWeaningStarts.Enabled = false;

                swtPreviousDiseases.Enabled = false;
                txtPreviousDiseases.Enabled = false;

                swtHospitalizations.Enabled = false;
                txtHospitalizationCauses.Enabled = false;

                swtTrauma.Enabled = false;
                txtTraumaCauses.Enabled = false;

                swtTransfusions.Enabled = false;
                txtTransfusionsCauses.Enabled = false;

                swtSurgerie.Enabled = false;
                txtSurgeriesCauses.Enabled = false;

                swtActualTreatment.Enabled = false;
                txtActualTreatment.Enabled = false;

                swtCephalicSupport.Enabled = false;
                txtAgeCephalicSupportStarts.Enabled = false;

                swtSedestation.Enabled = false;
                txtAgeSedestationStarts.Enabled = false;

                swtBipedestation.Enabled = false;
                txtAgeBipedestationStarts.Enabled = false;

                swtWandering.Enabled = false;
                txtAgeWanderingStarts.Enabled = false;

                swtCrawl.Enabled = false;
                txtAgeCrawlStarts.Enabled = false;

                swtLanguageDevelopment.Enabled = false;
                txtAgeLanguageDevelopmentStarts.Enabled = false;

                swtSphincterControl.Enabled = false;
                txtAgeSphincterControlStarts.Enabled = false;

                swtDentation.Enabled = false;
                txtAgeDentationStarts.Enabled = false;

                swtDevelopmentProblems.Enabled = false;
                txtProblemsInDevelopment.Enabled = false;
            }
        }

        private void UpdateMedicalQuerys(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("UPDATE medical_querys SET folio=@folio, name=@name WHERE folio=@old_folio;", connection);

            if (foliosList.Count != 0)
            {
                command.Parameters.AddWithValue("@old_folio", foliosList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].folio);
                command.Parameters.AddWithValue("@folio", folio.GetFolio());
                command.Parameters.AddWithValue("@name", txtName.Text + " " + txtFirstLastName.Text + " " + txtSecondLastName.Text);
            }
            else if (namesList.Count != 0)
            {
                command.Parameters.AddWithValue("@old_folio", namesList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].folio);
                command.Parameters.AddWithValue("@folio", folio.GetFolio());
                command.Parameters.AddWithValue("@name", txtName.Text + " " + txtFirstLastName.Text + " " + txtSecondLastName.Text);
            }

            command.ExecuteNonQuery();
        }

        private void UpdateAgenda(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("UPDATE agenda SET folio=@folio, name=@name, contact_phone=@contact_phone WHERE folio=@old_folio", connection);

            if (foliosList.Count != 0)
            {
                command.Parameters.AddWithValue("@old_folio", foliosList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].folio);
                command.Parameters.AddWithValue("@folio", folio.GetFolio());
                command.Parameters.AddWithValue("@name", txtName.Text + " " + txtFirstLastName.Text + " " + txtSecondLastName.Text);
                command.Parameters.AddWithValue("@contact_phone", txtContactPhone.Text);
            }
            else if (namesList.Count != 0)
            {
                command.Parameters.AddWithValue("@old_folio", namesList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].folio);
                command.Parameters.AddWithValue("@folio", folio.GetFolio());
                command.Parameters.AddWithValue("@name", txtName.Text + " " + txtFirstLastName.Text + " " + txtSecondLastName.Text);
                command.Parameters.AddWithValue("@contact_phone", txtContactPhone.Text);
            }

            command.ExecuteNonQuery();
        }

        private void Search()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SAICP-Database;Integrated Security=True");
            SqlCommand command;
            SqlDataReader reader;

            if (txtSearchBy.Text.Length == 0)
            {
                MessageBox.Show("El campo de busqueda se encuentra vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmdModifySave.Enabled = false;
            }
            else if (cmbSearchBy.SelectedIndex == 0)
            {
                command = new SqlCommand("SELECT * FROM clinical_records WHERE folio=@folio", connection);

                if (txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text) != -1)
                {
                    selectedID = txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text);

                    command.Parameters.AddWithValue("@folio", foliosList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].folio);

                    connection.Open();

                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        DisplayData(reader);
                    }

                    connection.Close();

                    SetAutoCompleteCustomSourceByFolio();
                }
                else
                {
                    MessageBox.Show("No se encontro el registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdModifySave.Enabled = false;
                }
            }
            else
            {
                command = new SqlCommand("SELECT * FROM clinical_records WHERE (name=@name AND first_last_name=@first_last_name) AND second_last_name=@second_last_name;", connection);

                if (txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text) != -1)
                {
                    selectedID = txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text);

                    command.Parameters.AddWithValue("@name", namesList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].Name);
                    command.Parameters.AddWithValue("@first_last_name", namesList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].FirstLastName);
                    command.Parameters.AddWithValue("@second_last_name", namesList[txtSearchBy.AutoCompleteCustomSource.IndexOf(txtSearchBy.Text)].SecondLastName);

                    connection.Open();

                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        DisplayData(reader);
                    }

                    connection.Close();

                    SetAutoCompleteCustomSourceByName();
                }
                else
                {
                    MessageBox.Show("No se encontro el registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdModifySave.Enabled = false;
                }
            }
        }
    }

    public class SearchByFolio
    {
        public int ID { get; set; }
        public string folio { get; set; }
    }

    public class SearchByName
    {
        public int ID { get; set; }
        public string folio { get; set; }
        public string Name { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
    }
}