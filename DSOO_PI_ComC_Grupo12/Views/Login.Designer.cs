namespace DSOO_PI_ComC_Grupo12.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelCreditos = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.lblDescripcion1 = new System.Windows.Forms.Label();
            this.picLogoMain = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkNuevoRegistro = new System.Windows.Forms.LinkLabel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnConfigBD = new System.Windows.Forms.Button();
            this.panelContrasenia = new System.Windows.Forms.Panel();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.picContrasenia = new System.Windows.Forms.PictureBox();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelCreditos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMain)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelContrasenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContrasenia)).BeginInit();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCreditos
            // 
            this.panelCreditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelCreditos.BackgroundImage = global::DSOO_PI_ComC_Grupo12.Properties.Resources.BGIzq;
            this.panelCreditos.Controls.Add(this.btnInfo);
            this.panelCreditos.Controls.Add(this.lblDescripcion2);
            this.panelCreditos.Controls.Add(this.lblDescripcion1);
            this.panelCreditos.Controls.Add(this.picLogoMain);
            this.panelCreditos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCreditos.Location = new System.Drawing.Point(0, 0);
            this.panelCreditos.Name = "panelCreditos";
            this.panelCreditos.Size = new System.Drawing.Size(350, 650);
            this.panelCreditos.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::DSOO_PI_ComC_Grupo12.Properties.Resources.information35;
            this.btnInfo.Location = new System.Drawing.Point(154, 608);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(36, 36);
            this.btnInfo.TabIndex = 9;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.btnInfo.MouseLeave += new System.EventHandler(this.btnInfo_MouseLeave);
            this.btnInfo.MouseHover += new System.EventHandler(this.btnInfo_MouseHover);
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion2.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion2.Location = new System.Drawing.Point(95, 345);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(154, 30);
            this.lblDescripcion2.TabIndex = 4;
            this.lblDescripcion2.Text = "de servicios";
            // 
            // lblDescripcion1
            // 
            this.lblDescripcion1.AutoSize = true;
            this.lblDescripcion1.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion1.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion1.Location = new System.Drawing.Point(53, 315);
            this.lblDescripcion1.Name = "lblDescripcion1";
            this.lblDescripcion1.Size = new System.Drawing.Size(238, 30);
            this.lblDescripcion1.TabIndex = 3;
            this.lblDescripcion1.Text = "Sistema de gestión";
            // 
            // picLogoMain
            // 
            this.picLogoMain.BackColor = System.Drawing.Color.Transparent;
            this.picLogoMain.Image = global::DSOO_PI_ComC_Grupo12.Properties.Resources.LogoMainV4;
            this.picLogoMain.Location = new System.Drawing.Point(45, 26);
            this.picLogoMain.Name = "picLogoMain";
            this.picLogoMain.Size = new System.Drawing.Size(255, 274);
            this.picLogoMain.TabIndex = 0;
            this.picLogoMain.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.linkNuevoRegistro);
            this.panelLogin.Controls.Add(this.btnSalir);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.btnConfigBD);
            this.panelLogin.Controls.Add(this.panelContrasenia);
            this.panelLogin.Controls.Add(this.panelUsuario);
            this.panelLogin.Controls.Add(this.lblTitulo);
            this.panelLogin.Controls.Add(this.btnClose);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(350, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(650, 650);
            this.panelLogin.TabIndex = 1;
            // 
            // linkNuevoRegistro
            // 
            this.linkNuevoRegistro.AutoSize = true;
            this.linkNuevoRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNuevoRegistro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.linkNuevoRegistro.Location = new System.Drawing.Point(235, 481);
            this.linkNuevoRegistro.Name = "linkNuevoRegistro";
            this.linkNuevoRegistro.Size = new System.Drawing.Size(192, 17);
            this.linkNuevoRegistro.TabIndex = 8;
            this.linkNuevoRegistro.TabStop = true;
            this.linkNuevoRegistro.Text = "Registrar una Nueva Cuenta";
            this.linkNuevoRegistro.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.linkNuevoRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNuevoRegistro_LinkClicked);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(357, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(226, 65);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(69, 384);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(226, 65);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "INGRESAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnConfigBD
            // 
            this.btnConfigBD.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigBD.FlatAppearance.BorderSize = 0;
            this.btnConfigBD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfigBD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfigBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigBD.Image = global::DSOO_PI_ComC_Grupo12.Properties.Resources.settingsV235;
            this.btnConfigBD.Location = new System.Drawing.Point(314, 608);
            this.btnConfigBD.Name = "btnConfigBD";
            this.btnConfigBD.Size = new System.Drawing.Size(35, 35);
            this.btnConfigBD.TabIndex = 5;
            this.btnConfigBD.UseVisualStyleBackColor = false;
            this.btnConfigBD.Click += new System.EventHandler(this.btnConfigBD_Click);
            this.btnConfigBD.MouseLeave += new System.EventHandler(this.btnConfigBD_MouseLeave);
            this.btnConfigBD.MouseHover += new System.EventHandler(this.btnConfigBD_MouseHover);
            // 
            // panelContrasenia
            // 
            this.panelContrasenia.BackColor = System.Drawing.Color.White;
            this.panelContrasenia.Controls.Add(this.txtContrasenia);
            this.panelContrasenia.Controls.Add(this.picContrasenia);
            this.panelContrasenia.Location = new System.Drawing.Point(0, 273);
            this.panelContrasenia.Name = "panelContrasenia";
            this.panelContrasenia.Size = new System.Drawing.Size(650, 55);
            this.panelContrasenia.TabIndex = 4;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(69, 13);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(569, 30);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // picContrasenia
            // 
            this.picContrasenia.Image = global::DSOO_PI_ComC_Grupo12.Properties.Resources.lock44;
            this.picContrasenia.Location = new System.Drawing.Point(7, 3);
            this.picContrasenia.Name = "picContrasenia";
            this.picContrasenia.Size = new System.Drawing.Size(46, 48);
            this.picContrasenia.TabIndex = 1;
            this.picContrasenia.TabStop = false;
            this.picContrasenia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picContrasenia_MouseClick);
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.White;
            this.panelUsuario.Controls.Add(this.txtUsuario);
            this.panelUsuario.Controls.Add(this.picUsuario);
            this.panelUsuario.Location = new System.Drawing.Point(0, 202);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(650, 55);
            this.panelUsuario.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(69, 13);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(569, 30);
            this.txtUsuario.TabIndex = 1;
            // 
            // picUsuario
            // 
            this.picUsuario.Image = global::DSOO_PI_ComC_Grupo12.Properties.Resources.user44;
            this.picUsuario.Location = new System.Drawing.Point(7, 4);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(46, 48);
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitulo.Location = new System.Drawing.Point(164, 95);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(324, 39);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Ingrese a su cuenta";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClose.Location = new System.Drawing.Point(613, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelCreditos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Deportivo - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelCreditos.ResumeLayout(false);
            this.panelCreditos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMain)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelContrasenia.ResumeLayout(false);
            this.panelContrasenia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContrasenia)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreditos;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox picLogoMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelContrasenia;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Label lblDescripcion1;
        private System.Windows.Forms.Label lblDescripcion2;
        private System.Windows.Forms.Button btnConfigBD;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.PictureBox picContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.LinkLabel linkNuevoRegistro;
        private System.Windows.Forms.Button btnInfo;
    }
}