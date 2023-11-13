namespace AlquileresTemporarios_TP2LAB2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAgregarPropiedad = new System.Windows.Forms.Button();
            this.btnConsultarReserva = new System.Windows.Forms.Button();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.dgvPropiedades = new System.Windows.Forms.DataGridView();
            this.colTipoPropiedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaracteristicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCantPersonas = new System.Windows.Forms.NumericUpDown();
            this.cbWifi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDesayuno = new System.Windows.Forms.CheckBox();
            this.cbPileta = new System.Windows.Forms.CheckBox();
            this.cbMascotas = new System.Windows.Forms.CheckBox();
            this.cbLimpieza = new System.Windows.Forms.CheckBox();
            this.cbCochera = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbfechaHasta = new System.Windows.Forms.Label();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbUbicacionBuscar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImportarReservas = new System.Windows.Forms.Button();
            this.btnExportarReservas = new System.Windows.Forms.Button();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPropiedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msInicio = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ssInicio = new System.Windows.Forms.StatusStrip();
            this.sslInicio = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssLFechaInicio = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.msInicio.SuspendLayout();
            this.ssInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarPropiedad
            // 
            this.btnAgregarPropiedad.Location = new System.Drawing.Point(327, 26);
            this.btnAgregarPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPropiedad.Name = "btnAgregarPropiedad";
            this.btnAgregarPropiedad.Size = new System.Drawing.Size(178, 67);
            this.btnAgregarPropiedad.TabIndex = 2;
            this.btnAgregarPropiedad.Text = "Agregar propiedad";
            this.btnAgregarPropiedad.UseVisualStyleBackColor = true;
            this.btnAgregarPropiedad.Click += new System.EventHandler(this.btnAgregarPropiedad_Click);
            // 
            // btnConsultarReserva
            // 
            this.btnConsultarReserva.Location = new System.Drawing.Point(709, 26);
            this.btnConsultarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarReserva.Name = "btnConsultarReserva";
            this.btnConsultarReserva.Size = new System.Drawing.Size(178, 67);
            this.btnConsultarReserva.TabIndex = 3;
            this.btnConsultarReserva.Text = "Consultar Reserva";
            this.btnConsultarReserva.UseVisualStyleBackColor = true;
            this.btnConsultarReserva.Click += new System.EventHandler(this.btnConsultarReserva_Click);
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Location = new System.Drawing.Point(516, 26);
            this.btnEliminarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(178, 67);
            this.btnEliminarReserva.TabIndex = 4;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // dgvPropiedades
            // 
            this.dgvPropiedades.AllowUserToAddRows = false;
            this.dgvPropiedades.AllowUserToDeleteRows = false;
            this.dgvPropiedades.AllowUserToResizeColumns = false;
            this.dgvPropiedades.AllowUserToResizeRows = false;
            this.dgvPropiedades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPropiedades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropiedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipoPropiedad,
            this.colCaracteristicas,
            this.colUbicacion,
            this.colDescripcion,
            this.colCantPersonas,
            this.colPrecio});
            this.dgvPropiedades.Location = new System.Drawing.Point(327, 116);
            this.dgvPropiedades.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPropiedades.Name = "dgvPropiedades";
            this.dgvPropiedades.RowHeadersWidth = 51;
            this.dgvPropiedades.RowTemplate.Height = 24;
            this.dgvPropiedades.Size = new System.Drawing.Size(820, 416);
            this.dgvPropiedades.TabIndex = 5;
            this.dgvPropiedades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropiedades_CellContentClick);
            // 
            // colTipoPropiedad
            // 
            this.colTipoPropiedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoPropiedad.HeaderText = "Tipo propiedad";
            this.colTipoPropiedad.MinimumWidth = 6;
            this.colTipoPropiedad.Name = "colTipoPropiedad";
            this.colTipoPropiedad.ReadOnly = true;
            // 
            // colCaracteristicas
            // 
            this.colCaracteristicas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCaracteristicas.HeaderText = "Características";
            this.colCaracteristicas.MinimumWidth = 6;
            this.colCaracteristicas.Name = "colCaracteristicas";
            this.colCaracteristicas.ReadOnly = true;
            // 
            // colUbicacion
            // 
            this.colUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUbicacion.HeaderText = "Ubicación";
            this.colUbicacion.MinimumWidth = 6;
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colCantPersonas
            // 
            this.colCantPersonas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCantPersonas.HeaderText = "Cant. Personas";
            this.colCantPersonas.MinimumWidth = 6;
            this.colCantPersonas.Name = "colCantPersonas";
            this.colCantPersonas.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Provincia";
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(191, 170);
            this.tbUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(103, 20);
            this.tbUbicacion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad de personas";
            // 
            // nudCantPersonas
            // 
            this.nudCantPersonas.Location = new System.Drawing.Point(30, 221);
            this.nudCantPersonas.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantPersonas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCantPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantPersonas.Name = "nudCantPersonas";
            this.nudCantPersonas.Size = new System.Drawing.Size(107, 20);
            this.nudCantPersonas.TabIndex = 12;
            this.nudCantPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Location = new System.Drawing.Point(20, 27);
            this.cbWifi.Margin = new System.Windows.Forms.Padding(2);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(50, 17);
            this.cbWifi.TabIndex = 13;
            this.cbWifi.Text = "Wi-Fi";
            this.cbWifi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDesayuno);
            this.groupBox1.Controls.Add(this.cbPileta);
            this.groupBox1.Controls.Add(this.cbMascotas);
            this.groupBox1.Controls.Add(this.cbLimpieza);
            this.groupBox1.Controls.Add(this.cbCochera);
            this.groupBox1.Controls.Add(this.cbWifi);
            this.groupBox1.Location = new System.Drawing.Point(29, 389);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(265, 90);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Características";
            // 
            // cbDesayuno
            // 
            this.cbDesayuno.AutoSize = true;
            this.cbDesayuno.Location = new System.Drawing.Point(169, 27);
            this.cbDesayuno.Margin = new System.Windows.Forms.Padding(2);
            this.cbDesayuno.Name = "cbDesayuno";
            this.cbDesayuno.Size = new System.Drawing.Size(74, 17);
            this.cbDesayuno.TabIndex = 18;
            this.cbDesayuno.Text = "Desayuno";
            this.cbDesayuno.UseVisualStyleBackColor = true;
            // 
            // cbPileta
            // 
            this.cbPileta.AutoSize = true;
            this.cbPileta.Location = new System.Drawing.Point(20, 56);
            this.cbPileta.Margin = new System.Windows.Forms.Padding(2);
            this.cbPileta.Name = "cbPileta";
            this.cbPileta.Size = new System.Drawing.Size(52, 17);
            this.cbPileta.TabIndex = 17;
            this.cbPileta.Text = "Pileta";
            this.cbPileta.UseVisualStyleBackColor = true;
            // 
            // cbMascotas
            // 
            this.cbMascotas.AutoSize = true;
            this.cbMascotas.Location = new System.Drawing.Point(169, 56);
            this.cbMascotas.Margin = new System.Windows.Forms.Padding(2);
            this.cbMascotas.Name = "cbMascotas";
            this.cbMascotas.Size = new System.Drawing.Size(72, 17);
            this.cbMascotas.TabIndex = 16;
            this.cbMascotas.Text = "Mascotas";
            this.cbMascotas.UseVisualStyleBackColor = true;
            // 
            // cbLimpieza
            // 
            this.cbLimpieza.AutoSize = true;
            this.cbLimpieza.Location = new System.Drawing.Point(87, 56);
            this.cbLimpieza.Margin = new System.Windows.Forms.Padding(2);
            this.cbLimpieza.Name = "cbLimpieza";
            this.cbLimpieza.Size = new System.Drawing.Size(67, 17);
            this.cbLimpieza.TabIndex = 15;
            this.cbLimpieza.Text = "Limpieza";
            this.cbLimpieza.UseVisualStyleBackColor = true;
            // 
            // cbCochera
            // 
            this.cbCochera.AutoSize = true;
            this.cbCochera.Location = new System.Drawing.Point(87, 27);
            this.cbCochera.Margin = new System.Windows.Forms.Padding(2);
            this.cbCochera.Name = "cbCochera";
            this.cbCochera.Size = new System.Drawing.Size(66, 17);
            this.cbCochera.TabIndex = 14;
            this.cbCochera.Text = "Cochera";
            this.cbCochera.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(29, 488);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(265, 44);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(20, 44);
            this.fechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.fechaDesde.MinDate = new System.DateTime(2023, 10, 16, 0, 0, 0, 0);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(216, 20);
            this.fechaDesde.TabIndex = 17;
            this.fechaDesde.ValueChanged += new System.EventHandler(this.fechaDesde_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Desde";
            // 
            // lbfechaHasta
            // 
            this.lbfechaHasta.AutoSize = true;
            this.lbfechaHasta.Location = new System.Drawing.Point(17, 76);
            this.lbfechaHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbfechaHasta.Name = "lbfechaHasta";
            this.lbfechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lbfechaHasta.TabIndex = 20;
            this.lbfechaHasta.Text = "Hasta";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(20, 95);
            this.fechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(216, 20);
            this.fechaHasta.TabIndex = 19;
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.label4);
            this.gbFecha.Controls.Add(this.lbfechaHasta);
            this.gbFecha.Controls.Add(this.fechaDesde);
            this.gbFecha.Controls.Add(this.fechaHasta);
            this.gbFecha.Location = new System.Drawing.Point(29, 248);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(265, 134);
            this.gbFecha.TabIndex = 21;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha a reservar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AlquileresTemporarios_TP2LAB2.Properties.Resources.iconoAlquileres;
            this.pictureBox1.Location = new System.Drawing.Point(29, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // cbUbicacionBuscar
            // 
            this.cbUbicacionBuscar.FormattingEnabled = true;
            this.cbUbicacionBuscar.Items.AddRange(new object[] {
            "Buenos Aires",
            "CABA",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra Del Fuego",
            "Tucumán"});
            this.cbUbicacionBuscar.Location = new System.Drawing.Point(28, 169);
            this.cbUbicacionBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cbUbicacionBuscar.Name = "cbUbicacionBuscar";
            this.cbUbicacionBuscar.Size = new System.Drawing.Size(151, 21);
            this.cbUbicacionBuscar.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Localidad";
            // 
            // btnImportarReservas
            // 
            this.btnImportarReservas.Location = new System.Drawing.Point(902, 26);
            this.btnImportarReservas.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportarReservas.Name = "btnImportarReservas";
            this.btnImportarReservas.Size = new System.Drawing.Size(119, 67);
            this.btnImportarReservas.TabIndex = 25;
            this.btnImportarReservas.Text = "Importar Reservas";
            this.btnImportarReservas.UseVisualStyleBackColor = true;
            this.btnImportarReservas.Click += new System.EventHandler(this.btnImportarReservas_Click);
            // 
            // btnExportarReservas
            // 
            this.btnExportarReservas.Location = new System.Drawing.Point(1034, 26);
            this.btnExportarReservas.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportarReservas.Name = "btnExportarReservas";
            this.btnExportarReservas.Size = new System.Drawing.Size(113, 67);
            this.btnExportarReservas.TabIndex = 26;
            this.btnExportarReservas.Text = "Exportar Reservas";
            this.btnExportarReservas.UseVisualStyleBackColor = true;
            this.btnExportarReservas.Click += new System.EventHandler(this.btnExportarReservas_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarReservasToolStripMenuItem,
            this.eliminarReservasToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // consultarReservasToolStripMenuItem
            // 
            this.consultarReservasToolStripMenuItem.Name = "consultarReservasToolStripMenuItem";
            this.consultarReservasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.consultarReservasToolStripMenuItem.Text = "Consultar Reservas";
            this.consultarReservasToolStripMenuItem.Click += new System.EventHandler(this.btnConsultarReserva_Click);
            // 
            // eliminarReservasToolStripMenuItem
            // 
            this.eliminarReservasToolStripMenuItem.Name = "eliminarReservasToolStripMenuItem";
            this.eliminarReservasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.eliminarReservasToolStripMenuItem.Text = "Eliminar Reserva";
            this.eliminarReservasToolStripMenuItem.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exportarToolStripMenuItem,
            this.exportarClientesToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem1.Text = "Importar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.btnImportarReservas_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.btnExportarReservas_Click);
            // 
            // exportarClientesToolStripMenuItem
            // 
            this.exportarClientesToolStripMenuItem.Name = "exportarClientesToolStripMenuItem";
            this.exportarClientesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exportarClientesToolStripMenuItem.Text = "Exportar Clientes";
            this.exportarClientesToolStripMenuItem.Click += new System.EventHandler(this.exportarClientesToolStripMenuItem_Click);
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPropiedadToolStripMenuItem});
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            // 
            // agregarPropiedadToolStripMenuItem
            // 
            this.agregarPropiedadToolStripMenuItem.Name = "agregarPropiedadToolStripMenuItem";
            this.agregarPropiedadToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.agregarPropiedadToolStripMenuItem.Text = "Agregar Propiedad";
            this.agregarPropiedadToolStripMenuItem.Click += new System.EventHandler(this.btnAgregarPropiedad_Click);
            // 
            // msInicio
            // 
            this.msInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.propiedadesToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.msInicio.Location = new System.Drawing.Point(0, 0);
            this.msInicio.Name = "msInicio";
            this.msInicio.Size = new System.Drawing.Size(1182, 24);
            this.msInicio.TabIndex = 27;
            this.msInicio.Text = "Inicio: Complete los filtros";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // ssInicio
            // 
            this.ssInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslInicio,
            this.ssLFechaInicio});
            this.ssInicio.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ssInicio.Location = new System.Drawing.Point(0, 544);
            this.ssInicio.Name = "ssInicio";
            this.ssInicio.Size = new System.Drawing.Size(1182, 22);
            this.ssInicio.TabIndex = 28;
            this.ssInicio.Text = "statusStrip1";
            // 
            // sslInicio
            // 
            this.sslInicio.Name = "sslInicio";
            this.sslInicio.Size = new System.Drawing.Size(36, 17);
            this.sslInicio.Text = "Inicio";
            // 
            // ssLFechaInicio
            // 
            this.ssLFechaInicio.Name = "ssLFechaInicio";
            this.ssLFechaInicio.Size = new System.Drawing.Size(118, 17);
            this.ssLFechaInicio.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 566);
            this.Controls.Add(this.ssInicio);
            this.Controls.Add(this.btnExportarReservas);
            this.Controls.Add(this.btnImportarReservas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUbicacionBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudCantPersonas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUbicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPropiedades);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.btnConsultarReserva);
            this.Controls.Add(this.btnAgregarPropiedad);
            this.Controls.Add(this.msInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msInicio;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler Temporal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.msInicio.ResumeLayout(false);
            this.msInicio.PerformLayout();
            this.ssInicio.ResumeLayout(false);
            this.ssInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarPropiedad;
        private System.Windows.Forms.Button btnConsultarReserva;
        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.DataGridView dgvPropiedades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCantPersonas;
        private System.Windows.Forms.CheckBox cbWifi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbDesayuno;
        private System.Windows.Forms.CheckBox cbPileta;
        private System.Windows.Forms.CheckBox cbMascotas;
        private System.Windows.Forms.CheckBox cbLimpieza;
        private System.Windows.Forms.CheckBox cbCochera;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbfechaHasta;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbUbicacionBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPropiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaracteristicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.Button btnImportarReservas;
        private System.Windows.Forms.Button btnExportarReservas;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPropiedadToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msInicio;
        private System.Windows.Forms.StatusStrip ssInicio;
        private System.Windows.Forms.ToolStripStatusLabel sslInicio;
        private System.Windows.Forms.ToolStripStatusLabel ssLFechaInicio;
        private System.Windows.Forms.ToolStripMenuItem exportarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
    }
}

