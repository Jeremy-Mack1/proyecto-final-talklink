﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja___TalkLink
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        #region Validaciones
        private void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            Control control = (Control)sender;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void PermitirSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void BloquearCaracteresEspeciales(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void HabilitarBoton()
        {
            bool camposCompletos = Mtxbx_TipoDocumento.SelectedIndex != -1 &&
                                   TieneMascaraDocumentoValida(Mtxbx_Documento.Mask, Mtxbx_Documento.Text) &&
                                   !string.IsNullOrWhiteSpace(Mtxbx_Nombre.Text) &&
                                   !string.IsNullOrWhiteSpace(Mtxbx_Apellido.Text) &&
                                   EsFechaValida(Mtxbx_FechaNacimiento.Text) &&
                                   TieneFormatoTelefonoValido(mmtxtTelefono.Text) &&
                                   TieneFormatoTelefonoValido(mmtxtTelefonoalt.Text) &&
                                   !string.IsNullOrWhiteSpace(Mtxtbx_Direccion.Text) &&
                                   !string.IsNullOrWhiteSpace(Mtxtbx_Estado.Text) &&
                                   (MRB_Masculino.Checked || MRB_Femenino.Checked);

            mbtnAgregarCliente.Enabled = camposCompletos;
        }

        private bool TieneMascaraDocumentoValida(string mascara, string valor)
        {
            // Eliminar caracteres no válidos de la máscara y el valor
            string mascaraLimpia = new string(mascara.Where(c => char.IsLetterOrDigit(c)).ToArray());
            string valorLimpio = new string(valor.Where(c => char.IsLetterOrDigit(c)).ToArray());

            return mascaraLimpia.Length == valorLimpio.Length;
        }

        private bool TieneFormatoTelefonoValido(string telefono)
        {
            // Verificar que el teléfono tenga el formato esperado "000-000-0000"
            string telefonoLimpio = telefono.Replace("-", ""); // Quitar guiones
            return telefonoLimpio.Length == 10 && telefonoLimpio.All(char.IsDigit);
        }

        private void Mtxbx_TipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mtxbx_Documento.Mask = ObtenerMascaraDocumento(Mtxbx_TipoDocumento.SelectedIndex);
            HabilitarBoton();
        }

        private string ObtenerMascaraDocumento(int tipoDocumentoIndex)
        {
            Mtxbx_Documento.Enabled = tipoDocumentoIndex != -1;

            switch (tipoDocumentoIndex)
            {
                case 0: // Cédula
                    return "000-0000000-0";
                case 1: // Pasaporte
                    return "AA000000";
                default:
                    return ""; // Otra opción, sin máscara
            }
        }

        private bool EsFechaValida(string fechaStr)
        {
            if (DateTime.TryParseExact(fechaStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                return true; // La fecha es válida
            }

            return false; // La fecha ingresada no es válida
        }

        private void LimpiarControles(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is GroupBox)
                {
                    LimpiarControles((GroupBox)ctrl);
                }
                else if (ctrl is TextBoxBase)
                {
                    ((TextBoxBase)ctrl).Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    comboBox.SelectedIndex = -1; // Establecer el ComboBox como no seleccionado (vacío).
                }
                else if (ctrl is RadioButton)
                {
                    RadioButton radiobutton = (RadioButton)ctrl;
                    radiobutton.Checked = false;
                }
            }
        }
        #endregion

        private void Mtxbx_Nombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }

        private void MRB_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }
        private void mbtnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("¿Estás seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Recopila los datos ingresados por el usuario
                    string nombre = Mtxbx_Nombre.Text;
                    string apellido = Mtxbx_Apellido.Text;
                    string tipoDocumento = Mtxbx_TipoDocumento.Text;
                    string documento = Mtxbx_Documento.Text;
                    string telefono = mmtxtTelefono.Text;
                    string telefonoAlt = mmtxtTelefonoalt.Text;
                    string direccion = Mtxtbx_Direccion.Text;
                    string estado = Mtxtbx_Estado.Text;

                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Heine\\Documents\\Herdel Uni\\Proyecto Final - Desarrollo III\\proyecto-final-talklink\\Caja - TalkLink\\Caja - TalkLink\\AppData\\TLDatabase.mdf;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Define el nombre del store procedure
                        string spName = "sp_UpsertCliente";

                        using (SqlCommand command = new SqlCommand(spName, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Asigna los parámetros con los valores recopilados
                            command.Parameters.AddWithValue("@Nombre", nombre);
                            command.Parameters.AddWithValue("@Apellido", apellido);
                            command.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                            command.Parameters.AddWithValue("@Documento", documento);
                            command.Parameters.AddWithValue("@telefono", telefono);
                            command.Parameters.AddWithValue("@TelefonoAlt", telefonoAlt);
                            command.Parameters.AddWithValue("@Direccion", direccion);
                            command.Parameters.AddWithValue("@Estado", estado);

                            // Ejecuta el store procedure
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Solicitud enviada con éxito", "Éxito", MessageBoxButtons.OK);
                    LimpiarControles(this);
                }


            }
        }

        private void mmtxtTelefonoalt_Click(object sender, EventArgs e)
        {

        }

    }
}

        
  