namespace Caja___TalkLink
{
    partial class Servicios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbx_NomServicio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtbx_Descripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtbx_Tarifa = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // txtbx_NomServicio
            // 
            this.txtbx_NomServicio.AnimateReadOnly = false;
            this.txtbx_NomServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_NomServicio.Depth = 0;
            this.txtbx_NomServicio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_NomServicio.Hint = "Nombre del Servicio";
            this.txtbx_NomServicio.LeadingIcon = null;
            this.txtbx_NomServicio.Location = new System.Drawing.Point(233, 51);
            this.txtbx_NomServicio.MaxLength = 50;
            this.txtbx_NomServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbx_NomServicio.Multiline = false;
            this.txtbx_NomServicio.Name = "txtbx_NomServicio";
            this.txtbx_NomServicio.Size = new System.Drawing.Size(228, 50);
            this.txtbx_NomServicio.TabIndex = 2;
            this.txtbx_NomServicio.Text = "";
            this.txtbx_NomServicio.TrailingIcon = null;
            this.txtbx_NomServicio.UseAccent = false;
            // 
            // txtbx_Descripcion
            // 
            this.txtbx_Descripcion.AnimateReadOnly = false;
            this.txtbx_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Descripcion.Depth = 0;
            this.txtbx_Descripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Descripcion.Hint = "Descripcion";
            this.txtbx_Descripcion.LeadingIcon = null;
            this.txtbx_Descripcion.Location = new System.Drawing.Point(497, 51);
            this.txtbx_Descripcion.MaxLength = 50;
            this.txtbx_Descripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbx_Descripcion.Multiline = false;
            this.txtbx_Descripcion.Name = "txtbx_Descripcion";
            this.txtbx_Descripcion.Size = new System.Drawing.Size(228, 50);
            this.txtbx_Descripcion.TabIndex = 3;
            this.txtbx_Descripcion.Text = "";
            this.txtbx_Descripcion.TrailingIcon = null;
            this.txtbx_Descripcion.UseAccent = false;
            // 
            // txtbx_Tarifa
            // 
            this.txtbx_Tarifa.AnimateReadOnly = false;
            this.txtbx_Tarifa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Tarifa.Depth = 0;
            this.txtbx_Tarifa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Tarifa.Hint = "$ Monto";
            this.txtbx_Tarifa.LeadingIcon = null;
            this.txtbx_Tarifa.Location = new System.Drawing.Point(233, 121);
            this.txtbx_Tarifa.MaxLength = 50;
            this.txtbx_Tarifa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbx_Tarifa.Multiline = false;
            this.txtbx_Tarifa.Name = "txtbx_Tarifa";
            this.txtbx_Tarifa.Size = new System.Drawing.Size(143, 50);
            this.txtbx_Tarifa.TabIndex = 4;
            this.txtbx_Tarifa.Text = "";
            this.txtbx_Tarifa.TrailingIcon = null;
            this.txtbx_Tarifa.UseAccent = false;
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 485);
            this.Controls.Add(this.txtbx_Tarifa);
            this.Controls.Add(this.txtbx_Descripcion);
            this.Controls.Add(this.txtbx_NomServicio);
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtbx_NomServicio;
        private MaterialSkin.Controls.MaterialTextBox txtbx_Descripcion;
        private MaterialSkin.Controls.MaterialTextBox txtbx_Tarifa;
    }
}