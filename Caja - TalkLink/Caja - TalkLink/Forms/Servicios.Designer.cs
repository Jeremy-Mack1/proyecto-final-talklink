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
            this.btn_ConsultarServicios = new FontAwesome.Sharp.IconButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // btn_ConsultarServicios
            // 
            this.btn_ConsultarServicios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ConsultarServicios.IconColor = System.Drawing.Color.Black;
            this.btn_ConsultarServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ConsultarServicios.Location = new System.Drawing.Point(77, 45);
            this.btn_ConsultarServicios.Name = "btn_ConsultarServicios";
            this.btn_ConsultarServicios.Size = new System.Drawing.Size(161, 55);
            this.btn_ConsultarServicios.TabIndex = 0;
            this.btn_ConsultarServicios.Text = "Consultar Servicios";
            this.btn_ConsultarServicios.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(77, 136);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(304, 291);
            this.materialListView1.TabIndex = 13;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 485);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.btn_ConsultarServicios);
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_ConsultarServicios;
        private MaterialSkin.Controls.MaterialListView materialListView1;
    }
}