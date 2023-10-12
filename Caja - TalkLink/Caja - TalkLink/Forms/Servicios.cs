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
    public partial class Servicios : Form
    {
        //fields
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Caja___TalkLink.Properties.Settings.TLDatabaseConnectionString"].ConnectionString;
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
            }
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

        private void mbtnAgregaServicio_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreServicio = txtbx_NomServicio.Text;
                string descripcion = txtbxm_Descripcion.Text;
                decimal tarifa = decimal.Parse(txtbx_Tarifa.Text); 

                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Caja___TalkLink.Properties.Settings.TLDatabaseConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("sp_InsertarServicio", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NombreServicio", nombreServicio);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Monto", tarifa);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // El servicio se insertó correctamente en la base de datos.
                        MessageBox.Show("Servicio agregado con éxito", "Éxito", MessageBoxButtons.OK);
                        LimpiarControles(this);
                    }
                    else
                    {
                        // El servicio ya existe en la base de datos.
                        lblMensajeError.Visible = true;
                    }

                    // Luego de agregar el servicio con éxito, recarga los datos en el DataGridView.
                    this.servicosTableAdapter.Fill(this.tLDatabaseDataSet.Servicos);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores, muestra el mensaje de error en caso de excepción.
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
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

        private void Servicios_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'tLDatabaseDataSet.Servicos' table. You can move, or remove it, as needed.
            this.servicosTableAdapter.Fill(this.tLDatabaseDataSet.Servicos);
            // Llama al método GetServiciosDataSet para obtener los datos.
            DataSet serviciosDataSet = GetServiciosDataSet();

            // Asigna el DataSet al DataGridView.
            dGVServicios.AutoGenerateColumns = false;
            dGVServicios.DataSource = serviciosDataSet.Tables[0];
            // Agregar una columna de CheckBox para la selección de servicios
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "ColumnaSeleccion",
                HeaderText = "Seleccionar",
                DataPropertyName = "Seleccionado", // Asegúrate de ajustar esto al nombre de la columna en tu DataTable.
                Width = 80
            };
            dGVServicios.Columns.Add(checkBoxColumn);
        }

        private void dGVServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_EliminarServico_Click(object sender, EventArgs e)
        {
            List<int> serviciosAEliminar = new List<int>();

            foreach (DataGridViewRow row in dGVServicios.Rows)
            {
                // Verifica si el servicio está seleccionado en el DataGridView.
                bool seleccionado = Convert.ToBoolean(row.Cells["ColumnaSeleccion"].Value);

                if (seleccionado)
                {
                    int idServicio = Convert.ToInt32(row.Cells["IDServicio"].Value);
                    serviciosAEliminar.Add(idServicio);
                }
            }

            if (serviciosAEliminar.Count > 0)
            {
                // Conecta a la base de datos y elimina los servicios seleccionados utilizando el procedimiento almacenado.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (int idServicio in serviciosAEliminar)
                    {
                        using (SqlCommand command = new SqlCommand("sp_EliminarServicio", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IDServicio", idServicio);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                // Actualiza el DataGridView para reflejar los cambios en la base de datos.
                this.servicosTableAdapter.Fill(this.tLDatabaseDataSet.Servicos);
            }
        }
    }
}
