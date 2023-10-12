using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja___TalkLink
{
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        #region ValidacionesServicio
        private void HabilitarAgregarServicio()
        {
            bool requisitosAgregarServicio = !string.IsNullOrWhiteSpace(txtbx_NomServicio.Text) &&
                !string.IsNullOrWhiteSpace(txtbxm_Descripcion.Text) &&
                (!string.IsNullOrWhiteSpace(txtbx_Tarifa.Text) && decimal.TryParse(txtbx_Tarifa.Text, out decimal tarifa) && tarifa >= 0);

            mbtnAgregaServicio.Enabled = requisitosAgregarServicio;
        }

        private void PermitirNumerosDecimales(object sender, KeyPressEventArgs e)
        {
            Control control = (Control)sender;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && control.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtbx_NomServicio_TextChanged(object sender, EventArgs e)
        {
            HabilitarAgregarServicio();
        }
        #endregion
    }
}
