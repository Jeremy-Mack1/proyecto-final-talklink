namespace Caja___TalkLink
{
    partial class Login__TalkLink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login__TalkLink));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.txtbx_Usuario = new System.Windows.Forms.TextBox();
            this.txtbx_Pass = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btn_Acceder = new System.Windows.Forms.Button();
            this.lklbl_RecuperarContraseña = new System.Windows.Forms.LinkLabel();
            this.pb_Cerrar = new System.Windows.Forms.PictureBox();
            this.pb_Minimizar = new System.Windows.Forms.PictureBox();
            this.pb_NoVisible = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NoVisible)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pb_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 396);
            this.panel1.TabIndex = 0;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(0, 0);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(419, 363);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            this.pb_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Logo_MouseDown);
            // 
            // txtbx_Usuario
            // 
            this.txtbx_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(121)))));
            this.txtbx_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Usuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Usuario.ForeColor = System.Drawing.Color.White;
            this.txtbx_Usuario.Location = new System.Drawing.Point(546, 103);
            this.txtbx_Usuario.Name = "txtbx_Usuario";
            this.txtbx_Usuario.Size = new System.Drawing.Size(328, 21);
            this.txtbx_Usuario.TabIndex = 1;
            this.txtbx_Usuario.Text = "Usuario";
            this.txtbx_Usuario.TextChanged += new System.EventHandler(this.txtbx_Usuario_TextChanged);
            this.txtbx_Usuario.Enter += new System.EventHandler(this.txtbx_Usuario_Enter);
            this.txtbx_Usuario.Leave += new System.EventHandler(this.txtbx_Usuario_Leave);
            // 
            // txtbx_Pass
            // 
            this.txtbx_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(121)))));
            this.txtbx_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Pass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Pass.ForeColor = System.Drawing.Color.White;
            this.txtbx_Pass.Location = new System.Drawing.Point(546, 184);
            this.txtbx_Pass.Name = "txtbx_Pass";
            this.txtbx_Pass.Size = new System.Drawing.Size(328, 21);
            this.txtbx_Pass.TabIndex = 2;
            this.txtbx_Pass.Text = "Contraseña";
            this.txtbx_Pass.Enter += new System.EventHandler(this.txtbx_Pass_Enter);
            this.txtbx_Pass.Leave += new System.EventHandler(this.txtbx_Pass_Leave);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(121)))));
            this.lbl_Login.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.White;
            this.lbl_Login.Location = new System.Drawing.Point(641, 31);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(103, 34);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "LOGIN";
            // 
            // btn_Acceder
            // 
            this.btn_Acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(0)))), ((int)(((byte)(196)))));
            this.btn_Acceder.FlatAppearance.BorderSize = 0;
            this.btn_Acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btn_Acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btn_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acceder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acceder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Acceder.Location = new System.Drawing.Point(465, 271);
            this.btn_Acceder.Name = "btn_Acceder";
            this.btn_Acceder.Size = new System.Drawing.Size(473, 40);
            this.btn_Acceder.TabIndex = 3;
            this.btn_Acceder.Text = "Acceder";
            this.btn_Acceder.UseVisualStyleBackColor = false;
            this.btn_Acceder.Click += new System.EventHandler(this.btn_Acceder_Click);
            // 
            // lklbl_RecuperarContraseña
            // 
            this.lklbl_RecuperarContraseña.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lklbl_RecuperarContraseña.AutoSize = true;
            this.lklbl_RecuperarContraseña.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklbl_RecuperarContraseña.ForeColor = System.Drawing.Color.White;
            this.lklbl_RecuperarContraseña.LinkColor = System.Drawing.Color.White;
            this.lklbl_RecuperarContraseña.Location = new System.Drawing.Point(574, 324);
            this.lklbl_RecuperarContraseña.Name = "lklbl_RecuperarContraseña";
            this.lklbl_RecuperarContraseña.Size = new System.Drawing.Size(260, 21);
            this.lklbl_RecuperarContraseña.TabIndex = 0;
            this.lklbl_RecuperarContraseña.TabStop = true;
            this.lklbl_RecuperarContraseña.Text = "¿has olvidado la contraseña?";
            // 
            // pb_Cerrar
            // 
            this.pb_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(121)))));
            this.pb_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("pb_Cerrar.Image")));
            this.pb_Cerrar.Location = new System.Drawing.Point(974, 4);
            this.pb_Cerrar.Name = "pb_Cerrar";
            this.pb_Cerrar.Size = new System.Drawing.Size(18, 14);
            this.pb_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cerrar.TabIndex = 6;
            this.pb_Cerrar.TabStop = false;
            this.pb_Cerrar.Click += new System.EventHandler(this.pb_Cerrar_Click);
            // 
            // pb_Minimizar
            // 
            this.pb_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(121)))));
            this.pb_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("pb_Minimizar.Image")));
            this.pb_Minimizar.Location = new System.Drawing.Point(938, 6);
            this.pb_Minimizar.Name = "pb_Minimizar";
            this.pb_Minimizar.Size = new System.Drawing.Size(30, 12);
            this.pb_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Minimizar.TabIndex = 7;
            this.pb_Minimizar.TabStop = false;
            this.pb_Minimizar.Click += new System.EventHandler(this.pb_Minimizar_Click);
            // 
            // pb_NoVisible
            // 
            this.pb_NoVisible.Image = ((System.Drawing.Image)(resources.GetObject("pb_NoVisible.Image")));
            this.pb_NoVisible.Location = new System.Drawing.Point(880, 181);
            this.pb_NoVisible.Name = "pb_NoVisible";
            this.pb_NoVisible.Size = new System.Drawing.Size(24, 24);
            this.pb_NoVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_NoVisible.TabIndex = 8;
            this.pb_NoVisible.TabStop = false;
            this.pb_NoVisible.Click += new System.EventHandler(this.pb_NoVisible_Click);
            this.pb_NoVisible.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_NoVisible_MouseDown);
            this.pb_NoVisible.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_NoVisible_MouseUp);
            // 
            // Login__TalkLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(1007, 396);
            this.Controls.Add(this.pb_NoVisible);
            this.Controls.Add(this.pb_Minimizar);
            this.Controls.Add(this.pb_Cerrar);
            this.Controls.Add(this.lklbl_RecuperarContraseña);
            this.Controls.Add(this.btn_Acceder);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.txtbx_Pass);
            this.Controls.Add(this.txtbx_Usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login__TalkLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login__TalkLink";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login__TalkLink_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NoVisible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbx_Usuario;
        private System.Windows.Forms.TextBox txtbx_Pass;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Button btn_Acceder;
        private System.Windows.Forms.LinkLabel lklbl_RecuperarContraseña;
        private System.Windows.Forms.PictureBox pb_Cerrar;
        private System.Windows.Forms.PictureBox pb_Minimizar;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.PictureBox pb_NoVisible;
    }
}