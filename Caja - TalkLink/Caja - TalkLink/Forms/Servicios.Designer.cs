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
            this.txtbx_Tarifa = new MaterialSkin.Controls.MaterialTextBox();
            this.dGVUsuarios = new System.Windows.Forms.DataGridView();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mbtnAgregaServicio = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.txtbxm_Descripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbx_NomServicio
            // 
            this.txtbx_NomServicio.AnimateReadOnly = false;
            this.txtbx_NomServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_NomServicio.Depth = 0;
            this.txtbx_NomServicio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbx_NomServicio.Hint = "Nombre del Servicio";
            this.txtbx_NomServicio.LeadingIcon = null;
            this.txtbx_NomServicio.Location = new System.Drawing.Point(30, 47);
            this.txtbx_NomServicio.MaxLength = 50;
            this.txtbx_NomServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbx_NomServicio.Multiline = false;
            this.txtbx_NomServicio.Name = "txtbx_NomServicio";
            this.txtbx_NomServicio.Size = new System.Drawing.Size(228, 50);
            this.txtbx_NomServicio.TabIndex = 0;
            this.txtbx_NomServicio.Text = "";
            this.txtbx_NomServicio.TrailingIcon = null;
            this.txtbx_NomServicio.UseAccent = false;
            this.txtbx_NomServicio.TextChanged += new System.EventHandler(this.txtbx_NomServicio_TextChanged);
            // 
            // txtbx_Tarifa
            // 
            this.txtbx_Tarifa.AnimateReadOnly = false;
            this.txtbx_Tarifa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Tarifa.Depth = 0;
            this.txtbx_Tarifa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbx_Tarifa.Hint = "$ Monto";
            this.txtbx_Tarifa.LeadingIcon = null;
            this.txtbx_Tarifa.Location = new System.Drawing.Point(30, 401);
            this.txtbx_Tarifa.MaxLength = 50;
            this.txtbx_Tarifa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbx_Tarifa.Multiline = false;
            this.txtbx_Tarifa.Name = "txtbx_Tarifa";
            this.txtbx_Tarifa.Size = new System.Drawing.Size(228, 50);
            this.txtbx_Tarifa.TabIndex = 2;
            this.txtbx_Tarifa.Text = "";
            this.txtbx_Tarifa.TrailingIcon = null;
            this.txtbx_Tarifa.UseAccent = false;
            this.txtbx_Tarifa.TextChanged += new System.EventHandler(this.txtbx_NomServicio_TextChanged);
            this.txtbx_Tarifa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirNumerosDecimales);
            // 
            // dGVUsuarios
            // 
            this.dGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsuarios.Location = new System.Drawing.Point(377, 98);
            this.dGVUsuarios.Name = "dGVUsuarios";
            this.dGVUsuarios.RowHeadersWidth = 51;
            this.dGVUsuarios.RowTemplate.Height = 24;
            this.dGVUsuarios.Size = new System.Drawing.Size(479, 353);
            this.dGVUsuarios.TabIndex = 5;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(320, 13);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 460);
            this.materialDivider1.TabIndex = 18;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mbtnAgregaServicio
            // 
            this.mbtnAgregaServicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAgregaServicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnAgregaServicio.Depth = 0;
            this.mbtnAgregaServicio.Enabled = false;
            this.mbtnAgregaServicio.HighEmphasis = true;
            this.mbtnAgregaServicio.Icon = null;
            this.mbtnAgregaServicio.Location = new System.Drawing.Point(377, 32);
            this.mbtnAgregaServicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAgregaServicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAgregaServicio.Name = "mbtnAgregaServicio";
            this.mbtnAgregaServicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnAgregaServicio.Size = new System.Drawing.Size(155, 36);
            this.mbtnAgregaServicio.TabIndex = 3;
            this.mbtnAgregaServicio.Text = "Agregar servicio";
            this.mbtnAgregaServicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnAgregaServicio.UseAccentColor = false;
            this.mbtnAgregaServicio.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(698, 32);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(156, 36);
            this.materialButton2.TabIndex = 4;
            this.materialButton2.Text = "Eliminar servicio";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // txtbxm_Descripcion
            // 
            this.txtbxm_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtbxm_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxm_Descripcion.Depth = 0;
            this.txtbxm_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbxm_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtbxm_Descripcion.Hint = "Descripción";
            this.txtbxm_Descripcion.Location = new System.Drawing.Point(30, 143);
            this.txtbxm_Descripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbxm_Descripcion.Name = "txtbxm_Descripcion";
            this.txtbxm_Descripcion.Size = new System.Drawing.Size(228, 224);
            this.txtbxm_Descripcion.TabIndex = 1;
            this.txtbxm_Descripcion.Text = "";
            this.txtbxm_Descripcion.TextChanged += new System.EventHandler(this.txtbx_NomServicio_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Depth = 0;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcion.Location = new System.Drawing.Point(37, 121);
            this.lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(84, 19);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripción";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 485);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtbxm_Descripcion);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.mbtnAgregaServicio);
            this.Controls.Add(this.dGVUsuarios);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txtbx_Tarifa);
            this.Controls.Add(this.txtbx_NomServicio);
            this.Name = "Servicios";
            this.Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtbx_NomServicio;
        private MaterialSkin.Controls.MaterialTextBox txtbx_Tarifa;
        private System.Windows.Forms.DataGridView dGVUsuarios;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton mbtnAgregaServicio;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtbxm_Descripcion;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
    }
}