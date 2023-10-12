namespace Caja___TalkLink.Forms
{
    partial class Reportes
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
            this.MCBTipoDocumento = new MaterialSkin.Controls.MaterialComboBox();
            this.Mtxtbx_Documento = new MaterialSkin.Controls.MaterialTextBox();
            this.mbtnConsultarReporte = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // MCBTipoDocumento
            // 
            this.MCBTipoDocumento.AutoResize = false;
            this.MCBTipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MCBTipoDocumento.Depth = 0;
            this.MCBTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MCBTipoDocumento.DropDownHeight = 174;
            this.MCBTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MCBTipoDocumento.DropDownWidth = 121;
            this.MCBTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MCBTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MCBTipoDocumento.FormattingEnabled = true;
            this.MCBTipoDocumento.Hint = "Tipo Documento";
            this.MCBTipoDocumento.IntegralHeight = false;
            this.MCBTipoDocumento.ItemHeight = 43;
            this.MCBTipoDocumento.Items.AddRange(new object[] {
            "Cédula",
            "Pasaporte"});
            this.MCBTipoDocumento.Location = new System.Drawing.Point(31, 42);
            this.MCBTipoDocumento.MaxDropDownItems = 4;
            this.MCBTipoDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.MCBTipoDocumento.Name = "MCBTipoDocumento";
            this.MCBTipoDocumento.Size = new System.Drawing.Size(228, 49);
            this.MCBTipoDocumento.StartIndex = 0;
            this.MCBTipoDocumento.TabIndex = 12;
            // 
            // Mtxtbx_Documento
            // 
            this.Mtxtbx_Documento.AnimateReadOnly = false;
            this.Mtxtbx_Documento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mtxtbx_Documento.Depth = 0;
            this.Mtxtbx_Documento.Enabled = false;
            this.Mtxtbx_Documento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Mtxtbx_Documento.Hint = "Documento";
            this.Mtxtbx_Documento.LeadingIcon = null;
            this.Mtxtbx_Documento.Location = new System.Drawing.Point(287, 42);
            this.Mtxtbx_Documento.MaxLength = 50;
            this.Mtxtbx_Documento.MouseState = MaterialSkin.MouseState.OUT;
            this.Mtxtbx_Documento.Multiline = false;
            this.Mtxtbx_Documento.Name = "Mtxtbx_Documento";
            this.Mtxtbx_Documento.Size = new System.Drawing.Size(228, 50);
            this.Mtxtbx_Documento.TabIndex = 11;
            this.Mtxtbx_Documento.Text = "";
            this.Mtxtbx_Documento.TrailingIcon = null;
            this.Mtxtbx_Documento.UseAccent = false;
            this.Mtxtbx_Documento.TextChanged += new System.EventHandler(this.Mtxtbx_Documento_TextChanged);
            // 
            // mbtnConsultarReporte
            // 
            this.mbtnConsultarReporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnConsultarReporte.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnConsultarReporte.Depth = 0;
            this.mbtnConsultarReporte.HighEmphasis = true;
            this.mbtnConsultarReporte.Icon = null;
            this.mbtnConsultarReporte.Location = new System.Drawing.Point(31, 112);
            this.mbtnConsultarReporte.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnConsultarReporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnConsultarReporte.Name = "mbtnConsultarReporte";
            this.mbtnConsultarReporte.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnConsultarReporte.Size = new System.Drawing.Size(173, 36);
            this.mbtnConsultarReporte.TabIndex = 13;
            this.mbtnConsultarReporte.Text = "Consultar reporte";
            this.mbtnConsultarReporte.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnConsultarReporte.UseAccentColor = false;
            this.mbtnConsultarReporte.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 523);
            this.Controls.Add(this.mbtnConsultarReporte);
            this.Controls.Add(this.MCBTipoDocumento);
            this.Controls.Add(this.Mtxtbx_Documento);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox MCBTipoDocumento;
        private MaterialSkin.Controls.MaterialTextBox Mtxtbx_Documento;
        private MaterialSkin.Controls.MaterialButton mbtnConsultarReporte;
    }
}