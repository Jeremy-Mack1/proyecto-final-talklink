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
            this.Mtxtbx_Documento = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_DatosClientes = new System.Windows.Forms.Label();
            this.btn_verify = new MaterialSkin.Controls.MaterialButton();
            this.pb_users = new FontAwesome.Sharp.IconPictureBox();
            this.MCBTipoDocumento = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.MTxTMontoDebido = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDatosaPagar = new System.Windows.Forms.Label();
            this.MtxtMontoPagar = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MBtnConfirmarPago = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tLDatabaseDataSet = new Caja___TalkLink.TLDatabaseDataSet();
            this.dGVServicios = new System.Windows.Forms.DataGridView();
            this.servicosTableAdapter = new Caja___TalkLink.TLDatabaseDataSetTableAdapters.ServicosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pb_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVServicios)).BeginInit();
            this.SuspendLayout();
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
            this.Mtxtbx_Documento.Location = new System.Drawing.Point(527, 97);
            this.Mtxtbx_Documento.MaxLength = 50;
            this.Mtxtbx_Documento.MouseState = MaterialSkin.MouseState.OUT;
            this.Mtxtbx_Documento.Multiline = false;
            this.Mtxtbx_Documento.Name = "Mtxtbx_Documento";
            this.Mtxtbx_Documento.Size = new System.Drawing.Size(228, 50);
            this.Mtxtbx_Documento.TabIndex = 4;
            this.Mtxtbx_Documento.Text = "";
            this.Mtxtbx_Documento.TrailingIcon = null;
            this.Mtxtbx_Documento.UseAccent = false;
            this.Mtxtbx_Documento.TextChanged += new System.EventHandler(this.Mtxtbx_Documento_TextChanged);
            // 
            // lbl_DatosClientes
            // 
            this.lbl_DatosClientes.AutoSize = true;
            this.lbl_DatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DatosClientes.Location = new System.Drawing.Point(55, 42);
            this.lbl_DatosClientes.Name = "lbl_DatosClientes";
            this.lbl_DatosClientes.Size = new System.Drawing.Size(177, 25);
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
            this.btn_verify.Location = new System.Drawing.Point(271, 174);
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
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // pb_users
            // 
            this.pb_users.BackColor = System.Drawing.SystemColors.Control;
            this.pb_users.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pb_users.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pb_users.IconColor = System.Drawing.SystemColors.ControlText;
            this.pb_users.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_users.IconSize = 127;
            this.pb_users.Location = new System.Drawing.Point(72, 100);
            this.pb_users.Name = "pb_users";
            this.pb_users.Size = new System.Drawing.Size(127, 127);
            this.pb_users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_users.TabIndex = 9;
            this.pb_users.TabStop = false;
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
            this.MCBTipoDocumento.Location = new System.Drawing.Point(271, 97);
            this.MCBTipoDocumento.MaxDropDownItems = 4;
            this.MCBTipoDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.MCBTipoDocumento.Name = "MCBTipoDocumento";
            this.MCBTipoDocumento.Size = new System.Drawing.Size(228, 49);
            this.MCBTipoDocumento.StartIndex = 0;
            this.MCBTipoDocumento.TabIndex = 10;
            this.MCBTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.MCBTipoDocumento_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(57, 264);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Servicios";
            // 
            // MTxTMontoDebido
            // 
            this.MTxTMontoDebido.AnimateReadOnly = false;
            this.MTxTMontoDebido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTxTMontoDebido.Depth = 0;
            this.MTxTMontoDebido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTxTMontoDebido.Hint = "Monto debido";
            this.MTxTMontoDebido.LeadingIcon = null;
            this.MTxTMontoDebido.Location = new System.Drawing.Point(504, 340);
            this.MTxTMontoDebido.MaxLength = 50;
            this.MTxTMontoDebido.MouseState = MaterialSkin.MouseState.OUT;
            this.MTxTMontoDebido.Multiline = false;
            this.MTxTMontoDebido.Name = "MTxTMontoDebido";
            this.MTxTMontoDebido.ReadOnly = true;
            this.MTxTMontoDebido.Size = new System.Drawing.Size(268, 50);
            this.MTxTMontoDebido.TabIndex = 12;
            this.MTxTMontoDebido.Text = "";
            this.MTxTMontoDebido.TrailingIcon = null;
            // 
            // lblDatosaPagar
            // 
            this.lblDatosaPagar.AutoSize = true;
            this.lblDatosaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDatosaPagar.Location = new System.Drawing.Point(579, 286);
            this.lblDatosaPagar.Name = "lblDatosaPagar";
            this.lblDatosaPagar.Size = new System.Drawing.Size(108, 18);
            this.lblDatosaPagar.TabIndex = 13;
            this.lblDatosaPagar.Text = "Datos del pago";
            // 
            // MtxtMontoPagar
            // 
            this.MtxtMontoPagar.AnimateReadOnly = false;
            this.MtxtMontoPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtxtMontoPagar.Depth = 0;
            this.MtxtMontoPagar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MtxtMontoPagar.Hint = "Monto a pagar por el servicio";
            this.MtxtMontoPagar.LeadingIcon = null;
            this.MtxtMontoPagar.Location = new System.Drawing.Point(504, 423);
            this.MtxtMontoPagar.MaxLength = 50;
            this.MtxtMontoPagar.MouseState = MaterialSkin.MouseState.OUT;
            this.MtxtMontoPagar.Multiline = false;
            this.MtxtMontoPagar.Name = "MtxtMontoPagar";
            this.MtxtMontoPagar.Size = new System.Drawing.Size(268, 50);
            this.MtxtMontoPagar.TabIndex = 14;
            this.MtxtMontoPagar.Text = "";
            this.MtxtMontoPagar.TrailingIcon = null;
            this.MtxtMontoPagar.TextChanged += new System.EventHandler(this.MtxtMontoPagar_TextChanged);
            this.MtxtMontoPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirNumerosDecimales);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Monto a pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Importe a digitalizar";
            // 
            // MBtnConfirmarPago
            // 
            this.MBtnConfirmarPago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MBtnConfirmarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MBtnConfirmarPago.Depth = 0;
            this.MBtnConfirmarPago.Enabled = false;
            this.MBtnConfirmarPago.HighEmphasis = true;
            this.MBtnConfirmarPago.Icon = null;
            this.MBtnConfirmarPago.Location = new System.Drawing.Point(504, 499);
            this.MBtnConfirmarPago.Margin = new System.Windows.Forms.Padding(8, 6, 4, 6);
            this.MBtnConfirmarPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.MBtnConfirmarPago.Name = "MBtnConfirmarPago";
            this.MBtnConfirmarPago.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MBtnConfirmarPago.Size = new System.Drawing.Size(210, 36);
            this.MBtnConfirmarPago.TabIndex = 17;
            this.MBtnConfirmarPago.Text = "Confirmar transacción";
            this.MBtnConfirmarPago.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MBtnConfirmarPago.UseAccentColor = false;
            this.MBtnConfirmarPago.UseVisualStyleBackColor = true;
            this.MBtnConfirmarPago.Click += new System.EventHandler(this.MBtnConfirmarPago_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(270, 231);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(485, 10);
            this.materialDivider1.TabIndex = 7;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // tLDatabaseDataSet
            // 
            this.tLDatabaseDataSet.DataSetName = "TLDatabaseDataSet";
            this.tLDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dGVServicios
            // 
            this.dGVServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVServicios.Location = new System.Drawing.Point(22, 286);
            this.dGVServicios.Name = "dGVServicios";
            this.dGVServicios.RowHeadersWidth = 51;
            this.dGVServicios.RowTemplate.Height = 24;
            this.dGVServicios.Size = new System.Drawing.Size(442, 280);
            this.dGVServicios.TabIndex = 18;
            // 
            // servicosTableAdapter
            // 
            this.servicosTableAdapter.ClearBeforeFill = true;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 587);
            this.Controls.Add(this.dGVServicios);
            this.Controls.Add(this.MBtnConfirmarPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MtxtMontoPagar);
            this.Controls.Add(this.lblDatosaPagar);
            this.Controls.Add(this.MTxTMontoDebido);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.MCBTipoDocumento);
            this.Controls.Add(this.pb_users);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.lbl_DatosClientes);
            this.Controls.Add(this.Mtxtbx_Documento);
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox Mtxtbx_Documento;
        private System.Windows.Forms.Label lbl_DatosClientes;
        private MaterialSkin.Controls.MaterialButton btn_verify;
        private FontAwesome.Sharp.IconPictureBox pb_users;
        private MaterialSkin.Controls.MaterialComboBox MCBTipoDocumento;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox MTxTMontoDebido;
        private System.Windows.Forms.Label lblDatosaPagar;
        private MaterialSkin.Controls.MaterialTextBox MtxtMontoPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton MBtnConfirmarPago;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private TLDatabaseDataSet tLDatabaseDataSet;
        private System.Windows.Forms.DataGridView dGVServicios;
        private TLDatabaseDataSetTableAdapters.ServicosTableAdapter servicosTableAdapter;
    }
}