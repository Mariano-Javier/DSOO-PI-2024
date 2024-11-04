namespace DSOO_PI_ComC_Grupo12.Views
{
    partial class RegistrarCuota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridResumen = new System.Windows.Forms.DataGridView();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateFechaPago = new System.Windows.Forms.DateTimePicker();
            this.panelDNI = new System.Windows.Forms.Panel();
            this.lblDNI = new System.Windows.Forms.Label();
            this.panelNombreApellido = new System.Windows.Forms.Panel();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblTituloTotal = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.panelBuscarCliente = new System.Windows.Forms.Panel();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.groupOpcionesPago = new System.Windows.Forms.GroupBox();
            this.radioCuota6 = new System.Windows.Forms.RadioButton();
            this.radioEfectivo = new System.Windows.Forms.RadioButton();
            this.radioCuota3 = new System.Windows.Forms.RadioButton();
            this.groupActividades = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxMesSus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateDiaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblTituloDNI = new System.Windows.Forms.Label();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTipoSocio = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxTipoSocio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBuscarStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResumen)).BeginInit();
            this.panel6.SuspendLayout();
            this.panelDNI.SuspendLayout();
            this.panelNombreApellido.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelBuscarCliente.SuspendLayout();
            this.groupOpcionesPago.SuspendLayout();
            this.groupActividades.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxTipoSocio.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridResumen
            // 
            this.dataGridResumen.AllowUserToAddRows = false;
            this.dataGridResumen.AllowUserToDeleteRows = false;
            this.dataGridResumen.BackgroundColor = System.Drawing.Color.White;
            this.dataGridResumen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actividad,
            this.Precio});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridResumen.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridResumen.Location = new System.Drawing.Point(12, 434);
            this.dataGridResumen.Name = "dataGridResumen";
            this.dataGridResumen.ReadOnly = true;
            this.dataGridResumen.RowHeadersVisible = false;
            this.dataGridResumen.Size = new System.Drawing.Size(422, 150);
            this.dataGridResumen.TabIndex = 116;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            this.Actividad.Width = 300;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(440, 608);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 30);
            this.btnLimpiar.TabIndex = 115;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dateFechaPago);
            this.panel6.Location = new System.Drawing.Point(440, 216);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 30);
            this.panel6.TabIndex = 103;
            // 
            // dateFechaPago
            // 
            this.dateFechaPago.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaPago.Location = new System.Drawing.Point(5, 4);
            this.dateFechaPago.Margin = new System.Windows.Forms.Padding(2);
            this.dateFechaPago.Name = "dateFechaPago";
            this.dateFechaPago.Size = new System.Drawing.Size(273, 22);
            this.dateFechaPago.TabIndex = 53;
            this.dateFechaPago.Value = new System.DateTime(2024, 10, 19, 2, 59, 15, 0);
            // 
            // panelDNI
            // 
            this.panelDNI.BackColor = System.Drawing.Color.White;
            this.panelDNI.Controls.Add(this.lblDNI);
            this.panelDNI.Location = new System.Drawing.Point(293, 216);
            this.panelDNI.Name = "panelDNI";
            this.panelDNI.Size = new System.Drawing.Size(140, 30);
            this.panelDNI.TabIndex = 102;
            // 
            // lblDNI
            // 
            this.lblDNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(0, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(140, 30);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNombreApellido
            // 
            this.panelNombreApellido.BackColor = System.Drawing.Color.White;
            this.panelNombreApellido.Controls.Add(this.lblNombreApellido);
            this.panelNombreApellido.Location = new System.Drawing.Point(15, 216);
            this.panelNombreApellido.Name = "panelNombreApellido";
            this.panelNombreApellido.Size = new System.Drawing.Size(272, 30);
            this.panelNombreApellido.TabIndex = 101;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(0, 0);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(272, 30);
            this.lblNombreApellido.TabIndex = 91;
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloTotal
            // 
            this.lblTituloTotal.AutoSize = true;
            this.lblTituloTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotal.Location = new System.Drawing.Point(442, 534);
            this.lblTituloTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloTotal.Name = "lblTituloTotal";
            this.lblTituloTotal.Size = new System.Drawing.Size(95, 17);
            this.lblTituloTotal.TabIndex = 111;
            this.lblTituloTotal.Text = "Total a Pagar";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.White;
            this.panelTotal.Controls.Add(this.lblTotalPagar);
            this.panelTotal.Location = new System.Drawing.Point(440, 554);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(281, 30);
            this.panelTotal.TabIndex = 110;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPagar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(0, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(281, 30);
            this.lblTotalPagar.TabIndex = 0;
            this.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBuscarCliente
            // 
            this.panelBuscarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.panelBuscarCliente.Controls.Add(this.label7);
            this.panelBuscarCliente.Controls.Add(this.panel3);
            this.panelBuscarCliente.Controls.Add(this.txtClienteID);
            this.panelBuscarCliente.Controls.Add(this.lblSubtitulo);
            this.panelBuscarCliente.Controls.Add(this.lblClienteID);
            this.panelBuscarCliente.Controls.Add(this.btnBuscar);
            this.panelBuscarCliente.Controls.Add(this.panelBuscar);
            this.panelBuscarCliente.Location = new System.Drawing.Point(0, 54);
            this.panelBuscarCliente.Name = "panelBuscarCliente";
            this.panelBuscarCliente.Size = new System.Drawing.Size(735, 91);
            this.panelBuscarCliente.TabIndex = 109;
            // 
            // txtClienteID
            // 
            this.txtClienteID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClienteID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteID.Location = new System.Drawing.Point(19, 56);
            this.txtClienteID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(165, 16);
            this.txtClienteID.TabIndex = 88;
            this.txtClienteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(302, -1);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(140, 22);
            this.lblSubtitulo.TabIndex = 87;
            this.lblSubtitulo.Text = "Buscar Cliente";
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteID.Location = new System.Drawing.Point(17, 29);
            this.lblClienteID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(71, 17);
            this.lblClienteID.TabIndex = 83;
            this.lblClienteID.Text = "Cliente ID";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(192, 49);
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
            this.panelBuscar.Location = new System.Drawing.Point(15, 49);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(171, 30);
            this.panelBuscar.TabIndex = 84;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblDetalle.Location = new System.Drawing.Point(291, 156);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(168, 22);
            this.lblDetalle.TabIndex = 108;
            this.lblDetalle.Text = "Detalles del Pago";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(581, 608);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(135, 30);
            this.btnCerrar.TabIndex = 107;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnComprobante
            // 
            this.btnComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnComprobante.FlatAppearance.BorderSize = 0;
            this.btnComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobante.ForeColor = System.Drawing.Color.White;
            this.btnComprobante.Location = new System.Drawing.Point(299, 608);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(135, 30);
            this.btnComprobante.TabIndex = 106;
            this.btnComprobante.Text = "COMPROBANTE";
            this.btnComprobante.UseVisualStyleBackColor = false;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(158, 608);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(135, 30);
            this.btnPagar.TabIndex = 105;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // groupOpcionesPago
            // 
            this.groupOpcionesPago.Controls.Add(this.radioCuota6);
            this.groupOpcionesPago.Controls.Add(this.radioEfectivo);
            this.groupOpcionesPago.Controls.Add(this.radioCuota3);
            this.groupOpcionesPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOpcionesPago.Location = new System.Drawing.Point(12, 372);
            this.groupOpcionesPago.Name = "groupOpcionesPago";
            this.groupOpcionesPago.Size = new System.Drawing.Size(711, 50);
            this.groupOpcionesPago.TabIndex = 104;
            this.groupOpcionesPago.TabStop = false;
            this.groupOpcionesPago.Text = "Opciones de Pago";
            // 
            // radioCuota6
            // 
            this.radioCuota6.AutoSize = true;
            this.radioCuota6.Location = new System.Drawing.Point(433, 19);
            this.radioCuota6.Margin = new System.Windows.Forms.Padding(2);
            this.radioCuota6.Name = "radioCuota6";
            this.radioCuota6.Size = new System.Drawing.Size(131, 21);
            this.radioCuota6.TabIndex = 22;
            this.radioCuota6.TabStop = true;
            this.radioCuota6.Text = "Tarjeta 6 Cuotas";
            this.radioCuota6.UseVisualStyleBackColor = true;
            this.radioCuota6.CheckedChanged += new System.EventHandler(this.radioCuota6_CheckedChanged);
            // 
            // radioEfectivo
            // 
            this.radioEfectivo.AutoSize = true;
            this.radioEfectivo.Checked = true;
            this.radioEfectivo.Location = new System.Drawing.Point(158, 19);
            this.radioEfectivo.Margin = new System.Windows.Forms.Padding(2);
            this.radioEfectivo.Name = "radioEfectivo";
            this.radioEfectivo.Size = new System.Drawing.Size(78, 21);
            this.radioEfectivo.TabIndex = 20;
            this.radioEfectivo.TabStop = true;
            this.radioEfectivo.Text = "Efectivo";
            this.radioEfectivo.UseVisualStyleBackColor = false;
            this.radioEfectivo.CheckedChanged += new System.EventHandler(this.radioEfectivo_CheckedChanged);
            // 
            // radioCuota3
            // 
            this.radioCuota3.AutoSize = true;
            this.radioCuota3.Location = new System.Drawing.Point(269, 19);
            this.radioCuota3.Margin = new System.Windows.Forms.Padding(2);
            this.radioCuota3.Name = "radioCuota3";
            this.radioCuota3.Size = new System.Drawing.Size(131, 21);
            this.radioCuota3.TabIndex = 21;
            this.radioCuota3.TabStop = true;
            this.radioCuota3.Text = "Tarjeta 3 Cuotas";
            this.radioCuota3.UseVisualStyleBackColor = true;
            this.radioCuota3.CheckedChanged += new System.EventHandler(this.radioCuota3_CheckedChanged);
            // 
            // groupActividades
            // 
            this.groupActividades.Controls.Add(this.label4);
            this.groupActividades.Controls.Add(this.panel2);
            this.groupActividades.Controls.Add(this.label3);
            this.groupActividades.Controls.Add(this.panel1);
            this.groupActividades.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupActividades.Location = new System.Drawing.Point(12, 268);
            this.groupActividades.Name = "groupActividades";
            this.groupActividades.Size = new System.Drawing.Size(422, 100);
            this.groupActividades.TabIndex = 100;
            this.groupActividades.TabStop = false;
            this.groupActividades.Text = "Mes / Periodo a Pagar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "Meses de Suscripción";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBoxMesSus);
            this.panel2.Location = new System.Drawing.Point(216, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 30);
            this.panel2.TabIndex = 99;
            // 
            // comboBoxMesSus
            // 
            this.comboBoxMesSus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMesSus.FormattingEnabled = true;
            this.comboBoxMesSus.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMesSus.Location = new System.Drawing.Point(3, 3);
            this.comboBoxMesSus.Name = "comboBoxMesSus";
            this.comboBoxMesSus.Size = new System.Drawing.Size(194, 25);
            this.comboBoxMesSus.TabIndex = 0;
            this.comboBoxMesSus.SelectedIndexChanged += new System.EventHandler(this.comboBoxMesSus_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 98;
            this.label3.Text = "Fecha Inicio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateDiaInicio);
            this.panel1.Location = new System.Drawing.Point(10, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 97;
            // 
            // dateDiaInicio
            // 
            this.dateDiaInicio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDiaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDiaInicio.Location = new System.Drawing.Point(3, 4);
            this.dateDiaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateDiaInicio.Name = "dateDiaInicio";
            this.dateDiaInicio.Size = new System.Drawing.Size(194, 22);
            this.dateDiaInicio.TabIndex = 53;
            this.dateDiaInicio.Value = new System.DateTime(2024, 10, 19, 2, 59, 15, 0);
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.Location = new System.Drawing.Point(440, 196);
            this.lblFechaPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(107, 17);
            this.lblFechaPago.TabIndex = 99;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblTituloDNI
            // 
            this.lblTituloDNI.AutoSize = true;
            this.lblTituloDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDNI.Location = new System.Drawing.Point(290, 196);
            this.lblTituloDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloDNI.Name = "lblTituloDNI";
            this.lblTituloDNI.Size = new System.Drawing.Size(31, 17);
            this.lblTituloDNI.TabIndex = 98;
            this.lblTituloDNI.Text = "DNI";
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombre.Location = new System.Drawing.Point(17, 196);
            this.lblTituloNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(128, 17);
            this.lblTituloNombre.TabIndex = 97;
            this.lblTituloNombre.Text = "Nombre y Apellido";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(17, 608);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(135, 30);
            this.btnCalcular.TabIndex = 96;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitulo.Location = new System.Drawing.Point(263, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 33);
            this.lblTitulo.TabIndex = 95;
            this.lblTitulo.Text = "Registrar Cuota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(8, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(720, 22);
            this.label5.TabIndex = 112;
            this.label5.Text = "_______________________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(10, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 22);
            this.label1.TabIndex = 113;
            this.label1.Text = "_______________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(720, 22);
            this.label2.TabIndex = 114;
            this.label2.Text = "_______________________________________________________________________";
            // 
            // groupBoxTipoSocio
            // 
            this.groupBoxTipoSocio.Controls.Add(this.label6);
            this.groupBoxTipoSocio.Controls.Add(this.panel4);
            this.groupBoxTipoSocio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTipoSocio.Location = new System.Drawing.Point(440, 268);
            this.groupBoxTipoSocio.Name = "groupBoxTipoSocio";
            this.groupBoxTipoSocio.Size = new System.Drawing.Size(283, 100);
            this.groupBoxTipoSocio.TabIndex = 117;
            this.groupBoxTipoSocio.TabStop = false;
            this.groupBoxTipoSocio.Text = "Concepto a Pagar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 100;
            this.label6.Text = "Tipo de Cuota";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.comboBoxTipoSocio);
            this.panel4.Location = new System.Drawing.Point(10, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 30);
            this.panel4.TabIndex = 97;
            // 
            // comboBoxTipoSocio
            // 
            this.comboBoxTipoSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoSocio.FormattingEnabled = true;
            this.comboBoxTipoSocio.Items.AddRange(new object[] {
            "Regular",
            "Premium"});
            this.comboBoxTipoSocio.Location = new System.Drawing.Point(3, 3);
            this.comboBoxTipoSocio.Name = "comboBoxTipoSocio";
            this.comboBoxTipoSocio.Size = new System.Drawing.Size(260, 25);
            this.comboBoxTipoSocio.TabIndex = 0;
            this.comboBoxTipoSocio.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoSocio_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 92;
            this.label7.Text = "Estado del Cliente";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblBuscarStatus);
            this.panel3.Location = new System.Drawing.Point(440, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 30);
            this.panel3.TabIndex = 91;
            // 
            // lblBuscarStatus
            // 
            this.lblBuscarStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBuscarStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarStatus.Location = new System.Drawing.Point(0, 0);
            this.lblBuscarStatus.Name = "lblBuscarStatus";
            this.lblBuscarStatus.Size = new System.Drawing.Size(281, 30);
            this.lblBuscarStatus.TabIndex = 0;
            this.lblBuscarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 650);
            this.Controls.Add(this.groupBoxTipoSocio);
            this.Controls.Add(this.dataGridResumen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelDNI);
            this.Controls.Add(this.panelNombreApellido);
            this.Controls.Add(this.lblTituloTotal);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelBuscarCliente);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnComprobante);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.groupOpcionesPago);
            this.Controls.Add(this.groupActividades);
            this.Controls.Add(this.lblFechaPago);
            this.Controls.Add(this.lblTituloDNI);
            this.Controls.Add(this.lblTituloNombre);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarCuota";
            this.Text = "Registrar Cuota";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResumen)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panelDNI.ResumeLayout(false);
            this.panelNombreApellido.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelBuscarCliente.ResumeLayout(false);
            this.panelBuscarCliente.PerformLayout();
            this.groupOpcionesPago.ResumeLayout(false);
            this.groupOpcionesPago.PerformLayout();
            this.groupActividades.ResumeLayout(false);
            this.groupActividades.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxTipoSocio.ResumeLayout(false);
            this.groupBoxTipoSocio.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridResumen;
        public System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        public System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.DateTimePicker dateFechaPago;
        public System.Windows.Forms.Panel panelDNI;
        public System.Windows.Forms.Label lblDNI;
        public System.Windows.Forms.Panel panelNombreApellido;
        public System.Windows.Forms.Label lblNombreApellido;
        public System.Windows.Forms.Label lblTituloTotal;
        public System.Windows.Forms.Panel panelTotal;
        public System.Windows.Forms.Label lblTotalPagar;
        public System.Windows.Forms.Panel panelBuscarCliente;
        public System.Windows.Forms.TextBox txtClienteID;
        public System.Windows.Forms.Label lblSubtitulo;
        public System.Windows.Forms.Label lblClienteID;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Panel panelBuscar;
        public System.Windows.Forms.Label lblDetalle;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnComprobante;
        public System.Windows.Forms.Button btnPagar;
        public System.Windows.Forms.GroupBox groupOpcionesPago;
        public System.Windows.Forms.RadioButton radioCuota6;
        public System.Windows.Forms.RadioButton radioEfectivo;
        public System.Windows.Forms.RadioButton radioCuota3;
        public System.Windows.Forms.GroupBox groupActividades;
        public System.Windows.Forms.Label lblFechaPago;
        public System.Windows.Forms.Label lblTituloDNI;
        public System.Windows.Forms.Label lblTituloNombre;
        public System.Windows.Forms.Button btnCalcular;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dateDiaInicio;
        public System.Windows.Forms.GroupBox groupBoxTipoSocio;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.ComboBox comboBoxTipoSocio;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboBoxMesSus;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblBuscarStatus;
    }
}