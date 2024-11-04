namespace DSOO_PI_ComC_Grupo12.Views
{
    partial class RegistrarPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupOpcionesPago = new System.Windows.Forms.GroupBox();
            this.radioCuota6 = new System.Windows.Forms.RadioButton();
            this.radioEfectivo = new System.Windows.Forms.RadioButton();
            this.radioCuota3 = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateFechaPago = new System.Windows.Forms.DateTimePicker();
            this.panelDNI = new System.Windows.Forms.Panel();
            this.lblDNI = new System.Windows.Forms.Label();
            this.panelNombreApellido = new System.Windows.Forms.Panel();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.groupActividades = new System.Windows.Forms.GroupBox();
            this.dataGridSelecActi = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblTituloDNI = new System.Windows.Forms.Label();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblTituloTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.panelBuscarCliente = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBuscarStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dataGridResumen = new System.Windows.Forms.DataGridView();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDiaSeleccionado = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupOpcionesPago.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelDNI.SuspendLayout();
            this.panelNombreApellido.SuspendLayout();
            this.groupActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecActi)).BeginInit();
            this.panelTotal.SuspendLayout();
            this.panelBuscarCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResumen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitulo.Location = new System.Drawing.Point(275, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 33);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "Registrar Pago";
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
            this.btnCalcular.TabIndex = 64;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupOpcionesPago
            // 
            this.groupOpcionesPago.Controls.Add(this.radioCuota6);
            this.groupOpcionesPago.Controls.Add(this.radioEfectivo);
            this.groupOpcionesPago.Controls.Add(this.radioCuota3);
            this.groupOpcionesPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOpcionesPago.Location = new System.Drawing.Point(15, 302);
            this.groupOpcionesPago.Name = "groupOpcionesPago";
            this.groupOpcionesPago.Size = new System.Drawing.Size(271, 97);
            this.groupOpcionesPago.TabIndex = 78;
            this.groupOpcionesPago.TabStop = false;
            this.groupOpcionesPago.Text = "Opciones de Pago";
            // 
            // radioCuota6
            // 
            this.radioCuota6.AutoSize = true;
            this.radioCuota6.Location = new System.Drawing.Point(9, 67);
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
            this.radioEfectivo.Location = new System.Drawing.Point(9, 19);
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
            this.radioCuota3.Location = new System.Drawing.Point(9, 42);
            this.radioCuota3.Margin = new System.Windows.Forms.Padding(2);
            this.radioCuota3.Name = "radioCuota3";
            this.radioCuota3.Size = new System.Drawing.Size(131, 21);
            this.radioCuota3.TabIndex = 21;
            this.radioCuota3.TabStop = true;
            this.radioCuota3.Text = "Tarjeta 3 Cuotas";
            this.radioCuota3.UseVisualStyleBackColor = true;
            this.radioCuota3.CheckedChanged += new System.EventHandler(this.radioCuota3_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dateFechaPago);
            this.panel6.Location = new System.Drawing.Point(440, 198);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 30);
            this.panel6.TabIndex = 77;
            // 
            // dateFechaPago
            // 
            this.dateFechaPago.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaPago.Location = new System.Drawing.Point(4, 4);
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
            this.panelDNI.Location = new System.Drawing.Point(294, 198);
            this.panelDNI.Name = "panelDNI";
            this.panelDNI.Size = new System.Drawing.Size(140, 30);
            this.panelDNI.TabIndex = 74;
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
            this.panelNombreApellido.Location = new System.Drawing.Point(15, 198);
            this.panelNombreApellido.Name = "panelNombreApellido";
            this.panelNombreApellido.Size = new System.Drawing.Size(273, 30);
            this.panelNombreApellido.TabIndex = 72;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(0, 0);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(273, 30);
            this.lblNombreApellido.TabIndex = 91;
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupActividades
            // 
            this.groupActividades.Controls.Add(this.dataGridSelecActi);
            this.groupActividades.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupActividades.Location = new System.Drawing.Point(292, 238);
            this.groupActividades.Name = "groupActividades";
            this.groupActividades.Size = new System.Drawing.Size(431, 161);
            this.groupActividades.TabIndex = 71;
            this.groupActividades.TabStop = false;
            this.groupActividades.Text = "Actividades a Pagar";
            // 
            // dataGridSelecActi
            // 
            this.dataGridSelecActi.AllowUserToAddRows = false;
            this.dataGridSelecActi.AllowUserToDeleteRows = false;
            this.dataGridSelecActi.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSelecActi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSelecActi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSelecActi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelecActi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.Nombre});
            this.dataGridSelecActi.Location = new System.Drawing.Point(7, 22);
            this.dataGridSelecActi.Name = "dataGridSelecActi";
            this.dataGridSelecActi.RowHeadersVisible = false;
            this.dataGridSelecActi.Size = new System.Drawing.Size(417, 130);
            this.dataGridSelecActi.TabIndex = 95;
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Selección";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.Location = new System.Drawing.Point(440, 178);
            this.lblFechaPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(107, 17);
            this.lblFechaPago.TabIndex = 70;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblTituloDNI
            // 
            this.lblTituloDNI.AutoSize = true;
            this.lblTituloDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDNI.Location = new System.Drawing.Point(291, 178);
            this.lblTituloDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloDNI.Name = "lblTituloDNI";
            this.lblTituloDNI.Size = new System.Drawing.Size(31, 17);
            this.lblTituloDNI.TabIndex = 67;
            this.lblTituloDNI.Text = "DNI";
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombre.Location = new System.Drawing.Point(17, 178);
            this.lblTituloNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(128, 17);
            this.lblTituloNombre.TabIndex = 65;
            this.lblTituloNombre.Text = "Nombre y Apellido";
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
            this.btnPagar.TabIndex = 79;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
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
            this.btnComprobante.TabIndex = 80;
            this.btnComprobante.Text = "COMPROBANTE";
            this.btnComprobante.UseVisualStyleBackColor = false;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
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
            this.btnCerrar.TabIndex = 81;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblDetalle.Location = new System.Drawing.Point(291, 144);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(168, 22);
            this.lblDetalle.TabIndex = 82;
            this.lblDetalle.Text = "Detalles del Pago";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.White;
            this.panelTotal.Controls.Add(this.lblTotalPagar);
            this.panelTotal.Location = new System.Drawing.Point(440, 554);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(281, 30);
            this.panelTotal.TabIndex = 87;
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
            // lblTituloTotal
            // 
            this.lblTituloTotal.AutoSize = true;
            this.lblTituloTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotal.Location = new System.Drawing.Point(442, 534);
            this.lblTituloTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloTotal.Name = "lblTituloTotal";
            this.lblTituloTotal.Size = new System.Drawing.Size(95, 17);
            this.lblTituloTotal.TabIndex = 88;
            this.lblTituloTotal.Text = "Total a Pagar";
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
            this.label5.TabIndex = 89;
            this.label5.Text = "_______________________________________________________________________";
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.White;
            this.panelBuscar.Location = new System.Drawing.Point(15, 46);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(172, 30);
            this.panelBuscar.TabIndex = 84;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(193, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 30);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteID.Location = new System.Drawing.Point(17, 26);
            this.lblClienteID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(71, 17);
            this.lblClienteID.TabIndex = 83;
            this.lblClienteID.Text = "Cliente ID";
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
            // txtClienteID
            // 
            this.txtClienteID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClienteID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteID.Location = new System.Drawing.Point(18, 53);
            this.txtClienteID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(166, 16);
            this.txtClienteID.TabIndex = 88;
            this.txtClienteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelBuscarCliente
            // 
            this.panelBuscarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.panelBuscarCliente.Controls.Add(this.label4);
            this.panelBuscarCliente.Controls.Add(this.panel2);
            this.panelBuscarCliente.Controls.Add(this.txtClienteID);
            this.panelBuscarCliente.Controls.Add(this.lblSubtitulo);
            this.panelBuscarCliente.Controls.Add(this.lblClienteID);
            this.panelBuscarCliente.Controls.Add(this.btnBuscar);
            this.panelBuscarCliente.Controls.Add(this.panelBuscar);
            this.panelBuscarCliente.Location = new System.Drawing.Point(0, 54);
            this.panelBuscarCliente.Name = "panelBuscarCliente";
            this.panelBuscarCliente.Size = new System.Drawing.Size(735, 84);
            this.panelBuscarCliente.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "Estado del Cliente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblBuscarStatus);
            this.panel2.Location = new System.Drawing.Point(440, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 30);
            this.panel2.TabIndex = 89;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 22);
            this.label1.TabIndex = 91;
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
            this.label2.TabIndex = 92;
            this.label2.Text = "_______________________________________________________________________";
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
            this.btnLimpiar.TabIndex = 93;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataGridResumen
            // 
            this.dataGridResumen.AllowUserToAddRows = false;
            this.dataGridResumen.AllowUserToDeleteRows = false;
            this.dataGridResumen.BackgroundColor = System.Drawing.Color.White;
            this.dataGridResumen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actividad,
            this.Precio});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridResumen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridResumen.Location = new System.Drawing.Point(12, 443);
            this.dataGridResumen.Name = "dataGridResumen";
            this.dataGridResumen.ReadOnly = true;
            this.dataGridResumen.RowHeadersVisible = false;
            this.dataGridResumen.Size = new System.Drawing.Size(422, 141);
            this.dataGridResumen.TabIndex = 94;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 95;
            this.label3.Text = "Día Seleccionado";
            // 
            // dateDiaSeleccionado
            // 
            this.dateDiaSeleccionado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDiaSeleccionado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDiaSeleccionado.Location = new System.Drawing.Point(5, 4);
            this.dateDiaSeleccionado.Margin = new System.Windows.Forms.Padding(2);
            this.dateDiaSeleccionado.Name = "dateDiaSeleccionado";
            this.dateDiaSeleccionado.Size = new System.Drawing.Size(263, 22);
            this.dateDiaSeleccionado.TabIndex = 53;
            this.dateDiaSeleccionado.Value = new System.DateTime(2024, 10, 19, 2, 59, 15, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateDiaSeleccionado);
            this.panel1.Location = new System.Drawing.Point(15, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 30);
            this.panel1.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(11, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(720, 22);
            this.label6.TabIndex = 97;
            this.label6.Text = "_______________________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(326, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 98;
            this.label7.Text = "Resumen";
            // 
            // RegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 650);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
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
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarPago";
            this.Text = "Registrar Pago";
            this.groupOpcionesPago.ResumeLayout(false);
            this.groupOpcionesPago.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panelDNI.ResumeLayout(false);
            this.panelNombreApellido.ResumeLayout(false);
            this.groupActividades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecActi)).EndInit();
            this.panelTotal.ResumeLayout(false);
            this.panelBuscarCliente.ResumeLayout(false);
            this.panelBuscarCliente.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResumen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.Button btnCalcular;
        internal System.Windows.Forms.GroupBox groupOpcionesPago;
        internal System.Windows.Forms.RadioButton radioEfectivo;
        internal System.Windows.Forms.RadioButton radioCuota3;
        internal System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.DateTimePicker dateFechaPago;
        internal System.Windows.Forms.Panel panelDNI;
        internal System.Windows.Forms.Panel panelNombreApellido;
        internal System.Windows.Forms.GroupBox groupActividades;
        internal System.Windows.Forms.Label lblFechaPago;
        internal System.Windows.Forms.Label lblTituloDNI;
        internal System.Windows.Forms.Label lblTituloNombre;
        internal System.Windows.Forms.Button btnPagar;
        internal System.Windows.Forms.Button btnComprobante;
        internal System.Windows.Forms.Button btnCerrar;
        internal System.Windows.Forms.RadioButton radioCuota6;
        internal System.Windows.Forms.Label lblDetalle;
        internal System.Windows.Forms.Panel panelTotal;
        internal System.Windows.Forms.Label lblTituloTotal;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lblNombreApellido;
        internal System.Windows.Forms.Label lblDNI;
        internal System.Windows.Forms.Label lblTotalPagar;
        internal System.Windows.Forms.Panel panelBuscar;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Label lblClienteID;
        internal System.Windows.Forms.Label lblSubtitulo;
        internal System.Windows.Forms.TextBox txtClienteID;
        internal System.Windows.Forms.Panel panelBuscarCliente;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnLimpiar;
        internal System.Windows.Forms.DataGridView dataGridResumen;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DateTimePicker dateDiaSeleccionado;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label lblBuscarStatus;
        internal System.Windows.Forms.DataGridView dataGridSelecActi;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}