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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {

        }

        #region Validaciones
        private void BotonConfirmarTransaccionActivado()
        {
            bool cantidadIngresada = !string.IsNullOrWhiteSpace(MtxtMontoPagar.Text);

            MBtnConfirmarPago.Enabled = cantidadIngresada;
        }

        private void BotonVerificarActivado()
        {
            bool datosIngresados = MCBTipoDocumento.SelectedIndex != -1 && Mtxtbx_Documento.Text.Length == Mtxtbx_Documento.MaxLength;
            btn_verify.Enabled = datosIngresados;
        }

        private void MCBTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mtxtbx_Documento.Enabled = MCBTipoDocumento.SelectedIndex != -1;

            switch (MCBTipoDocumento.SelectedIndex)
            {
                case 0: // Cédula
                    Mtxtbx_Documento.MaxLength = 11;
                    break;
                case 1: // Pasaporte
                    Mtxtbx_Documento.MaxLength = 9;
                    break;
                default:
                    Mtxtbx_Documento.Text = "";
                    break;
            }

            BotonVerificarActivado();
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

        private void Mtxtbx_Documento_TextChanged(object sender, EventArgs e)
        {
            BotonVerificarActivado();
        }

        private void MtxtMontoPagar_TextChanged(object sender, EventArgs e)
        {
            BotonConfirmarTransaccionActivado();
        }    

        private void MBtnConfirmarPago_Click(object sender, EventArgs e)
        {
           

            if (MessageBox.Show("¿Estás seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Solicitud enviada con éxito", "Éxito", MessageBoxButtons.OK); // Limpia todos los controles en el formulario
            }

        }
        #endregion  
    }
}
