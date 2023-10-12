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
            this.MtxbxTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.MtxbxTelefonoAlt = new MaterialSkin.Controls.MaterialTextBox();
            this.Mtxbx_Documento = new MaterialSkin.Controls.MaterialTextBox();
            this.tLDatabaseDataSet = new Caja___TalkLink.TLDatabaseDataSet();
            this.mbtn_EditarCliente = new MaterialSkin.Controls.MaterialButton();
            this.lblErrorClienteNoExiste = new System.Windows.Forms.Label();
            this.servicosTableAdapter = new Caja___TalkLink.TLDatabaseDataSetTableAdapters.ServicosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tLDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
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
            this.mbtnAgregarCliente.HighEmphasis = true;
            this.mbtnAgregarCliente.Icon = null;
            this.mbtnAgregarCliente.Location = new System.Drawing.Point(78, 522);
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
            this.materialDivider1.Size = new System.Drawing.Size(12, 558);
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
            this.mbtnConsultar.Click += new System.EventHandler(this.mbtnConsultar_Click);
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
            this.Mtxbx_TipoDocumento.StartIndex = 0;
            this.Mtxbx_TipoDocumento.TabIndex = 0;
            this.Mtxbx_TipoDocumento.SelectedIndexChanged += new System.EventHandler(this.Mtxbx_TipoDocumento_SelectedIndexChanged);
            // 
            // MtxbxTelefono
            // 
            this.MtxbxTelefono.AnimateReadOnly = false;
            this.MtxbxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtxbxTelefono.Depth = 0;
            this.MtxbxTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MtxbxTelefono.Hint = "Teléfono";
            this.MtxbxTelefono.LeadingIcon = null;
            this.MtxbxTelefono.Location = new System.Drawing.Point(34, 310);
            this.MtxbxTelefono.MaxLength = 10;
            this.MtxbxTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.MtxbxTelefono.Multiline = false;
            this.MtxbxTelefono.Name = "MtxbxTelefono";
            this.MtxbxTelefono.Size = new System.Drawing.Size(224, 50);
            this.MtxbxTelefono.TabIndex = 14;
            this.MtxbxTelefono.Text = "";
            this.MtxbxTelefono.TrailingIcon = null;
            this.MtxbxTelefono.TextChanged += new System.EventHandler(this.Mtxbx_Nombre_TextChanged);
            this.MtxbxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloNumeros);
            // 
            // MtxbxTelefonoAlt
            // 
            this.MtxbxTelefonoAlt.AnimateReadOnly = false;
            this.MtxbxTelefonoAlt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtxbxTelefonoAlt.Depth = 0;
            this.MtxbxTelefonoAlt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MtxbxTelefonoAlt.Hint = "Teléfono Alternativo";
            this.MtxbxTelefonoAlt.LeadingIcon = null;
            this.MtxbxTelefonoAlt.Location = new System.Drawing.Point(34, 374);
            this.MtxbxTelefonoAlt.MaxLength = 10;
            this.MtxbxTelefonoAlt.MouseState = MaterialSkin.MouseState.OUT;
            this.MtxbxTelefonoAlt.Multiline = false;
            this.MtxbxTelefonoAlt.Name = "MtxbxTelefonoAlt";
            this.MtxbxTelefonoAlt.Size = new System.Drawing.Size(218, 50);
            this.MtxbxTelefonoAlt.TabIndex = 15;
            this.MtxbxTelefonoAlt.Text = "";
            this.MtxbxTelefonoAlt.TrailingIcon = null;
            this.MtxbxTelefonoAlt.TextChanged += new System.EventHandler(this.Mtxbx_Nombre_TextChanged);
            this.MtxbxTelefonoAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloNumeros);
            // 
            // Mtxbx_Documento
            // 
            this.Mtxbx_Documento.AnimateReadOnly = false;
            this.Mtxbx_Documento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mtxbx_Documento.Depth = 0;
            this.Mtxbx_Documento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Mtxbx_Documento.Hint = "Documento";
            this.Mtxbx_Documento.LeadingIcon = null;
            this.Mtxbx_Documento.Location = new System.Drawing.Point(217, 31);
            this.Mtxbx_Documento.MaxLength = 50;
            this.Mtxbx_Documento.MouseState = MaterialSkin.MouseState.OUT;
            this.Mtxbx_Documento.Multiline = false;
            this.Mtxbx_Documento.Name = "Mtxbx_Documento";
            this.Mtxbx_Documento.Size = new System.Drawing.Size(212, 50);
            this.Mtxbx_Documento.TabIndex = 16;
            this.Mtxbx_Documento.Text = "";
            this.Mtxbx_Documento.TrailingIcon = null;
            this.Mtxbx_Documento.TextChanged += new System.EventHandler(this.Mtxbx_Nombre_TextChanged);
            // 
            // tLDatabaseDataSet
            // 
            this.tLDatabaseDataSet.DataSetName = "TLDatabaseDataSet";
            this.tLDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mbtn_EditarCliente
            // 
            this.mbtn_EditarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtn_EditarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtn_EditarCliente.Depth = 0;
            this.mbtn_EditarCliente.HighEmphasis = true;
            this.mbtn_EditarCliente.Icon = null;
            this.mbtn_EditarCliente.Location = new System.Drawing.Point(289, 522);
            this.mbtn_EditarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtn_EditarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtn_EditarCliente.Name = "mbtn_EditarCliente";
            this.mbtn_EditarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtn_EditarCliente.Size = new System.Drawing.Size(133, 36);
            this.mbtn_EditarCliente.TabIndex = 18;
            this.mbtn_EditarCliente.Text = "Editar Cliente";
            this.mbtn_EditarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtn_EditarCliente.UseAccentColor = false;
            this.mbtn_EditarCliente.UseVisualStyleBackColor = true;
            // 
            // lblErrorClienteNoExiste
            // 
            this.lblErrorClienteNoExiste.AutoSize = true;
            this.lblErrorClienteNoExiste.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClienteNoExiste.Location = new System.Drawing.Point(158, 108);
            this.lblErrorClienteNoExiste.Name = "lblErrorClienteNoExiste";
            this.lblErrorClienteNoExiste.Size = new System.Drawing.Size(128, 17);
            this.lblErrorClienteNoExiste.TabIndex = 19;
            this.lblErrorClienteNoExiste.Text = "El Cliente no existe";
            this.lblErrorClienteNoExiste.Visible = false;
            // 
            // servicosTableAdapter
            // 
            this.servicosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDServicioDataGridViewTextBoxColumn,
            this.nombreServicioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servicosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(614, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(482, 410);
            this.dataGridView1.TabIndex = 20;
            // 
            // servicosBindingSource
            // 
            this.servicosBindingSource.DataMember = "Servicos";
            this.servicosBindingSource.DataSource = this.tLDatabaseDataSet;
            // 
            // iDServicioDataGridViewTextBoxColumn
            // 
            this.iDServicioDataGridViewTextBoxColumn.DataPropertyName = "IDServicio";
            this.iDServicioDataGridViewTextBoxColumn.HeaderText = "IDServicio";
            this.iDServicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDServicioDataGridViewTextBoxColumn.Name = "iDServicioDataGridViewTextBoxColumn";
            this.iDServicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDServicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreServicioDataGridViewTextBoxColumn
            // 
            this.nombreServicioDataGridViewTextBoxColumn.DataPropertyName = "NombreServicio";
            this.nombreServicioDataGridViewTextBoxColumn.HeaderText = "NombreServicio";
            this.nombreServicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreServicioDataGridViewTextBoxColumn.Name = "nombreServicioDataGridViewTextBoxColumn";
            this.nombreServicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.Width = 125;
            // 
            // AddClient
            // 
            this.AcceptButton = this.mbtnAgregarCliente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1179, 608);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblErrorClienteNoExiste);
            this.Controls.Add(this.mbtn_EditarCliente);
            this.Controls.Add(this.Mtxbx_Documento);
            this.Controls.Add(this.MtxbxTelefonoAlt);
            this.Controls.Add(this.MtxbxTelefono);
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
            this.Load += new System.EventHandler(this.AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tLDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).EndInit();
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
        private MaterialSkin.Controls.MaterialTextBox MtxbxTelefono;
        private MaterialSkin.Controls.MaterialTextBox MtxbxTelefonoAlt;
        private MaterialSkin.Controls.MaterialTextBox Mtxbx_Documento;
        private MaterialSkin.Controls.MaterialButton mbtn_EditarCliente;
        private System.Windows.Forms.Label lblErrorClienteNoExiste;
        private TLDatabaseDataSet tLDatabaseDataSet;
        private TLDatabaseDataSetTableAdapters.ServicosTableAdapter servicosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource servicosBindingSource;
    }
}