using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja___TalkLink.Forms
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void HabilitarConsultarReporte()
        {
            bool requisitosConsulta = MCBTipoDocumento.SelectedIndex != -1 &&
                                      Mtxtbx_Documento.Text.Length == Mtxtbx_Documento.MaxLength;

            mbtnConsultarReporte.Enabled = requisitosConsulta;
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

            HabilitarConsultarReporte();
        }

        private void Mtxtbx_Documento_TextChanged(object sender, EventArgs e)
        {
            HabilitarConsultarReporte();
        }
    }
}
