using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace SAICP
{
    public partial class frmNewEarningRecord : DevComponents.DotNetBar.Metro.MetroForm
    {
        private frmMain windowMenu;

        public frmNewEarningRecord(frmMain windowMenu)
        {
            InitializeComponent();
            this.windowMenu = windowMenu;
            MaximizeBox = false;
        }

        //Agregar un dato tipo bit, y cargar todos los datos de la fecha seleccionada
        //si el campo bit es 0, entonces se carga al comboBox y se muestra el número de cita
        //en caso contrario, no se va a mostrar
        //Esto para evitar dobles ingresos y malos cálculos
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
            if(txtPrice.Text == "" || cmbDateNumber.SelectedIndex < 0)
            {
                MessageBox.Show("Llene todos los datos correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
        }
    }
}