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
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores, muestra el mensaje de error en caso de excepción.
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
