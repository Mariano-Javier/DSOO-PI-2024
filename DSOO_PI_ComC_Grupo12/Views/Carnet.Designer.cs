namespace DSOO_PI_ComC_Grupo12.Views
{
    partial class Carnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carnet));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtClienteIDoDNI = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupOpcionesBusqueda = new System.Windows.Forms.GroupBox();
            this.radioID = new System.Windows.Forms.RadioButton();
            this.radioDNI = new System.Windows.Forms.RadioButton();
            this.groupOpcionesCarnet = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultadoBusqueda = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panelCarnet = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDniCarnet = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblEmailCarnet = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTelCarnet = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblIdCarnet = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombreApellidoCarnet = new System.Windows.Forms.Label();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblEstadoCarnet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblEsApto = new System.Windows.Forms.Label();
            this.panelBuscar.SuspendLayout();
            this.groupOpcionesBusqueda.SuspendLayout();
            this.groupOpcionesCarnet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCarnet.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitulo.Location = new System.Drawing.Point(261, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 33);
            this.lblTitulo.TabIndex = 57;
            this.lblTitulo.Text = "Carnet Cliente";
            // 
            // txtClienteIDoDNI
            // 
            this.txtClienteIDoDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClienteIDoDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteIDoDNI.Location = new System.Drawing.Point(2, 7);
            this.txtClienteIDoDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtClienteIDoDNI.Name = "txtClienteIDoDNI";
            this.txtClienteIDoDNI.Size = new System.Drawing.Size(222, 16);
            this.txtClienteIDoDNI.TabIndex = 88;
            this.txtClienteIDoDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(244, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 30);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.White;
            this.panelBuscar.Controls.Add(this.txtClienteIDoDNI);
            this.panelBuscar.Location = new System.Drawing.Point(12, 26);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(226, 30);
            this.panelBuscar.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(9, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(720, 22);
            this.label2.TabIndex = 95;
            this.label2.Text = "_______________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(720, 22);
            this.label3.TabIndex = 96;
            this.label3.Text = "_______________________________________________________________________";
            // 
            // groupOpcionesBusqueda
            // 
            this.groupOpcionesBusqueda.Controls.Add(this.radioID);
            this.groupOpcionesBusqueda.Controls.Add(this.radioDNI);
            this.groupOpcionesBusqueda.Controls.Add(this.panelBuscar);
            this.groupOpcionesBusqueda.Controls.Add(this.btnBuscar);
            this.groupOpcionesBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOpcionesBusqueda.Location = new System.Drawing.Point(12, 48);
            this.groupOpcionesBusqueda.Name = "groupOpcionesBusqueda";
            this.groupOpcionesBusqueda.Size = new System.Drawing.Size(350, 108);
            this.groupOpcionesBusqueda.TabIndex = 98;
            this.groupOpcionesBusqueda.TabStop = false;
            this.groupOpcionesBusqueda.Text = "Opciones de Búsqueda";
            // 
            // radioID
            // 
            this.radioID.AutoSize = true;
            this.radioID.Checked = true;
            this.radioID.Location = new System.Drawing.Point(76, 69);
            this.radioID.Margin = new System.Windows.Forms.Padding(2);
            this.radioID.Name = "radioID";
            this.radioID.Size = new System.Drawing.Size(39, 21);
            this.radioID.TabIndex = 20;
            this.radioID.TabStop = true;
            this.radioID.Text = "ID";
            this.radioID.UseVisualStyleBackColor = false;
            this.radioID.CheckedChanged += new System.EventHandler(this.radioID_CheckedChanged);
            // 
            // radioDNI
            // 
            this.radioDNI.AutoSize = true;
            this.radioDNI.Location = new System.Drawing.Point(128, 69);
            this.radioDNI.Margin = new System.Windows.Forms.Padding(2);
            this.radioDNI.Name = "radioDNI";
            this.radioDNI.Size = new System.Drawing.Size(49, 21);
            this.radioDNI.TabIndex = 21;
            this.radioDNI.TabStop = true;
            this.radioDNI.Text = "DNI";
            this.radioDNI.UseVisualStyleBackColor = true;
            this.radioDNI.CheckedChanged += new System.EventHandler(this.radioDNI_CheckedChanged);
            // 
            // groupOpcionesCarnet
            // 
            this.groupOpcionesCarnet.Controls.Add(this.panel1);
            this.groupOpcionesCarnet.Controls.Add(this.btnGenerar);
            this.groupOpcionesCarnet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOpcionesCarnet.Location = new System.Drawing.Point(373, 48);
            this.groupOpcionesCarnet.Name = "groupOpcionesCarnet";
            this.groupOpcionesCarnet.Size = new System.Drawing.Size(350, 108);
            this.groupOpcionesCarnet.TabIndex = 99;
            this.groupOpcionesCarnet.TabStop = false;
            this.groupOpcionesCarnet.Text = "Opciones del Carnet";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblResultadoBusqueda);
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 30);
            this.panel1.TabIndex = 84;
            // 
            // lblResultadoBusqueda
            // 
            this.lblResultadoBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultadoBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lblResultadoBusqueda.Name = "lblResultadoBusqueda";
            this.lblResultadoBusqueda.Size = new System.Drawing.Size(338, 30);
            this.lblResultadoBusqueda.TabIndex = 0;
            this.lblResultadoBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(126, 69);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(95, 30);
            this.btnGenerar.TabIndex = 85;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(299, 610);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 30);
            this.btnLimpiar.TabIndex = 102;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(440, 610);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(135, 30);
            this.btnCerrar.TabIndex = 101;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(158, 610);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(135, 30);
            this.btnImprimir.TabIndex = 100;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panelCarnet
            // 
            this.panelCarnet.BackgroundImage = global::DSOO_PI_ComC_Grupo12.Properties.Resources.BCSoc;
            this.panelCarnet.Controls.Add(this.panel9);
            this.panelCarnet.Controls.Add(this.panel7);
            this.panelCarnet.Controls.Add(this.panel6);
            this.panelCarnet.Controls.Add(this.panel5);
            this.panelCarnet.Controls.Add(this.panel4);
            this.panelCarnet.Controls.Add(this.panel3);
            this.panelCarnet.Controls.Add(this.panel2);
            this.panelCarnet.Location = new System.Drawing.Point(13, 231);
            this.panelCarnet.Name = "panelCarnet";
            this.panelCarnet.Size = new System.Drawing.Size(710, 350);
            this.panelCarnet.TabIndex = 103;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.lblVencimiento);
            this.panel7.ForeColor = System.Drawing.Color.Transparent;
            this.panel7.Location = new System.Drawing.Point(330, 165);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(241, 20);
            this.panel7.TabIndex = 6;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblVencimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVencimiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblVencimiento.Location = new System.Drawing.Point(0, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(241, 20);
            this.lblVencimiento.TabIndex = 0;
            this.lblVencimiento.Text = "Vencimiento: 18/11/2026";
            this.lblVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.lblDniCarnet);
            this.panel6.ForeColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(330, 188);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 20);
            this.panel6.TabIndex = 5;
            // 
            // lblDniCarnet
            // 
            this.lblDniCarnet.BackColor = System.Drawing.Color.Transparent;
            this.lblDniCarnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDniCarnet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCarnet.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblDniCarnet.Location = new System.Drawing.Point(0, 0);
            this.lblDniCarnet.Name = "lblDniCarnet";
            this.lblDniCarnet.Size = new System.Drawing.Size(241, 20);
            this.lblDniCarnet.TabIndex = 0;
            this.lblDniCarnet.Text = "DNI: 43434243";
            this.lblDniCarnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lblEmailCarnet);
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(330, 256);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 20);
            this.panel5.TabIndex = 4;
            // 
            // lblEmailCarnet
            // 
            this.lblEmailCarnet.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCarnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmailCarnet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCarnet.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblEmailCarnet.Location = new System.Drawing.Point(0, 0);
            this.lblEmailCarnet.Name = "lblEmailCarnet";
            this.lblEmailCarnet.Size = new System.Drawing.Size(241, 20);
            this.lblEmailCarnet.TabIndex = 0;
            this.lblEmailCarnet.Text = "marianojavier@example.com";
            this.lblEmailCarnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblTelCarnet);
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(330, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 20);
            this.panel4.TabIndex = 3;
            // 
            // lblTelCarnet
            // 
            this.lblTelCarnet.BackColor = System.Drawing.Color.Transparent;
            this.lblTelCarnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTelCarnet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelCarnet.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblTelCarnet.Location = new System.Drawing.Point(0, 0);
            this.lblTelCarnet.Name = "lblTelCarnet";
            this.lblTelCarnet.Size = new System.Drawing.Size(241, 20);
            this.lblTelCarnet.TabIndex = 0;
            this.lblTelCarnet.Text = "Tel: 677889900";
            this.lblTelCarnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblIdCarnet);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(330, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 30);
            this.panel3.TabIndex = 2;
            // 
            // lblIdCarnet
            // 
            this.lblIdCarnet.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCarnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIdCarnet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCarnet.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblIdCarnet.Location = new System.Drawing.Point(0, 0);
            this.lblIdCarnet.Name = "lblIdCarnet";
            this.lblIdCarnet.Size = new System.Drawing.Size(241, 30);
            this.lblIdCarnet.TabIndex = 0;
            this.lblIdCarnet.Text = "ID: 33";
            this.lblIdCarnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblNombreApellidoCarnet);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(330, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 30);
            this.panel2.TabIndex = 1;
            // 
            // lblNombreApellidoCarnet
            // 
            this.lblNombreApellidoCarnet.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreApellidoCarnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreApellidoCarnet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellidoCarnet.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblNombreApellidoCarnet.Location = new System.Drawing.Point(0, 0);
            this.lblNombreApellidoCarnet.Name = "lblNombreApellidoCarnet";
            this.lblNombreApellidoCarnet.Size = new System.Drawing.Size(241, 30);
            this.lblNombreApellidoCarnet.TabIndex = 0;
            this.lblNombreApellidoCarnet.Text = "Mariano Javier";
            this.lblNombreApellidoCarnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.lblEstadoCarnet);
            this.panel8.Location = new System.Drawing.Point(198, 176);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(338, 30);
            this.panel8.TabIndex = 104;
            // 
            // lblEstadoCarnet
            // 
            this.lblEstadoCarnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCarnet.Location = new System.Drawing.Point(0, 0);
            this.lblEstadoCarnet.Name = "lblEstadoCarnet";
            this.lblEstadoCarnet.Size = new System.Drawing.Size(338, 30);
            this.lblEstadoCarnet.TabIndex = 0;
            this.lblEstadoCarnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(9, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 22);
            this.label1.TabIndex = 105;
            this.label1.Text = "_______________________________________________________________________";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.lblEsApto);
            this.panel9.ForeColor = System.Drawing.Color.Transparent;
            this.panel9.Location = new System.Drawing.Point(330, 233);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(241, 20);
            this.panel9.TabIndex = 7;
            // 
            // lblEsApto
            // 
            this.lblEsApto.BackColor = System.Drawing.Color.Transparent;
            this.lblEsApto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEsApto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsApto.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblEsApto.Location = new System.Drawing.Point(0, 0);
            this.lblEsApto.Name = "lblEsApto";
            this.lblEsApto.Size = new System.Drawing.Size(241, 20);
            this.lblEsApto.TabIndex = 0;
            this.lblEsApto.Text = "Apto Físico: Si";
            this.lblEsApto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Carnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 650);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panelCarnet);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupOpcionesCarnet);
            this.Controls.Add(this.groupOpcionesBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carnet";
            this.Text = "Carnet";
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.groupOpcionesBusqueda.ResumeLayout(false);
            this.groupOpcionesBusqueda.PerformLayout();
            this.groupOpcionesCarnet.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCarnet.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtClienteIDoDNI;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupOpcionesBusqueda;
        private System.Windows.Forms.RadioButton radioID;
        private System.Windows.Forms.RadioButton radioDNI;
        private System.Windows.Forms.GroupBox groupOpcionesCarnet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblResultadoBusqueda;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panelCarnet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombreApellidoCarnet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblIdCarnet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblEmailCarnet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTelCarnet;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDniCarnet;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblEstadoCarnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblEsApto;
    }
}