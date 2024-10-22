namespace DSOO_PI_ComC_Grupo12.Views
{
    partial class Comprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprobante));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelComprobante = new System.Windows.Forms.Panel();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelDNI = new System.Windows.Forms.Panel();
            this.lblDNI = new System.Windows.Forms.Label();
            this.panelNombreApellido = new System.Windows.Forms.Panel();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblTituloDNI = new System.Windows.Forms.Label();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridResumen = new System.Windows.Forms.DataGridView();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelComprobante.SuspendLayout();
            this.panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDNI.SuspendLayout();
            this.panelNombreApellido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResumen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(166, 639);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(135, 30);
            this.btnImprimir.TabIndex = 95;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(307, 639);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(135, 30);
            this.btnCerrar.TabIndex = 94;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelComprobante
            // 
            this.panelComprobante.BackColor = System.Drawing.Color.White;
            this.panelComprobante.Controls.Add(this.dataGridResumen);
            this.panelComprobante.Controls.Add(this.panelTotal);
            this.panelComprobante.Controls.Add(this.label11);
            this.panelComprobante.Controls.Add(this.label10);
            this.panelComprobante.Controls.Add(this.label9);
            this.panelComprobante.Controls.Add(this.label8);
            this.panelComprobante.Controls.Add(this.label7);
            this.panelComprobante.Controls.Add(this.pictureBox1);
            this.panelComprobante.Controls.Add(this.panel2);
            this.panelComprobante.Controls.Add(this.panel1);
            this.panelComprobante.Controls.Add(this.label12);
            this.panelComprobante.Controls.Add(this.label5);
            this.panelComprobante.Controls.Add(this.panelDNI);
            this.panelComprobante.Controls.Add(this.panelNombreApellido);
            this.panelComprobante.Controls.Add(this.lblTituloDNI);
            this.panelComprobante.Controls.Add(this.lblTituloNombre);
            this.panelComprobante.Controls.Add(this.label4);
            this.panelComprobante.Controls.Add(this.lblDetalle);
            this.panelComprobante.Controls.Add(this.lblTitulo);
            this.panelComprobante.Controls.Add(this.label6);
            this.panelComprobante.Controls.Add(this.label2);
            this.panelComprobante.Controls.Add(this.label3);
            this.panelComprobante.Controls.Add(this.label1);
            this.panelComprobante.Location = new System.Drawing.Point(12, 12);
            this.panelComprobante.Name = "panelComprobante";
            this.panelComprobante.Size = new System.Drawing.Size(596, 621);
            this.panelComprobante.TabIndex = 96;
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Location = new System.Drawing.Point(427, 588);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(163, 30);
            this.panelTotal.TabIndex = 102;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(163, 30);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label11.Location = new System.Drawing.Point(160, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 101;
            this.label11.Text = "club@grupo12.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Location = new System.Drawing.Point(171, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 101;
            this.label10.Text = "Tel:123-45688";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(153, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 101;
            this.label9.Text = "Calle: Falsa N°123";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(178, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 101;
            this.label8.Text = "\"Grupo 12\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(153, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 101;
            this.label7.Text = "CLUB DEPORTIVO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DSOO_PI_ComC_Grupo12.Properties.Resources.logoMainBlue140;
            this.pictureBox1.Location = new System.Drawing.Point(10, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblFechaPago);
            this.panel2.Location = new System.Drawing.Point(424, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 30);
            this.panel2.TabIndex = 99;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.Location = new System.Drawing.Point(0, 0);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(163, 30);
            this.lblFechaPago.TabIndex = 0;
            this.lblFechaPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblFormaPago);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(424, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 30);
            this.panel1.TabIndex = 99;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormaPago.Location = new System.Drawing.Point(0, 0);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(163, 30);
            this.lblFormaPago.TabIndex = 0;
            this.lblFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label12.Location = new System.Drawing.Point(421, 53);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 98;
            this.label12.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(421, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = "Forma de Pago";
            // 
            // panelDNI
            // 
            this.panelDNI.BackColor = System.Drawing.Color.White;
            this.panelDNI.Controls.Add(this.lblDNI);
            this.panelDNI.Location = new System.Drawing.Point(218, 230);
            this.panelDNI.Name = "panelDNI";
            this.panelDNI.Size = new System.Drawing.Size(140, 30);
            this.panelDNI.TabIndex = 97;
            // 
            // lblDNI
            // 
            this.lblDNI.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.panelNombreApellido.Location = new System.Drawing.Point(9, 230);
            this.panelNombreApellido.Name = "panelNombreApellido";
            this.panelNombreApellido.Size = new System.Drawing.Size(200, 30);
            this.panelNombreApellido.TabIndex = 96;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(0, 0);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(200, 30);
            this.lblNombreApellido.TabIndex = 0;
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloDNI
            // 
            this.lblTituloDNI.AutoSize = true;
            this.lblTituloDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTituloDNI.Location = new System.Drawing.Point(215, 210);
            this.lblTituloDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloDNI.Name = "lblTituloDNI";
            this.lblTituloDNI.Size = new System.Drawing.Size(31, 17);
            this.lblTituloDNI.TabIndex = 95;
            this.lblTituloDNI.Text = "DNI";
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTituloNombre.Location = new System.Drawing.Point(7, 210);
            this.lblTituloNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(128, 17);
            this.lblTituloNombre.TabIndex = 94;
            this.lblTituloNombre.Text = "Nombre y Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(337, 592);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 93;
            this.label4.Text = "Total:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblDetalle.Location = new System.Drawing.Point(5, 285);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(70, 17);
            this.lblDetalle.TabIndex = 93;
            this.lblDetalle.Text = "Resumen:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitulo.Location = new System.Drawing.Point(134, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 33);
            this.lblTitulo.TabIndex = 57;
            this.lblTitulo.Text = "Comprobante de Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(4, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(590, 22);
            this.label6.TabIndex = 92;
            this.label6.Text = "__________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(3, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 22);
            this.label2.TabIndex = 92;
            this.label2.Text = "__________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(4, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(590, 22);
            this.label3.TabIndex = 92;
            this.label3.Text = "__________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 22);
            this.label1.TabIndex = 92;
            this.label1.Text = "__________________________________________________________";
            // 
            // dataGridResumen
            // 
            this.dataGridResumen.AllowUserToAddRows = false;
            this.dataGridResumen.AllowUserToDeleteRows = false;
            this.dataGridResumen.AllowUserToResizeColumns = false;
            this.dataGridResumen.AllowUserToResizeRows = false;
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
            this.dataGridResumen.Location = new System.Drawing.Point(8, 306);
            this.dataGridResumen.Name = "dataGridResumen";
            this.dataGridResumen.ReadOnly = true;
            this.dataGridResumen.RowHeadersVisible = false;
            this.dataGridResumen.Size = new System.Drawing.Size(580, 276);
            this.dataGridResumen.TabIndex = 103;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            this.Actividad.Width = 450;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Comprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 677);
            this.Controls.Add(this.panelComprobante);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante de Pago";
            this.panelComprobante.ResumeLayout(false);
            this.panelComprobante.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelDNI.ResumeLayout(false);
            this.panelNombreApellido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResumen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelComprobante;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelDNI;
        private System.Windows.Forms.Panel panelNombreApellido;
        private System.Windows.Forms.Label lblTituloDNI;
        private System.Windows.Forms.Label lblTituloNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}