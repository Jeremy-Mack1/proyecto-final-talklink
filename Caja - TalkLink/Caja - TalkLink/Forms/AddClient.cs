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
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Caja___TalkLink.Properties.Settings.TLDatabaseConnectionString"].ConnectionString;

        private string genero = "";
        public AddClient()
        {
            InitializeComponent();
            mbtnAgregarCliente.Enabled = false;
            mbtn_EditarCliente.Enabled = false;


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
                        !string.IsNullOrWhiteSpace(Mtxbx_Nombre.Text) &&
                        !string.IsNullOrWhiteSpace(Mtxbx_Apellido.Text) &&
                        EsFechaValida(Mtxbx_FechaNacimiento.Text) &&
                        MtxbxTelefono.Text.Length == MtxbxTelefono.MaxLength &&
                        MtxbxTelefonoAlt.Text.Length == MtxbxTelefonoAlt.MaxLength &&
                        !string.IsNullOrWhiteSpace(txtbx_Direccion.Text) &&
                        !string.IsNullOrWhiteSpace(txtbx_Estado.Text) &&
                        (MRB_Masculino.Checked || MRB_Femenino.Checked);

            if (Mtxbx_TipoDocumento.SelectedIndex == 0)
            {
                camposCompletos = camposCompletos && (Mtxbx_Documento.Text.Length == 11);
            }
            else if (Mtxbx_TipoDocumento.SelectedIndex == 1)
            {
                camposCompletos = camposCompletos && (Mtxbx_Documento.Text.Length == 9);
            }

            mbtnAgregarCliente.Enabled = camposCompletos;
            mbtn_EditarCliente.Enabled = camposCompletos;


        }

        private void Mtxbx_Documento_TextChanged(object sender, EventArgs e)
        {
            // Verifica si el campo Mtxbx_Documento tiene la longitud máxima adecuada para el tipo de documento seleccionado
            if (Mtxbx_TipoDocumento.SelectedIndex == 0 && Mtxbx_Documento.Text.Length == 11)
            {
                HabilitarBoton();
            }
            else if (Mtxbx_TipoDocumento.SelectedIndex == 1 && Mtxbx_Documento.Text.Length == 9)
            {
                HabilitarBoton();
            }
            else
            {
                mbtnAgregarCliente.Enabled = false;
                mbtn_EditarCliente.Enabled = false;
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
            // Verifica si al menos un servicio está seleccionado.
            bool alMenosUnServicioSeleccionado = false;

            foreach (DataGridViewRow row in dGVUsuarios.Rows)
            {
                bool seleccionado = Convert.ToBoolean(row.Cells["ColumnaSeleccion"].Value);
                if (seleccionado)
                {
                    alMenosUnServicioSeleccionado = true;
                    break;
                }
            }

            if (!alMenosUnServicioSeleccionado)
            {
                MessageBox.Show("Selecciona al menos un servicio antes de agregar el cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("¿Estás seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Recopila los datos ingresados por el usuario
                string nombre = Mtxbx_Nombre.Text;
                string apellido = Mtxbx_Apellido.Text;
                int tipoDocumento = Mtxbx_TipoDocumento.SelectedIndex;
                string documento = Mtxbx_Documento.Text;
                string telefono = MtxbxTelefono.Text;
                string telefonoAlt = MtxbxTelefonoAlt.Text;
                string direccion = txtbx_Direccion.Text;
                string estado = txtbx_Estado.Text;
                string FechaNacimiento = Mtxbx_FechaNacimiento.Text;
                string Sexo = genero;


                // Recopila las selecciones de servicios hechas por el cliente
                List<int> serviciosSeleccionados = new List<int>();
                foreach (DataGridViewRow row in dGVUsuarios.Rows)
                {
                    // Verifica si el servicio está seleccionado en el DataGridView (ajusta esto según tu implementación).
                    bool seleccionado = Convert.ToBoolean(row.Cells["ColumnaSeleccion"].Value);
                    if (seleccionado)
                    {
                        serviciosSeleccionados.Add(row.Index); // Puedes usar row.Index como una identificación única
                    }
                }

                // Inserta el cliente en la tabla "Clientes" y obtén el ID del cliente recién insertado.
                InsertarCliente(nombre, apellido, tipoDocumento, documento, telefono, telefonoAlt, direccion, estado, FechaNacimiento, Sexo);

                // Inserta las asociaciones de servicios seleccionados con el cliente en la tabla "ClienteServicios"
                foreach (int idServicio in serviciosSeleccionados)
                {
                    InsertarClienteServicios(documento, idServicio);
                }

                MessageBox.Show("Solicitud enviada con éxito", "Éxito", MessageBoxButtons.OK);
                LimpiarControles(this);
                genero = "";
            }
        }

        private void InsertarClienteServicios(string documento, int idServicio)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_InsertarClienteServicio", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Documento", documento); // Usa el documento en lugar del ID del cliente
                        command.Parameters.AddWithValue("@IDServicio", idServicio);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al insertar cliente-servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InsertarCliente(string nombre, string apellido, int tipoDocumento, string documento, string telefono, string telefonoAlt, string direccion, string estado, string FechaNacimiento, string Sexo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_UpsertCliente", connection))
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
                        command.Parameters.AddWithValue("@Sexo", Sexo);

                        // Ejecuta el store procedure
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al insertar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        #endregion

        private bool UsuarioExiste(string tipoDocumento, string documento)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Caja___TalkLink.Properties.Settings.TLDatabaseConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("sp_BuscarCliente", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                command.Parameters.AddWithValue("@Documento", documento);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.Read())
                        {
                            // El usuario existe, recupera los datos y muestra en los TextBox
                            Mtxbx_Nombre.Text = reader["Nombre"].ToString();
                            Mtxbx_Apellido.Text = reader["Apellido"].ToString();
                            string tipoDocumentoRead = reader["TipoDocumento"].ToString();

                            if (tipoDocumentoRead == "0")
                            {
                                Mtxbx_TipoDocumento.SelectedIndex = 0; // Selecciona el primer elemento del ComboBox
                            }
                            else if (tipoDocumentoRead == "1")
                            {
                                Mtxbx_TipoDocumento.SelectedIndex = 1; // Selecciona el segundo elemento del ComboBox
                            }
                            Mtxbx_Documento.Text = reader["Documento"].ToString();
                            Mtxbx_FechaNacimiento.Text = reader["FechaNacimiento"].ToString();
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
                                MRB_Femenino.Checked = false;
                            }
                            else if (genero == "Femenino")
                            {
                                MRB_Masculino.Checked = false;
                                MRB_Femenino.Checked = true;
                            }

                            return true; // Usuario encontrado
                        }
                        // Si el usuario no se encontró en la base de datos, retorna false.
                        return false;
                    }
                    finally
                    {
                        reader.Close(); // Cierra el SqlDataReader en el bloque finally
                    }
                }
            }
        }


        private void mbtnConsultar_Click(object sender, EventArgs e)
        {
            string tipoDocumento = Mtxbx_TipoDocumento.Text;
            string documento = Mtxbx_Documento.Text;

            if (UsuarioExiste(tipoDocumento, documento))
            {
                
                mbtn_EditarCliente.Enabled = true;
                lblErrorClienteNoExiste.Visible = false;
            }
            else
            {
                lblErrorClienteNoExiste.Visible = true;
            }

        }

        private void dGVUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public DataSet GetServiciosDataSet()
        {
            DataSet dataSet = new DataSet();
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_GetAllServicios", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);
                    }
                }
            }

            return dataSet;
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            // TODO:  loads data into the 'tLDatabaseDataSet.Servicos' table. 
            //this.servicosTableAdapter.Fill(this.tLDatabaseDataSet1.Servicos);
            // Llama al método GetServiciosDataSet para obtener los datos.
            DataSet serviciosDataSet = GetServiciosDataSet();

            // Asigna el DataSet al DataGridView.
            dGVUsuarios.AutoGenerateColumns = false;
            dGVUsuarios.DataSource = serviciosDataSet.Tables[0];
            // Agregar una columna de CheckBox para la selección de servicios
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "ColumnaSeleccion",
                HeaderText = "Seleccionar",
                DataPropertyName = "Seleccionado", // Asegúrate de ajustar esto al nombre de la columna en tu DataTable.
                Width = 80
            };
            dGVUsuarios.Columns.Add(checkBoxColumn);
        }
    }




}

