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
    public partial class Pagos : Form
    {
        //fields
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Caja___TalkLink.Properties.Settings.TLDatabaseConnectionString"].ConnectionString;
        public Pagos()
        {
            InitializeComponent();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tLDatabaseDataSet.Servicos' table. You can move, or remove it, as needed.
            this.servicosTableAdapter.Fill(this.tLDatabaseDataSet.Servicos);

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

        private void btn_verify_Click(object sender, EventArgs e)
        {
            string numeroDocumento = Mtxtbx_Documento.Text;

            // Llama al procedimiento almacenado para obtener los servicios del cliente
            DataTable serviciosCliente = ObtenerServiciosDelCliente(numeroDocumento);

            // Enlaza el DataGridView con los datos
            dGVServicios.DataSource = serviciosCliente;

            // Agrega columnas de monto y descripción al DataGridView
            dGVServicios.Columns.Add("Monto", "Monto");
            dGVServicios.Columns.Add("Descripcion", "Descripción");

            // Configura las columnas de solo lectura
            dGVServicios.Columns["Monto"].ReadOnly = true;


        }

        private void dGVServicios_SelectionChanged(object sender, EventArgs e)
        {
            // Cuando se selecciona una fila, muestra el monto y la descripción en los TextBox de solo lectura
            if (dGVServicios.SelectedRows.Count > 0)
            {
                string monto = dGVServicios.SelectedRows[0].Cells["Monto"].Value.ToString();
                string descripcion = dGVServicios.SelectedRows[0].Cells["Descripcion"].Value.ToString();

                MTxTMontoDebido.Text = monto;
            }
        }

        private DataTable ObtenerServiciosDelCliente(string numeroDocumento)
        {
            // Implementa la lógica para llamar al procedimiento almacenado y obtener los servicios del cliente.
            // Crea un DataTable y rellénalo con los resultados del procedimiento almacenado.
            DataTable resultados = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_ObtenerServiciosCliente", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Documento", numeroDocumento); // Corrige el nombre del parámetro

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(resultados);
                    }
                }
            }

            return resultados;
        }

    }
}
