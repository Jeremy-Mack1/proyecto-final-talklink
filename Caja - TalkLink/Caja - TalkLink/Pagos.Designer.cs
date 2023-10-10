namespace Caja___TalkLink
{
    partial class Pagos
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
            this.txtbx_TipoDoc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtbx_Documento = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_DatosClientes = new System.Windows.Forms.Label();
            this.btn_verify = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pb_users = new FontAwesome.Sharp.IconPictureBox();
            this.materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_users)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbx_TipoDoc
            // 
            this.txtbx_TipoDoc.AnimateReadOnly = false;
            this.txtbx_TipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_TipoDoc.Depth = 0;
            this.txtbx_TipoDoc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_TipoDoc.Hint = "Tipo Documento";
            this.txtbx_TipoDoc.LeadingIcon = null;
            this.txtbx_TipoDoc.Location = new System.Drawing.Point(256, 88);
            this.txtbx_TipoDoc.MaxLength = 50;
            this.txtbx_TipoDoc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbx_TipoDoc.Multiline = false;
            this.txtbx_TipoDoc.Name = "txtbx_TipoDoc";
            this.txtbx_TipoDoc.Size = new System.Drawing.Size(228, 50);
            this.txtbx_TipoDoc.TabIndex = 3;
            this.txtbx_TipoDoc.Text = "";
            this.txtbx_TipoDoc.TrailingIcon = null;
            this.txtbx_TipoDoc.UseAccent = false;
            // 
            // txtbx_Documento
            // 
            this.txtbx_Documento.AnimateReadOnly = false;
            this.txtbx_Documento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Documento.Depth = 0;
            this.txtbx_Documento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Documento.Hint = "Documento";
            this.txtbx_Documento.LeadingIcon = null;
            this.txtbx_Documento.Location = new System.Drawing.Point(512, 88);
            this.txtbx_Documento.MaxLength = 50;
            this.txtbx_Documento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbx_Documento.Multiline = false;
            this.txtbx_Documento.Name = "txtbx_Documento";
            this.txtbx_Documento.Size = new System.Drawing.Size(228, 50);
            this.txtbx_Documento.TabIndex = 4;
            this.txtbx_Documento.Text = "";
            this.txtbx_Documento.TrailingIcon = null;
            this.txtbx_Documento.UseAccent = false;
            // 
            // lbl_DatosClientes
            // 
            this.lbl_DatosClientes.AutoSize = true;
            this.lbl_DatosClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DatosClientes.Location = new System.Drawing.Point(40, 33);
            this.lbl_DatosClientes.Name = "lbl_DatosClientes";
            this.lbl_DatosClientes.Size = new System.Drawing.Size(180, 23);
            this.lbl_DatosClientes.TabIndex = 5;
            this.lbl_DatosClientes.Text = "Datos del Cliente";
            // 
            // btn_verify
            // 
            this.btn_verify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_verify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_verify.Depth = 0;
            this.btn_verify.HighEmphasis = true;
            this.btn_verify.Icon = null;
            this.btn_verify.Location = new System.Drawing.Point(256, 163);
            this.btn_verify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_verify.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_verify.Size = new System.Drawing.Size(93, 36);
            this.btn_verify.TabIndex = 6;
            this.btn_verify.Text = "Verificar";
            this.btn_verify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_verify.UseAccentColor = false;
            this.btn_verify.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(256, 208);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(485, 10);
            this.materialDivider1.TabIndex = 7;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // pb_users
            // 
            this.pb_users.BackColor = System.Drawing.SystemColors.Control;
            this.pb_users.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pb_users.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pb_users.IconColor = System.Drawing.SystemColors.ControlText;
            this.pb_users.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_users.IconSize = 127;
            this.pb_users.Location = new System.Drawing.Point(57, 91);
            this.pb_users.Name = "pb_users";
            this.pb_users.Size = new System.Drawing.Size(127, 127);
            this.pb_users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_users.TabIndex = 9;
            this.pb_users.TabStop = false;
            // 
            // materialListBox1
            // 
            this.materialListBox1.BackColor = System.Drawing.Color.White;
            this.materialListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox1.Depth = 0;
            this.materialListBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBox1.Location = new System.Drawing.Point(38, 308);
            this.materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox1.Name = "materialListBox1";
            this.materialListBox1.SelectedIndex = -1;
            this.materialListBox1.SelectedItem = null;
            this.materialListBox1.Size = new System.Drawing.Size(311, 169);
            this.materialListBox1.TabIndex = 8;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 594);
            this.Controls.Add(this.pb_users);
            this.Controls.Add(this.materialListBox1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.lbl_DatosClientes);
            this.Controls.Add(this.txtbx_Documento);
            this.Controls.Add(this.txtbx_TipoDoc);
            this.Name = "Pagos";
            this.Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.pb_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtbx_TipoDoc;
        private MaterialSkin.Controls.MaterialTextBox txtbx_Documento;
        private System.Windows.Forms.Label lbl_DatosClientes;
        private MaterialSkin.Controls.MaterialButton btn_verify;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private FontAwesome.Sharp.IconPictureBox pb_users;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
    }
}