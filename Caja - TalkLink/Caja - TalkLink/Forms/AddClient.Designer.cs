namespace Caja___TalkLink
{
    partial class AddClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.Mtxbx_Nombre = new MaterialSkin.Controls.MaterialTextBox();
            this.Mtxbx_Apellido = new MaterialSkin.Controls.MaterialTextBox();
            this.MRB_Masculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.MRB_Femenino = new MaterialSkin.Controls.MaterialRadioButton();
            this.Mtxbx_FechaNacimiento = new MaterialSkin.Controls.MaterialTextBox();
            this.mbtnAgregarCliente = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mbtnConsultar = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtbx_Direccion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtbx_Estado = new MaterialSkin.Controls.MaterialTextBox();
            this.Mtxbx_TipoDocumento = new MaterialSkin.Controls.MaterialComboBox();
            this.mmtxtTelefono = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mmtxtTelefonoalt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.Mtxbx_Documento = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // Mtxbx_Nombre
            // 
            this.Mtxbx_Nombre.AnimateReadOnly = false;
            this.Mtxbx_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mtxbx_Nombre.Depth = 0;
            this.Mtxbx_Nombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Mtxbx_Nombre.Hint = "Nombre";
            this.Mtxbx_Nombre.LeadingIcon = null;
            this.Mtxbx_Nombre.Location = new System.Drawing.Point(28, 146);
            this.Mtxbx_Nombre.MaxLength = 50;
            this.Mtxbx_Nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.Mtxbx_Nombre.Multiline = false;
            this.Mtxbx_Nombre.Name = "Mtxbx_Nombre";
            this.Mtxbx_Nombre.Size = new System.Drawing.Size(165, 50);
            this.Mtxbx_Nombre.TabIndex = 3;
            this.Mtxbx_Nombre.Text = "";
            this.Mtxbx_Nombre.TrailingIcon = null;
            this.Mtxbx_Nombre.TextChanged += new System.EventHandler(this.Mtxbx_Nombre_TextChanged);
            this.Mtxbx_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloLetras);
            // 
            // Mtxbx_Apellido
            // 
            this.Mtxbx_Apellido.AnimateReadOnly = false;
            this.Mtxbx_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mtxbx_Apellido.Depth = 0;
            this.Mtxbx_Apellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Mtxbx_Apellido.Hint = "Apellido";
            this.Mtxbx_Apellido.LeadingIcon = null;
            this.Mtxbx_Apellido.Location = new System.Drawing.Point(217, 146);
            this.Mtxbx_Apellido.MaxLength = 50;
            this.Mtxbx_Apellido.MouseState = MaterialSkin.MouseState.OUT;
            this.Mtxbx_Apellido.Multiline = false;
            this.Mtxbx_Apellido.Name = "Mtxbx_Apellido";
            this.Mtxbx_Apellido.Size = new System.Drawing.Size(212, 50);
            this.Mtxbx_Apellido.TabIndex = 4;
            this.Mtxbx_Apellido.Text = "";
            this.Mtxbx_Apellido.TrailingIcon = null;
            this.Mtxbx_Apellido.TextChanged += new System.EventHandler(this.Mtxbx_Nombre_TextChanged);
            this.Mtxbx_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloLetras);
            // 
            // MRB_Masculino
            // 
            this.MRB_Masculino.AutoSize = true;
            this.MRB_Masculino.Depth = 0;
            this.MRB_Masculino.Location = new System.Drawing.Point(119, 462);
            this.MRB_Masculino.Margin = new System.Windows.Forms.Padding(0);
            this.MRB_Masculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MRB_Masculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.MRB_Masculino.Name = "MRB_Masculino";
            this.MRB_Masculino.Ripple = true;
            this.MRB_Masculino.Size = new System.Drawing.Size(109, 37);
            this.MRB_Masculino.TabIndex = 10;
            this.MRB_Masculino.TabStop = true;
            this.MRB_Masculino.Text = "Masculino";
            this.MRB_Masculino.UseVisualStyleBackColor = true;
            this.MRB_Masculino.CheckedChanged += new System.EventHandler(this.MRB_Masculino_CheckedChanged);
            // 
            // MRB_Femenino
            // 
            this.MRB_Femenino.AutoSize = true;
            this.MRB_Femenino.Depth = 0;
            this.MRB_Femenino.Location = new System.Drawing.Point(253, 462);
            this.MRB_Femenino.Margin = new System.Windows.Forms.Padding(0);
            this.MRB_Femenino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MRB_Femenino.MouseState = MaterialSkin.MouseState.HOVER;
            this.MRB_Femenino.Name = "MRB_Femenino";
            this.MRB_Femenino.Ripple = true;
            this.MRB_Femenino.Size = new System.Drawing.Size(105, 37);
            this.MRB_Femenino.TabIndex = 11;
            this.MRB_Femenino.TabStop = true;
            this.MRB_Femenino.Text = "Femenino";
            this.MRB_Femenino.UseVisualStyleBackColor = true;
            this.MRB_Femenino.CheckedChanged += new System.EventHandler(this.MRB_Masculino_CheckedChanged);
            // 
            // Mtxbx_FechaNacimiento
            // 
            this.Mtxbx_FechaNacimiento.AnimateReadOnly = false;
            this.Mtxbx_FechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mtxbx_FechaNacimiento.Depth = 0;
            this.Mtxbx_FechaNacimiento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Mtxbx_FechaNacimiento.Hint = "DD/MM/AA";
            this.Mtxbx_FechaNacimiento.LeadingIcon = null;
            this.Mtxbx_FechaNacimiento.Location = new System.Drawing.Point(28, 214);
            this.Mtxbx_FechaNacimiento.MaxLength = 50;
            this.Mtxbx_FechaNacimiento.MouseState = MaterialSkin.MouseState.OUT;
            this.Mtxbx_FechaNacimiento.Multiline = false;
            this.Mtxbx_FechaNacimiento.Name = "Mtxbx_FechaNacimiento";
            this.Mtxbx_FechaNacimiento.Size = new System.Drawing.Size(277, 50);
            this.Mtxbx_FechaNacimiento.TabIndex = 5;
            this.Mtxbx_FechaNacimiento.Text = "";
            this.Mtxbx_FechaNacimiento.TrailingIcon = null;
            this.Mtxbx_FechaNacimiento.TextChanged += new System.EventHandler(this.Mtxbx_Nombre_TextChanged);
            // 
            // mbtnAgregarCliente
            // 
            this.mbtnAgregarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAgregarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnAgregarCliente.Depth = 0;
            this.mbtnAgregarCliente.Enabled = false;
            this.mbtnAgregarCliente.HighEmphasis = true;
            this.mbtnAgregarCliente.Icon = null;
            this.mbtnAgregarCliente.Location = new System.Drawing.Point(155, 522);
            this.mbtnAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAgregarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAgregarCliente.Name = "mbtnAgregarCliente";
            this.mbtnAgregarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnAgregarCliente.Size = new System.Drawing.Size(150, 36);
            this.mbtnAgregarCliente.TabIndex = 12;
            this.mbtnAgregarCliente.Text = "Agregar Cliente";
            this.mbtnAgregarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnAgregarCliente.UseAccentColor = false;
            this.mbtnAgregarCliente.UseVisualStyleBackColor = true;
            this.mbtnAgregarCliente.Click += new System.EventHandler(this.mbtnAgregarCliente_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(531, 12);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(12, 535);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mbtnConsultar
            // 
            this.mbtnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnConsultar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnConsultar.Depth = 0;
            this.mbtnConsultar.HighEmphasis = true;
            this.mbtnConsultar.Icon = null;
            this.mbtnConsultar.Location = new System.Drawing.Point(28, 89);
            this.mbtnConsultar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnConsultar.Name = "mbtnConsultar";
            this.mbtnConsultar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnConsultar.Size = new System.Drawing.Size(106, 36);
            this.mbtnConsultar.TabIndex = 2;
            this.mbtnConsultar.Text = "Consultar";
            this.mbtnConsultar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnConsultar.UseAccentColor = false;
            this.mbtnConsultar.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buscar.png");
            // 
            // txtbx_Direccion
            // 
            this.txtbx_Direccion.AnimateReadOnly = false;
            this.txtbx_Direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Direccion.Depth = 0;
            this.txtbx_Direccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbx_Direccion.Hint = "Dirección";
            this.txtbx_Direccion.LeadingIcon = null;
            this.txtbx_Direccion.Location = new System.Drawing.Point(289, 310);
            this.txtbx_Direccion.MaxLength = 50;
            this.txtbx_Direccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbx_Direccion.Multiline = false;
            this.txtbx_Direccion.Name = "txtbx_Direccion";
            this.txtbx_Direccion.Size = new System.Drawing.Size(223, 50);
            this.txtbx_Direccion.TabIndex = 7;
            this.txtbx_Direccion.Text = "";
            this.txtbx_Direccion.TrailingIcon = null;
            this.txtbx_Direccion.TextChanged += new System.EventHandler(this.Mtxbx_Nombre_TextChanged);
            // 
            // txtbx_Estado
            // 
            this.txtbx_Estado.AnimateReadOnly = false;
            this.txtbx_Estado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Estado.Depth = 0;
            this.txtbx_Estado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbx_Estado.Hint = "Estado";
            this.txtbx_Estado.LeadingIcon = null;
            this.txtbx_Estado.Location = new System.Drawing.Point(289, 374);
            this.txtbx_Estado.MaxLength = 50;
            this.txtbx_Estado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbx_Estado.Multiline = false;
            this.txtbx_Estado.Name = "txtbx_Estado";
            this.txtbx_Estado.Size = new System.Drawing.Size(223, 50);
            this.txtbx_Estado.TabIndex = 9;
            this.txtbx_Estado.Text = "";
            this.txtbx_Estado.TrailingIcon = null;
            this.txtbx_Estado.TextChanged += new System.EventHandler(this.Mtxbx_Nombre_TextChanged);
            this.txtbx_Estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloLetras);
            // 
            // Mtxbx_TipoDocumento
            // 
            this.Mtxbx_TipoDocumento.AutoResize = false;
            this.Mtxbx_TipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Mtxbx_TipoDocumento.Depth = 0;
            this.Mtxbx_TipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Mtxbx_TipoDocumento.DropDownHeight = 174;
            this.Mtxbx_TipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mtxbx_TipoDocumento.DropDownWidth = 121;
            this.Mtxbx_TipoDocumento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxbx_TipoDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Mtxbx_TipoDocumento.FormattingEnabled = true;
            this.Mtxbx_TipoDocumento.Hint = "Tipo Documento";
            this.Mtxbx_TipoDocumento.IntegralHeight = false;
            this.Mtxbx_TipoDocumento.ItemHeight = 43;
            this.Mtxbx_TipoDocumento.Items.AddRange(new object[] {
            "Cédula",
            "Pasaporte"});
            this.Mtxbx_TipoDocumento.Location = new System.Drawing.Point(28, 30);
            this.Mtxbx_TipoDocumento.MaxDropDownItems = 4;
            this.Mtxbx_TipoDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.Mtxbx_TipoDocumento.Name = "Mtxbx_TipoDocumento";
            this.Mtxbx_TipoDocumento.Size = new System.Drawing.Size(165, 49);
            this.Mtxbx_TipoDocumento.StartIndex = -1;
            this.Mtxbx_TipoDocumento.TabIndex = 0;
            this.Mtxbx_TipoDocumento.SelectedIndexChanged += new System.EventHandler(this.Mtxbx_TipoDocumento_SelectedIndexChanged);
            // 
            // mmtxtTelefono
            // 
            this.mmtxtTelefono.AllowPromptAsInput = true;
            this.mmtxtTelefono.AnimateReadOnly = false;
            this.mmtxtTelefono.AsciiOnly = false;
            this.mmtxtTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtTelefono.BeepOnError = false;
            this.mmtxtTelefono.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtTelefono.Depth = 0;
            this.mmtxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mmtxtTelefono.HidePromptOnLeave = false;
            this.mmtxtTelefono.HideSelection = true;
            this.mmtxtTelefono.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtTelefono.LeadingIcon = null;
            this.mmtxtTelefono.Location = new System.Drawing.Point(28, 312);
            this.mmtxtTelefono.Mask = "000-000-0000";
            this.mmtxtTelefono.MaxLength = 32767;
            this.mmtxtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtTelefono.Name = "mmtxtTelefono";
            this.mmtxtTelefono.PasswordChar = '\0';
            this.mmtxtTelefono.PrefixSuffixText = null;
            this.mmtxtTelefono.PromptChar = '_';
            this.mmtxtTelefono.ReadOnly = false;
            this.mmtxtTelefono.RejectInputOnFirstFailure = false;
            this.mmtxtTelefono.ResetOnPrompt = true;
            this.mmtxtTelefono.ResetOnSpace = true;
            this.mmtxtTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtTelefono.SelectedText = "";
            this.mmtxtTelefono.SelectionLength = 0;
            this.mmtxtTelefono.SelectionStart = 0;
            this.mmtxtTelefono.ShortcutsEnabled = true;
            this.mmtxtTelefono.Size = new System.Drawing.Size(239, 48);
            this.mmtxtTelefono.SkipLiterals = true;
            this.mmtxtTelefono.TabIndex = 6;
            this.mmtxtTelefono.TabStop = false;
            this.mmtxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mmtxtTelefono.TrailingIcon = null;
            this.mmtxtTelefono.UseSystemPasswordChar = false;
            this.mmtxtTelefono.ValidatingType = null;
            this.mmtxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloNumeros);
            this.mmtxtTelefono.TextChanged += new System.EventHandler(this.Mtxbx_Nombre_TextChanged);
            // 
            // mmtxtTelefonoalt
            // 
            this.mmtxtTelefonoalt.AllowPromptAsInput = true;
            this.mmtxtTelefonoalt.AnimateReadOnly = false;
            this.mmtxtTelefonoalt.AsciiOnly = false;
            this.mmtxtTelefonoalt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtTelefonoalt.BeepOnError = false;
            this.mmtxtTelefonoalt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtTelefonoalt.Depth = 0;
            this.mmtxtTelefonoalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mmtxtTelefonoalt.HidePromptOnLeave = false;
            this.mmtxtTelefonoalt.HideSelection = true;
            this.mmtxtTelefonoalt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtTelefonoalt.LeadingIcon = null;
            this.mmtxtTelefonoalt.Location = new System.Drawing.Point(28, 376);
            this.mmtxtTelefonoalt.Mask = "000-000-0000";
            this.mmtxtTelefonoalt.MaxLength = 32767;
            this.mmtxtTelefonoalt.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtTelefonoalt.Name = "mmtxtTelefonoalt";
            this.mmtxtTelefonoalt.PasswordChar = '\0';
            this.mmtxtTelefonoalt.PrefixSuffixText = null;
            this.mmtxtTelefonoalt.PromptChar = '_';
            this.mmtxtTelefonoalt.ReadOnly = false;
            this.mmtxtTelefonoalt.RejectInputOnFirstFailure = false;
            this.mmtxtTelefonoalt.ResetOnPrompt = true;
            this.mmtxtTelefonoalt.ResetOnSpace = true;
            this.mmtxtTelefonoalt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtTelefonoalt.SelectedText = "";
            this.mmtxtTelefonoalt.SelectionLength = 0;
            this.mmtxtTelefonoalt.SelectionStart = 0;
            this.mmtxtTelefonoalt.ShortcutsEnabled = true;
            this.mmtxtTelefonoalt.Size = new System.Drawing.Size(239, 48);
            this.mmtxtTelefonoalt.SkipLiterals = true;
            this.mmtxtTelefonoalt.TabIndex = 8;
            this.mmtxtTelefonoalt.TabStop = false;
            this.mmtxtTelefonoalt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtTelefonoalt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mmtxtTelefonoalt.TrailingIcon = null;
            this.mmtxtTelefonoalt.UseSystemPasswordChar = false;
            this.mmtxtTelefonoalt.ValidatingType = null;
            this.mmtxtTelefonoalt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloNumeros);
            this.mmtxtTelefonoalt.TextChanged += new System.EventHandler(this.Mtxbx_Nombre_TextChanged);
            // 
            // Mtxbx_Documento
            // 
            this.Mtxbx_Documento.AllowPromptAsInput = true;
            this.Mtxbx_Documento.AnimateReadOnly = false;
            this.Mtxbx_Documento.AsciiOnly = false;
            this.Mtxbx_Documento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Mtxbx_Documento.BeepOnError = false;
            this.Mtxbx_Documento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.Mtxbx_Documento.Depth = 0;
            this.Mtxbx_Documento.Enabled = false;
            this.Mtxbx_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Mtxbx_Documento.HidePromptOnLeave = false;
            this.Mtxbx_Documento.HideSelection = true;
            this.Mtxbx_Documento.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Mtxbx_Documento.LeadingIcon = null;
            this.Mtxbx_Documento.Location = new System.Drawing.Point(217, 30);
            this.Mtxbx_Documento.Mask = "";
            this.Mtxbx_Documento.MaxLength = 32767;
            this.Mtxbx_Documento.MouseState = MaterialSkin.MouseState.OUT;
            this.Mtxbx_Documento.Name = "Mtxbx_Documento";
            this.Mtxbx_Documento.PasswordChar = '\0';
            this.Mtxbx_Documento.PrefixSuffixText = null;
            this.Mtxbx_Documento.PromptChar = '_';
            this.Mtxbx_Documento.ReadOnly = false;
            this.Mtxbx_Documento.RejectInputOnFirstFailure = false;
            this.Mtxbx_Documento.ResetOnPrompt = true;
            this.Mtxbx_Documento.ResetOnSpace = true;
            this.Mtxbx_Documento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mtxbx_Documento.SelectedText = "";
            this.Mtxbx_Documento.SelectionLength = 0;
            this.Mtxbx_Documento.SelectionStart = 0;
            this.Mtxbx_Documento.ShortcutsEnabled = true;
            this.Mtxbx_Documento.Size = new System.Drawing.Size(212, 48);
            this.Mtxbx_Documento.SkipLiterals = true;
            this.Mtxbx_Documento.TabIndex = 1;
            this.Mtxbx_Documento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Mtxbx_Documento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Mtxbx_Documento.TrailingIcon = null;
            this.Mtxbx_Documento.UseSystemPasswordChar = false;
            this.Mtxbx_Documento.ValidatingType = null;
            this.Mtxbx_Documento.TextChanged += new System.EventHandler(this.Mtxbx_Nombre_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(222, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Documento";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.Black;
            this.materialLabel2.Location = new System.Drawing.Point(27, 286);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Teléfono";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.Black;
            this.materialLabel3.Location = new System.Drawing.Point(27, 427);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(143, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Teléfono alternativo";
            // 
            // AddClient
            // 
            this.AcceptButton = this.mbtnAgregarCliente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 582);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Mtxbx_Documento);
            this.Controls.Add(this.mmtxtTelefonoalt);
            this.Controls.Add(this.mmtxtTelefono);
            this.Controls.Add(this.Mtxbx_TipoDocumento);
            this.Controls.Add(this.txtbx_Estado);
            this.Controls.Add(this.txtbx_Direccion);
            this.Controls.Add(this.mbtnConsultar);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.mbtnAgregarCliente);
            this.Controls.Add(this.Mtxbx_FechaNacimiento);
            this.Controls.Add(this.MRB_Femenino);
            this.Controls.Add(this.MRB_Masculino);
            this.Controls.Add(this.Mtxbx_Apellido);
            this.Controls.Add(this.Mtxbx_Nombre);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddClient";
            this.Text = "Registro de usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox Mtxbx_Nombre;
        private MaterialSkin.Controls.MaterialTextBox Mtxbx_Apellido;
        private MaterialSkin.Controls.MaterialRadioButton MRB_Masculino;
        private MaterialSkin.Controls.MaterialRadioButton MRB_Femenino;
        private MaterialSkin.Controls.MaterialTextBox Mtxbx_FechaNacimiento;
        private MaterialSkin.Controls.MaterialButton mbtnAgregarCliente;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton mbtnConsultar;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTextBox txtbx_Direccion;
        private MaterialSkin.Controls.MaterialTextBox txtbx_Estado;
        private MaterialSkin.Controls.MaterialComboBox Mtxbx_TipoDocumento;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtTelefono;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtTelefonoalt;
        private MaterialSkin.Controls.MaterialMaskedTextBox Mtxbx_Documento;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}