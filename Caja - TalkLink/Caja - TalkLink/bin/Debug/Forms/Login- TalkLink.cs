using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System.IO;

namespace Caja___TalkLink
{
    public partial class Login__TalkLink : Form
    {
        public Login__TalkLink()
        {
            InitializeComponent();

    }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void txtbx_Usuario_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txtbx_Usuario_Enter(object sender, System.EventArgs e)
        {
            if(txtbx_Usuario.Text == "Usuario")
            {
                txtbx_Usuario.Text = "";
                txtbx_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void txtbx_Usuario_Leave(object sender, System.EventArgs e)
        {
            if (txtbx_Usuario.Text == "")
            {
                txtbx_Usuario.Text = "Usuario";
                txtbx_Usuario.ForeColor = Color.White;
            }
        }

        private void txtbx_Pass_Enter(object sender, System.EventArgs e)
        {
            if( txtbx_Pass.Text == "Contraseña")
            {
                txtbx_Pass.Text = "";
                txtbx_Pass.ForeColor = Color.LightGray;
                txtbx_Pass.UseSystemPasswordChar = true;
            }
        }

        private void txtbx_Pass_Leave(object sender, System.EventArgs e)
        {
            if(txtbx_Pass.Text == "")
            {
                txtbx_Pass.Text = "Contraseña";
                txtbx_Pass.ForeColor = Color.White;
                txtbx_Pass.UseSystemPasswordChar = false;
            }
        }

        private void pb_Cerrar_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void pb_Minimizar_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login__TalkLink_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pb_Logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pb_NoVisible_Click(object sender, EventArgs e)
        {

        }

        private void pb_NoVisible_MouseDown(object sender, MouseEventArgs e)
        {
            string verpng = "C:\\Users\\Heine\\Documents\\Herdel Uni\\Proyecto Final - Desarrollo III\\ver.png";
            
            if (File.Exists(verpng))
            {
                try
                {
                    
                    // Liberar recursos de la imagen anterior si la hay
                    if (pb_NoVisible.Image != null)
                    {
                        pb_NoVisible.Image.Dispose();
                    }

                    Image imagenMousedown = Image.FromFile(verpng);
                    // Asignar la imagen de clic al PictureBox
                    pb_NoVisible.Image = imagenMousedown;
                    txtbx_Pass.UseSystemPasswordChar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen de clic: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("La imagen de clic no existe en la ruta especificada.");
            }

        }

        private void pb_NoVisible_MouseUp(object sender, MouseEventArgs e)
        {
            string rutaImagenNormal = "C:\\Users\\Heine\\Documents\\Herdel Uni\\Proyecto Final - Desarrollo III\\no-visible (1).png";

            if (File.Exists(rutaImagenNormal))
            {
                try
                {

                    // Liberar recursos de la imagen anterior si la hay
                    if (pb_NoVisible.Image != null)
                    {
                        pb_NoVisible.Image.Dispose();
                    }
                    Image imagenNormal = Image.FromFile(rutaImagenNormal);
                    // Asignar la imagen normal al PictureBox cuando se libere el botón del mouse
                    pb_NoVisible.Image = imagenNormal;

                    txtbx_Pass.UseSystemPasswordChar = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen normal: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("La imagen normal no existe en la ruta especificada.");
            }
        }

        private void btn_Acceder_Click(object sender, EventArgs e)
        {


            this.Hide();    
            Form form = new Default();
            form.Show();
            
            
        }
    }
}
