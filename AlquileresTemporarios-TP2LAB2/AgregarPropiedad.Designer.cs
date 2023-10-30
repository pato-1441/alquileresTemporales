namespace AlquileresTemporarios_TP2LAB2
{
    partial class AgregarPropiedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPropiedad));
            this.cmbTipoPropiedad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCantPersonas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrecioXNoche = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDesayuno = new System.Windows.Forms.CheckBox();
            this.cbPileta = new System.Windows.Forms.CheckBox();
            this.cbMascotas = new System.Windows.Forms.CheckBox();
            this.cbLimpieza = new System.Windows.Forms.CheckBox();
            this.cbCochera = new System.Windows.Forms.CheckBox();
            this.cbWifi = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbNumHabitacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.tbNombreHotel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbHotel = new System.Windows.Forms.GroupBox();
            this.cmbCantEstrellas = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbCasa = new System.Windows.Forms.GroupBox();
            this.nudMinimoDias = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbImagenPropiedad5 = new System.Windows.Forms.PictureBox();
            this.pbImagenPropiedad4 = new System.Windows.Forms.PictureBox();
            this.pbImagenPropiedad3 = new System.Windows.Forms.PictureBox();
            this.pbImagenPropiedad2 = new System.Windows.Forms.PictureBox();
            this.pbImagenPropiedad1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
            this.gbPropietario = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNombrePropietario = new System.Windows.Forms.TextBox();
            this.tbDniPropietario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbHotel.SuspendLayout();
            this.gbCasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimoDias)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPropiedad5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPropiedad4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPropiedad3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPropiedad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPropiedad1)).BeginInit();
            this.gbPropietario.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoPropiedad
            // 
            this.cmbTipoPropiedad.FormattingEnabled = true;
            this.cmbTipoPropiedad.Items.AddRange(new object[] {
            "Habitacion de hotel",
            "Casa",
            "Casa fin de semana"});
            this.cmbTipoPropiedad.Location = new System.Drawing.Point(49, 69);
            this.cmbTipoPropiedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoPropiedad.Name = "cmbTipoPropiedad";
            this.cmbTipoPropiedad.Size = new System.Drawing.Size(213, 24);
            this.cmbTipoPropiedad.TabIndex = 0;
            this.cmbTipoPropiedad.SelectedIndexChanged += new System.EventHandler(this.cbTipoPropiedad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de propiedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Localidad";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(49, 265);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(139, 22);
            this.tbDireccion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Direccion";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(49, 198);
            this.tbLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(139, 22);
            this.tbLocalidad.TabIndex = 2;
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Items.AddRange(new object[] {
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
            this.cmbProvincias.Location = new System.Drawing.Point(49, 128);
            this.cmbProvincias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(213, 24);
            this.cmbProvincias.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad de personas";
            // 
            // nudCantPersonas
            // 
            this.nudCantPersonas.Location = new System.Drawing.Point(51, 336);
            this.nudCantPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.nudCantPersonas.Size = new System.Drawing.Size(120, 22);
            this.nudCantPersonas.TabIndex = 4;
            this.nudCantPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Precio por noche";
            // 
            // tbPrecioXNoche
            // 
            this.tbPrecioXNoche.Location = new System.Drawing.Point(49, 407);
            this.tbPrecioXNoche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrecioXNoche.Name = "tbPrecioXNoche";
            this.tbPrecioXNoche.Size = new System.Drawing.Size(139, 22);
            this.tbPrecioXNoche.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDesayuno);
            this.groupBox1.Controls.Add(this.cbPileta);
            this.groupBox1.Controls.Add(this.cbMascotas);
            this.groupBox1.Controls.Add(this.cbLimpieza);
            this.groupBox1.Controls.Add(this.cbCochera);
            this.groupBox1.Controls.Add(this.cbWifi);
            this.groupBox1.Location = new System.Drawing.Point(333, 511);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(279, 106);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Características";
            // 
            // cbDesayuno
            // 
            this.cbDesayuno.AutoSize = true;
            this.cbDesayuno.Location = new System.Drawing.Point(179, 33);
            this.cbDesayuno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDesayuno.Name = "cbDesayuno";
            this.cbDesayuno.Size = new System.Drawing.Size(91, 20);
            this.cbDesayuno.TabIndex = 11;
            this.cbDesayuno.Text = "Desayuno";
            this.cbDesayuno.UseVisualStyleBackColor = true;
            // 
            // cbPileta
            // 
            this.cbPileta.AutoSize = true;
            this.cbPileta.Location = new System.Drawing.Point(12, 69);
            this.cbPileta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPileta.Name = "cbPileta";
            this.cbPileta.Size = new System.Drawing.Size(63, 20);
            this.cbPileta.TabIndex = 12;
            this.cbPileta.Text = "Pileta";
            this.cbPileta.UseVisualStyleBackColor = true;
            // 
            // cbMascotas
            // 
            this.cbMascotas.AutoSize = true;
            this.cbMascotas.Location = new System.Drawing.Point(179, 69);
            this.cbMascotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMascotas.Name = "cbMascotas";
            this.cbMascotas.Size = new System.Drawing.Size(88, 20);
            this.cbMascotas.TabIndex = 14;
            this.cbMascotas.Text = "Mascotas";
            this.cbMascotas.UseVisualStyleBackColor = true;
            // 
            // cbLimpieza
            // 
            this.cbLimpieza.AutoSize = true;
            this.cbLimpieza.Location = new System.Drawing.Point(83, 69);
            this.cbLimpieza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLimpieza.Name = "cbLimpieza";
            this.cbLimpieza.Size = new System.Drawing.Size(83, 20);
            this.cbLimpieza.TabIndex = 13;
            this.cbLimpieza.Text = "Limpieza";
            this.cbLimpieza.UseVisualStyleBackColor = true;
            // 
            // cbCochera
            // 
            this.cbCochera.AutoSize = true;
            this.cbCochera.Location = new System.Drawing.Point(83, 33);
            this.cbCochera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCochera.Name = "cbCochera";
            this.cbCochera.Size = new System.Drawing.Size(80, 20);
            this.cbCochera.TabIndex = 10;
            this.cbCochera.Text = "Cochera";
            this.cbCochera.UseVisualStyleBackColor = true;
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Location = new System.Drawing.Point(12, 33);
            this.cbWifi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(60, 20);
            this.cbWifi.TabIndex = 9;
            this.cbWifi.Text = "Wi-Fi";
            this.cbWifi.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(541, 644);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(512, 55);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(49, 644);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(484, 55);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbNumHabitacion
            // 
            this.tbNumHabitacion.Location = new System.Drawing.Point(25, 113);
            this.tbNumHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumHabitacion.Name = "tbNumHabitacion";
            this.tbNumHabitacion.Size = new System.Drawing.Size(139, 22);
            this.tbNumHabitacion.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "N° Habitación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tipo de habitación";
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Triple"});
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(25, 186);
            this.cmbTipoHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(213, 24);
            this.cmbTipoHabitacion.TabIndex = 8;
            // 
            // tbNombreHotel
            // 
            this.tbNombreHotel.Location = new System.Drawing.Point(25, 48);
            this.tbNombreHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreHotel.Name = "tbNombreHotel";
            this.tbNombreHotel.Size = new System.Drawing.Size(139, 22);
            this.tbNombreHotel.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nombre de hotel";
            // 
            // gbHotel
            // 
            this.gbHotel.Controls.Add(this.cmbCantEstrellas);
            this.gbHotel.Controls.Add(this.label11);
            this.gbHotel.Controls.Add(this.label10);
            this.gbHotel.Controls.Add(this.tbNombreHotel);
            this.gbHotel.Controls.Add(this.label8);
            this.gbHotel.Controls.Add(this.tbNumHabitacion);
            this.gbHotel.Controls.Add(this.cmbTipoHabitacion);
            this.gbHotel.Controls.Add(this.label9);
            this.gbHotel.Enabled = false;
            this.gbHotel.Location = new System.Drawing.Point(333, 47);
            this.gbHotel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbHotel.Name = "gbHotel";
            this.gbHotel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbHotel.Size = new System.Drawing.Size(267, 305);
            this.gbHotel.TabIndex = 24;
            this.gbHotel.TabStop = false;
            this.gbHotel.Text = "Hotel";
            // 
            // cmbCantEstrellas
            // 
            this.cmbCantEstrellas.FormattingEnabled = true;
            this.cmbCantEstrellas.Items.AddRange(new object[] {
            "★ ★",
            "★ ★ ★"});
            this.cmbCantEstrellas.Location = new System.Drawing.Point(25, 254);
            this.cmbCantEstrellas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCantEstrellas.Name = "cmbCantEstrellas";
            this.cmbCantEstrellas.Size = new System.Drawing.Size(213, 24);
            this.cmbCantEstrellas.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cantidad de estrellas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Minimo de dias";
            // 
            // gbCasa
            // 
            this.gbCasa.Controls.Add(this.nudMinimoDias);
            this.gbCasa.Controls.Add(this.label12);
            this.gbCasa.Enabled = false;
            this.gbCasa.Location = new System.Drawing.Point(49, 511);
            this.gbCasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCasa.Name = "gbCasa";
            this.gbCasa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCasa.Size = new System.Drawing.Size(253, 106);
            this.gbCasa.TabIndex = 28;
            this.gbCasa.TabStop = false;
            this.gbCasa.Text = "Casa";
            // 
            // nudMinimoDias
            // 
            this.nudMinimoDias.Location = new System.Drawing.Point(17, 57);
            this.nudMinimoDias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMinimoDias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMinimoDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinimoDias.Name = "nudMinimoDias";
            this.nudMinimoDias.Size = new System.Drawing.Size(217, 22);
            this.nudMinimoDias.TabIndex = 29;
            this.nudMinimoDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbImagenPropiedad5);
            this.groupBox2.Controls.Add(this.pbImagenPropiedad4);
            this.groupBox2.Controls.Add(this.pbImagenPropiedad3);
            this.groupBox2.Controls.Add(this.pbImagenPropiedad2);
            this.groupBox2.Controls.Add(this.pbImagenPropiedad1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnSeleccionarImagen);
            this.groupBox2.Controls.Add(this.tbDescripcion);
            this.groupBox2.Controls.Add(this.lDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(641, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(412, 552);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información";
            // 
            // pbImagenPropiedad5
            // 
            this.pbImagenPropiedad5.Location = new System.Drawing.Point(152, 423);
            this.pbImagenPropiedad5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagenPropiedad5.Name = "pbImagenPropiedad5";
            this.pbImagenPropiedad5.Size = new System.Drawing.Size(113, 79);
            this.pbImagenPropiedad5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPropiedad5.TabIndex = 34;
            this.pbImagenPropiedad5.TabStop = false;
            // 
            // pbImagenPropiedad4
            // 
            this.pbImagenPropiedad4.Location = new System.Drawing.Point(31, 426);
            this.pbImagenPropiedad4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagenPropiedad4.Name = "pbImagenPropiedad4";
            this.pbImagenPropiedad4.Size = new System.Drawing.Size(113, 79);
            this.pbImagenPropiedad4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPropiedad4.TabIndex = 33;
            this.pbImagenPropiedad4.TabStop = false;
            // 
            // pbImagenPropiedad3
            // 
            this.pbImagenPropiedad3.Location = new System.Drawing.Point(273, 321);
            this.pbImagenPropiedad3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagenPropiedad3.Name = "pbImagenPropiedad3";
            this.pbImagenPropiedad3.Size = new System.Drawing.Size(113, 79);
            this.pbImagenPropiedad3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPropiedad3.TabIndex = 32;
            this.pbImagenPropiedad3.TabStop = false;
            // 
            // pbImagenPropiedad2
            // 
            this.pbImagenPropiedad2.Location = new System.Drawing.Point(152, 321);
            this.pbImagenPropiedad2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagenPropiedad2.Name = "pbImagenPropiedad2";
            this.pbImagenPropiedad2.Size = new System.Drawing.Size(113, 79);
            this.pbImagenPropiedad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPropiedad2.TabIndex = 31;
            this.pbImagenPropiedad2.TabStop = false;
            // 
            // pbImagenPropiedad1
            // 
            this.pbImagenPropiedad1.Location = new System.Drawing.Point(31, 321);
            this.pbImagenPropiedad1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagenPropiedad1.Name = "pbImagenPropiedad1";
            this.pbImagenPropiedad1.Size = new System.Drawing.Size(113, 79);
            this.pbImagenPropiedad1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPropiedad1.TabIndex = 30;
            this.pbImagenPropiedad1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 289);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Imagenes seleccionadas";
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(273, 423);
            this.btnSeleccionarImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(113, 79);
            this.btnSeleccionarImagen.TabIndex = 30;
            this.btnSeleccionarImagen.Text = "Adjuntar Imagenes";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(31, 53);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(355, 192);
            this.tbDescripcion.TabIndex = 1;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(27, 32);
            this.lDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lDescripcion.TabIndex = 0;
            this.lDescripcion.Text = "Descripción";
            // 
            // ofdImagen
            // 
            this.ofdImagen.FileName = "openFileDialog1";
            this.ofdImagen.Filter = "Imagenes|*.png*.jpg*.jpeg";
            // 
            // gbPropietario
            // 
            this.gbPropietario.Controls.Add(this.tbDniPropietario);
            this.gbPropietario.Controls.Add(this.label15);
            this.gbPropietario.Controls.Add(this.tbNombrePropietario);
            this.gbPropietario.Controls.Add(this.label14);
            this.gbPropietario.Enabled = false;
            this.gbPropietario.Location = new System.Drawing.Point(333, 360);
            this.gbPropietario.Margin = new System.Windows.Forms.Padding(4);
            this.gbPropietario.Name = "gbPropietario";
            this.gbPropietario.Padding = new System.Windows.Forms.Padding(4);
            this.gbPropietario.Size = new System.Drawing.Size(279, 145);
            this.gbPropietario.TabIndex = 30;
            this.gbPropietario.TabStop = false;
            this.gbPropietario.Text = "Propietario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Nombre y Apellido";
            // 
            // tbNombrePropietario
            // 
            this.tbNombrePropietario.Location = new System.Drawing.Point(26, 56);
            this.tbNombrePropietario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombrePropietario.Name = "tbNombrePropietario";
            this.tbNombrePropietario.Size = new System.Drawing.Size(212, 22);
            this.tbNombrePropietario.TabIndex = 31;
            // 
            // tbDniPropietario
            // 
            this.tbDniPropietario.Location = new System.Drawing.Point(24, 110);
            this.tbDniPropietario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDniPropietario.Name = "tbDniPropietario";
            this.tbDniPropietario.Size = new System.Drawing.Size(214, 22);
            this.tbDniPropietario.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "DNI";
            // 
            // AgregarPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 733);
            this.Controls.Add(this.gbPropietario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCasa);
            this.Controls.Add(this.gbHotel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPrecioXNoche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudCantPersonas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoPropiedad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarPropiedad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar propiedad";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbHotel.ResumeLayout(false);
            this.gbHotel.PerformLayout();
            this.gbCasa.ResumeLayout(false);
            this.gbCasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimoDias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPropiedad5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPropiedad4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPropiedad3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPropiedad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPropiedad1)).EndInit();
            this.gbPropietario.ResumeLayout(false);
            this.gbPropietario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cmbTipoPropiedad;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbDireccion;
        public System.Windows.Forms.TextBox tbLocalidad;
        public System.Windows.Forms.ComboBox cmbProvincias;
        public System.Windows.Forms.NumericUpDown nudCantPersonas;
        public System.Windows.Forms.TextBox tbPrecioXNoche;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox gbHotel;
        public System.Windows.Forms.GroupBox gbCasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbNumHabitacion;
        public System.Windows.Forms.ComboBox cmbTipoHabitacion;
        public System.Windows.Forms.TextBox tbNombreHotel;
        public System.Windows.Forms.ComboBox cmbCantEstrellas;
        public System.Windows.Forms.CheckBox cbDesayuno;
        public System.Windows.Forms.CheckBox cbPileta;
        public System.Windows.Forms.CheckBox cbMascotas;
        public System.Windows.Forms.CheckBox cbLimpieza;
        public System.Windows.Forms.CheckBox cbCochera;
        public System.Windows.Forms.CheckBox cbWifi;
        public System.Windows.Forms.NumericUpDown nudMinimoDias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.OpenFileDialog ofdImagen;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.PictureBox pbImagenPropiedad1;
        public System.Windows.Forms.PictureBox pbImagenPropiedad5;
        public System.Windows.Forms.PictureBox pbImagenPropiedad4;
        public System.Windows.Forms.PictureBox pbImagenPropiedad3;
        public System.Windows.Forms.PictureBox pbImagenPropiedad2;
        public System.Windows.Forms.TextBox tbDescripcion;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSeleccionarImagen;
        public System.Windows.Forms.GroupBox gbPropietario;
        public System.Windows.Forms.TextBox tbDniPropietario;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox tbNombrePropietario;
        private System.Windows.Forms.Label label14;
    }
}