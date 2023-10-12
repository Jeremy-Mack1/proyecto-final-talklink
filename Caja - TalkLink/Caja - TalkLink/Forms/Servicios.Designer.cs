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
            this.components = new System.ComponentModel.Container();
            this.txtbx_NomServicio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtbx_Tarifa = new MaterialSkin.Controls.MaterialTextBox();
            this.dGVServicios = new System.Windows.Forms.DataGridView();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mbtnAgregaServicio = new MaterialSkin.Controls.MaterialButton();
            this.btn_EliminarServico = new MaterialSkin.Controls.MaterialButton();
            this.txtbxm_Descripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.tLDatabaseDataSet = new Caja___TalkLink.TLDatabaseDataSet();
            this.tLDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicosTableAdapter = new Caja___TalkLink.TLDatabaseDataSetTableAdapters.ServicosTableAdapter();
            this.iDServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
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
            // dGVServicios
            // 
            this.dGVServicios.AutoGenerateColumns = false;
            this.dGVServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDServicioDataGridViewTextBoxColumn,
            this.nombreServicioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.dGVServicios.DataSource = this.servicosBindingSource;
            this.dGVServicios.Location = new System.Drawing.Point(377, 110);
            this.dGVServicios.Name = "dGVServicios";
            this.dGVServicios.RowHeadersWidth = 51;
            this.dGVServicios.RowTemplate.Height = 24;
            this.dGVServicios.Size = new System.Drawing.Size(479, 353);
            this.dGVServicios.TabIndex = 5;
            this.dGVServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVServicios_CellContentClick);
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
            this.mbtnAgregaServicio.Click += new System.EventHandler(this.mbtnAgregaServicio_Click);
            // 
            // btn_EliminarServico
            // 
            this.btn_EliminarServico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_EliminarServico.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_EliminarServico.Depth = 0;
            this.btn_EliminarServico.Enabled = false;
            this.btn_EliminarServico.HighEmphasis = true;
            this.btn_EliminarServico.Icon = null;
            this.btn_EliminarServico.Location = new System.Drawing.Point(698, 32);
            this.btn_EliminarServico.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_EliminarServico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_EliminarServico.Name = "btn_EliminarServico";
            this.btn_EliminarServico.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_EliminarServico.Size = new System.Drawing.Size(156, 36);
            this.btn_EliminarServico.TabIndex = 4;
            this.btn_EliminarServico.Text = "Eliminar servicio";
            this.btn_EliminarServico.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_EliminarServico.UseAccentColor = false;
            this.btn_EliminarServico.UseVisualStyleBackColor = true;
            this.btn_EliminarServico.Click += new System.EventHandler(this.btn_EliminarServico_Click);
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
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeError.Location = new System.Drawing.Point(386, 78);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(280, 17);
            this.lblMensajeError.TabIndex = 20;
            this.lblMensajeError.Text = "Este servicio ya existe en la base de datos.";
            this.lblMensajeError.Visible = false;
            // 
            // tLDatabaseDataSet
            // 
            this.tLDatabaseDataSet.DataSetName = "TLDatabaseDataSet";
            this.tLDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tLDatabaseDataSetBindingSource
            // 
            this.tLDatabaseDataSetBindingSource.DataSource = this.tLDatabaseDataSet;
            this.tLDatabaseDataSetBindingSource.Position = 0;
            // 
            // servicosBindingSource
            // 
            this.servicosBindingSource.DataMember = "Servicos";
            this.servicosBindingSource.DataSource = this.tLDatabaseDataSetBindingSource;
            // 
            // servicosTableAdapter
            // 
            this.servicosTableAdapter.ClearBeforeFill = true;
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
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 485);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtbxm_Descripcion);
            this.Controls.Add(this.btn_EliminarServico);
            this.Controls.Add(this.mbtnAgregaServicio);
            this.Controls.Add(this.dGVServicios);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txtbx_Tarifa);
            this.Controls.Add(this.txtbx_NomServicio);
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtbx_NomServicio;
        private MaterialSkin.Controls.MaterialTextBox txtbx_Tarifa;
        private System.Windows.Forms.DataGridView dGVServicios;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton mbtnAgregaServicio;
        private MaterialSkin.Controls.MaterialButton btn_EliminarServico;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtbxm_Descripcion;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private System.Windows.Forms.Label lblMensajeError;
        private System.Windows.Forms.BindingSource tLDatabaseDataSetBindingSource;
        private TLDatabaseDataSet tLDatabaseDataSet;
        private System.Windows.Forms.BindingSource servicosBindingSource;
        private TLDatabaseDataSetTableAdapters.ServicosTableAdapter servicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
    }
}