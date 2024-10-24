﻿namespace DSOO_PI_ComC_Grupo12.Views
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
            this.checkBoxAcquagym = new System.Windows.Forms.CheckBox();
            this.checkBoxNutricion = new System.Windows.Forms.CheckBox();
            this.checkBoxNatacion = new System.Windows.Forms.CheckBox();
            this.checkBoxBasket = new System.Windows.Forms.CheckBox();
            this.checkBoxFutsal = new System.Windows.Forms.CheckBox();
            this.checkBoxPilates = new System.Windows.Forms.CheckBox();
            this.checkBoxGimnasio = new System.Windows.Forms.CheckBox();
            this.checkBoxTenis = new System.Windows.Forms.CheckBox();
            this.checkBoxVoley = new System.Windows.Forms.CheckBox();
            this.checkBoxFutbol = new System.Windows.Forms.CheckBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dataGridResumen = new System.Windows.Forms.DataGridView();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupOpcionesPago.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelDNI.SuspendLayout();
            this.panelNombreApellido.SuspendLayout();
            this.groupActividades.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResumen)).BeginInit();
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
            this.groupOpcionesPago.Location = new System.Drawing.Point(12, 372);
            this.groupOpcionesPago.Name = "groupOpcionesPago";
            this.groupOpcionesPago.Size = new System.Drawing.Size(711, 50);
            this.groupOpcionesPago.TabIndex = 78;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dateFechaPago);
            this.panel6.Location = new System.Drawing.Point(450, 216);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(273, 30);
            this.panel6.TabIndex = 77;
            // 
            // dateFechaPago
            // 
            this.dateFechaPago.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaPago.Location = new System.Drawing.Point(8, 4);
            this.dateFechaPago.Margin = new System.Windows.Forms.Padding(2);
            this.dateFechaPago.Name = "dateFechaPago";
            this.dateFechaPago.Size = new System.Drawing.Size(258, 22);
            this.dateFechaPago.TabIndex = 53;
            this.dateFechaPago.Value = new System.DateTime(2024, 10, 19, 2, 59, 15, 0);
            // 
            // panelDNI
            // 
            this.panelDNI.BackColor = System.Drawing.Color.White;
            this.panelDNI.Controls.Add(this.lblDNI);
            this.panelDNI.Location = new System.Drawing.Point(222, 216);
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
            this.panelNombreApellido.Location = new System.Drawing.Point(15, 216);
            this.panelNombreApellido.Name = "panelNombreApellido";
            this.panelNombreApellido.Size = new System.Drawing.Size(200, 30);
            this.panelNombreApellido.TabIndex = 72;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(0, 0);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(200, 30);
            this.lblNombreApellido.TabIndex = 91;
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupActividades
            // 
            this.groupActividades.Controls.Add(this.checkBoxAcquagym);
            this.groupActividades.Controls.Add(this.checkBoxNutricion);
            this.groupActividades.Controls.Add(this.checkBoxNatacion);
            this.groupActividades.Controls.Add(this.checkBoxBasket);
            this.groupActividades.Controls.Add(this.checkBoxFutsal);
            this.groupActividades.Controls.Add(this.checkBoxPilates);
            this.groupActividades.Controls.Add(this.checkBoxGimnasio);
            this.groupActividades.Controls.Add(this.checkBoxTenis);
            this.groupActividades.Controls.Add(this.checkBoxVoley);
            this.groupActividades.Controls.Add(this.checkBoxFutbol);
            this.groupActividades.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupActividades.Location = new System.Drawing.Point(12, 268);
            this.groupActividades.Name = "groupActividades";
            this.groupActividades.Size = new System.Drawing.Size(711, 100);
            this.groupActividades.TabIndex = 71;
            this.groupActividades.TabStop = false;
            this.groupActividades.Text = "Actividades";
            // 
            // checkBoxAcquagym
            // 
            this.checkBoxAcquagym.AutoSize = true;
            this.checkBoxAcquagym.Location = new System.Drawing.Point(122, 59);
            this.checkBoxAcquagym.Name = "checkBoxAcquagym";
            this.checkBoxAcquagym.Size = new System.Drawing.Size(98, 21);
            this.checkBoxAcquagym.TabIndex = 9;
            this.checkBoxAcquagym.Text = "Acquagym";
            this.checkBoxAcquagym.UseVisualStyleBackColor = true;
            // 
            // checkBoxNutricion
            // 
            this.checkBoxNutricion.AutoSize = true;
            this.checkBoxNutricion.Location = new System.Drawing.Point(225, 59);
            this.checkBoxNutricion.Name = "checkBoxNutricion";
            this.checkBoxNutricion.Size = new System.Drawing.Size(85, 21);
            this.checkBoxNutricion.TabIndex = 8;
            this.checkBoxNutricion.Text = "Nutrición";
            this.checkBoxNutricion.UseVisualStyleBackColor = true;
            // 
            // checkBoxNatacion
            // 
            this.checkBoxNatacion.AutoSize = true;
            this.checkBoxNatacion.Location = new System.Drawing.Point(225, 32);
            this.checkBoxNatacion.Name = "checkBoxNatacion";
            this.checkBoxNatacion.Size = new System.Drawing.Size(88, 21);
            this.checkBoxNatacion.TabIndex = 7;
            this.checkBoxNatacion.Text = "Natación";
            this.checkBoxNatacion.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasket
            // 
            this.checkBoxBasket.AutoSize = true;
            this.checkBoxBasket.Location = new System.Drawing.Point(615, 32);
            this.checkBoxBasket.Name = "checkBoxBasket";
            this.checkBoxBasket.Size = new System.Drawing.Size(68, 21);
            this.checkBoxBasket.TabIndex = 6;
            this.checkBoxBasket.Text = "Basket";
            this.checkBoxBasket.UseVisualStyleBackColor = true;
            // 
            // checkBoxFutsal
            // 
            this.checkBoxFutsal.AutoSize = true;
            this.checkBoxFutsal.Location = new System.Drawing.Point(528, 32);
            this.checkBoxFutsal.Name = "checkBoxFutsal";
            this.checkBoxFutsal.Size = new System.Drawing.Size(63, 21);
            this.checkBoxFutsal.TabIndex = 5;
            this.checkBoxFutsal.Text = "Futsal";
            this.checkBoxFutsal.UseVisualStyleBackColor = true;
            // 
            // checkBoxPilates
            // 
            this.checkBoxPilates.AutoSize = true;
            this.checkBoxPilates.Location = new System.Drawing.Point(436, 32);
            this.checkBoxPilates.Name = "checkBoxPilates";
            this.checkBoxPilates.Size = new System.Drawing.Size(68, 21);
            this.checkBoxPilates.TabIndex = 4;
            this.checkBoxPilates.Text = "Pilates";
            this.checkBoxPilates.UseVisualStyleBackColor = true;
            // 
            // checkBoxGimnasio
            // 
            this.checkBoxGimnasio.AutoSize = true;
            this.checkBoxGimnasio.Location = new System.Drawing.Point(324, 32);
            this.checkBoxGimnasio.Name = "checkBoxGimnasio";
            this.checkBoxGimnasio.Size = new System.Drawing.Size(88, 21);
            this.checkBoxGimnasio.TabIndex = 3;
            this.checkBoxGimnasio.Text = "Gimnasio";
            this.checkBoxGimnasio.UseVisualStyleBackColor = true;
            // 
            // checkBoxTenis
            // 
            this.checkBoxTenis.AutoSize = true;
            this.checkBoxTenis.Location = new System.Drawing.Point(35, 59);
            this.checkBoxTenis.Name = "checkBoxTenis";
            this.checkBoxTenis.Size = new System.Drawing.Size(56, 21);
            this.checkBoxTenis.TabIndex = 2;
            this.checkBoxTenis.Text = "Tenis";
            this.checkBoxTenis.UseVisualStyleBackColor = true;
            // 
            // checkBoxVoley
            // 
            this.checkBoxVoley.AutoSize = true;
            this.checkBoxVoley.Location = new System.Drawing.Point(122, 32);
            this.checkBoxVoley.Name = "checkBoxVoley";
            this.checkBoxVoley.Size = new System.Drawing.Size(62, 21);
            this.checkBoxVoley.TabIndex = 1;
            this.checkBoxVoley.Text = "Voley";
            this.checkBoxVoley.UseVisualStyleBackColor = true;
            // 
            // checkBoxFutbol
            // 
            this.checkBoxFutbol.AutoSize = true;
            this.checkBoxFutbol.Location = new System.Drawing.Point(35, 32);
            this.checkBoxFutbol.Name = "checkBoxFutbol";
            this.checkBoxFutbol.Size = new System.Drawing.Size(67, 21);
            this.checkBoxFutbol.TabIndex = 0;
            this.checkBoxFutbol.Text = "Fútbol";
            this.checkBoxFutbol.UseVisualStyleBackColor = true;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.Location = new System.Drawing.Point(447, 196);
            this.lblFechaPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(47, 17);
            this.lblFechaPago.TabIndex = 70;
            this.lblFechaPago.Text = "Fecha";
            // 
            // lblTituloDNI
            // 
            this.lblTituloDNI.AutoSize = true;
            this.lblTituloDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDNI.Location = new System.Drawing.Point(219, 196);
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
            this.lblTituloNombre.Location = new System.Drawing.Point(17, 196);
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
            this.lblDetalle.Location = new System.Drawing.Point(295, 156);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(168, 22);
            this.lblDetalle.TabIndex = 82;
            this.lblDetalle.Text = "Detalles del Pago";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.White;
            this.panelTotal.Controls.Add(this.lblTotalPagar);
            this.panelTotal.Location = new System.Drawing.Point(448, 554);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(273, 30);
            this.panelTotal.TabIndex = 87;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPagar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(0, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(273, 30);
            this.lblTotalPagar.TabIndex = 0;
            this.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloTotal
            // 
            this.lblTituloTotal.AutoSize = true;
            this.lblTituloTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotal.Location = new System.Drawing.Point(447, 534);
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
            this.panelBuscar.Location = new System.Drawing.Point(15, 49);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(99, 30);
            this.panelBuscar.TabIndex = 84;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(120, 49);
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
            this.lblClienteID.Location = new System.Drawing.Point(17, 29);
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
            this.lblSubtitulo.Location = new System.Drawing.Point(306, 4);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(140, 22);
            this.lblSubtitulo.TabIndex = 87;
            this.lblSubtitulo.Text = "Buscar Cliente";
            // 
            // txtClienteID
            // 
            this.txtClienteID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClienteID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteID.Location = new System.Drawing.Point(19, 56);
            this.txtClienteID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(92, 16);
            this.txtClienteID.TabIndex = 88;
            this.txtClienteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelBuscarCliente
            // 
            this.panelBuscarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.panelBuscarCliente.Controls.Add(this.txtClienteID);
            this.panelBuscarCliente.Controls.Add(this.lblSubtitulo);
            this.panelBuscarCliente.Controls.Add(this.lblClienteID);
            this.panelBuscarCliente.Controls.Add(this.btnBuscar);
            this.panelBuscarCliente.Controls.Add(this.panelBuscar);
            this.panelBuscarCliente.Location = new System.Drawing.Point(0, 54);
            this.panelBuscarCliente.Name = "panelBuscarCliente";
            this.panelBuscarCliente.Size = new System.Drawing.Size(735, 91);
            this.panelBuscarCliente.TabIndex = 86;
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
            this.label1.TabIndex = 91;
            this.label1.Text = "_______________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(11, 34);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actividad,
            this.Precio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridResumen.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridResumen.Location = new System.Drawing.Point(12, 434);
            this.dataGridResumen.Name = "dataGridResumen";
            this.dataGridResumen.ReadOnly = true;
            this.dataGridResumen.RowHeadersVisible = false;
            this.dataGridResumen.Size = new System.Drawing.Size(422, 150);
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
            // RegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 650);
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
            this.Name = "RegistrarPago";
            this.Text = "Registrar Pago";
            this.groupOpcionesPago.ResumeLayout(false);
            this.groupOpcionesPago.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panelDNI.ResumeLayout(false);
            this.panelNombreApellido.ResumeLayout(false);
            this.groupActividades.ResumeLayout(false);
            this.groupActividades.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelBuscarCliente.ResumeLayout(false);
            this.panelBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupOpcionesPago;
        private System.Windows.Forms.RadioButton radioEfectivo;
        private System.Windows.Forms.RadioButton radioCuota3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dateFechaPago;
        private System.Windows.Forms.Panel panelDNI;
        private System.Windows.Forms.Panel panelNombreApellido;
        private System.Windows.Forms.GroupBox groupActividades;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblTituloDNI;
        private System.Windows.Forms.Label lblTituloNombre;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.RadioButton radioCuota6;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTituloTotal;
        private System.Windows.Forms.CheckBox checkBoxFutbol;
        private System.Windows.Forms.CheckBox checkBoxAcquagym;
        private System.Windows.Forms.CheckBox checkBoxNutricion;
        private System.Windows.Forms.CheckBox checkBoxNatacion;
        private System.Windows.Forms.CheckBox checkBoxBasket;
        private System.Windows.Forms.CheckBox checkBoxFutsal;
        private System.Windows.Forms.CheckBox checkBoxPilates;
        private System.Windows.Forms.CheckBox checkBoxGimnasio;
        private System.Windows.Forms.CheckBox checkBoxTenis;
        private System.Windows.Forms.CheckBox checkBoxVoley;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Panel panelBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}