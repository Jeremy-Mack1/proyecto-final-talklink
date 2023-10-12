using MaterialSkin.Controls;
using System;
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
        //Fields

        private string genero = "";
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
                                   Mtxbx_Documento.Text.Length == Mtxbx_Documento.MaxLength &&
                                   !string.IsNullOrWhiteSpace(Mtxbx_Nombre.Text) &&
                                   !string.IsNullOrWhiteSpace(Mtxbx_Apellido.Text) &&
                                   EsFechaValida(Mtxbx_FechaNacimiento.Text) &&
                                   MtxbxTelefono.Text.Length == MtxbxTelefono.MaxLength &&
                                   MtxbxTelefonoAlt.Text.Length == MtxbxTelefonoAlt.MaxLength &&
                                   !string.IsNullOrWhiteSpace(txtbx_Direccion.Text) &&
                                   !string.IsNullOrWhiteSpace(txtbx_Estado.Text) &&
                                   (MRB_Masculino.Checked || MRB_Femenino.Checked);

            mbtnAgregarCliente.Enabled = camposCompletos;
        }

        private bool EsFechaValida(string fechaStr)
        {
            if (DateTime.TryParseExact(fechaStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                return true; // La fecha es válida
            }

            return false; // La fecha ingresada no es válida
        }

        private void Mtxbx_TipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mtxbx_Documento.Enabled = Mtxbx_TipoDocumento.SelectedIndex != -1;

            switch (Mtxbx_TipoDocumento.SelectedIndex)
            {
                case 0: // Cédula
                    Mtxbx_Documento.MaxLength = 11;
                    break;
                case 1: // Pasaporte
                    Mtxbx_Documento.MaxLength = 9;
                    break;
                default:
                    Mtxbx_Documento.Text = "";
                    break;
            }

            HabilitarBoton();
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

        private void Mtxbx_Nombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }

        private void MRB_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica cuál RadioButton está seleccionado y obtén el valor correspondiente.
            if (MRB_Masculino.Checked)
            {
                genero = "Masculino";
                // Puedes utilizar el valor "genero" como desees, por ejemplo, para guardarlo en la base de datos.
            }
            else if (MRB_Femenino.Checked)
            {
                genero = "Femenino";
                // Puedes utilizar el valor "genero" como desees, por ejemplo, para guardarlo en la base de datos.
            }
        }
        private void mbtnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Recopila los datos ingresados por el usuario
                string nombre = Mtxbx_Nombre.Text;
                string apellido = Mtxbx_Apellido.Text;
                string tipoDocumento = Mtxbx_TipoDocumento.Text;
                string documento = Mtxbx_Documento.Text;
                string telefono = MtxbxTelefono.Text;
                string telefonoAlt = MtxbxTelefonoAlt.Text;
                string direccion = txtbx_Direccion.Text;
                string estado = txtbx_Estado.Text;
                string FechaNacimiento = Mtxbx_FechaNacimiento.Text;

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
                        command.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                        command.Parameters.AddWithValue("@Sexo", genero);

                        // Ejecuta el store procedure
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Solicitud enviada con éxito", "Éxito", MessageBoxButtons.OK);
                LimpiarControles(this);
            }
        }

        #endregion

        private bool UsuarioExiste(string tipoDocumento, string documento)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Caja___TalkLink.Properties.Settings.TLDatabaseConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("sp_VerificarUsuario", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                command.Parameters.AddWithValue("@Documento", documento);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // El usuario existe, recupera los datos y muestra en los TextBox
                        Mtxbx_Nombre.Text = reader["Nombre"].ToString();
                        Mtxbx_Apellido.Text = reader["Apellido"].ToString();
                        Mtxbx_TipoDocumento.Text = reader["TipoDocumento"].ToString();
                        Mtxbx_Documento.Text = reader["Documento"].ToString();
                        MtxbxTelefono.Text = reader["Telefono"].ToString();
                        MtxbxTelefonoAlt.Text = reader["Telefonoalt"].ToString();
                        txtbx_Direccion.Text = reader["Direccion"].ToString();
                        txtbx_Estado.Text = reader["Estado"].ToString();

                        // Recupera el valor del género
                        string genero = reader["Genero"].ToString();

                        // Asigna el valor del género a los RadioButton
                        if (genero == "Masculino")
                        {
                            MRB_Masculino.Checked = true;
                        }
                        else if (genero == "Femenino")
                        {
                            MRB_Femenino.Checked = true;
                        }

                        
                        return true; // Usuario encontrado
                        
                    }
                    // Si el usuario no se encontró en la base de datos, retorna false.
                    return false;
                    
                }
            }
        }

        private void mbtnConsultar_Click(object sender, EventArgs e)
        {
            string tipoDocumento = Mtxbx_TipoDocumento.Text;
            string documento = Mtxbx_Documento.Text;

            if (UsuarioExiste(tipoDocumento, documento))
            {
                // El usuario existe, puedes habilitar el botón de "Editar Cliente"
                mbtn_EditarCliente.Enabled = true;
                lblErrorClienteNoExiste.Visible = false;
            }
            else
            {
                lblErrorClienteNoExiste.Visible = true;
            }

        }
    }
}
