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
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbHotel.SuspendLayout();
            this.gbCasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimoDias)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoPropiedad
            // 
            this.cmbTipoPropiedad.FormattingEnabled = true;
            this.cmbTipoPropiedad.Items.AddRange(new object[] {
            "Habitacion de hotel",
            "Casa",
            "Casa fin de semana"});
            this.cmbTipoPropiedad.Location = new System.Drawing.Point(37, 56);
            this.cmbTipoPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPropiedad.Name = "cmbTipoPropiedad";
            this.cmbTipoPropiedad.Size = new System.Drawing.Size(161, 21);
            this.cmbTipoPropiedad.TabIndex = 0;
            this.cmbTipoPropiedad.SelectedIndexChanged += new System.EventHandler(this.cbTipoPropiedad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de propiedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Localidad";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(37, 215);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(105, 20);
            this.tbDireccion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Direccion";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(37, 161);
            this.tbLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(105, 20);
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
            this.cmbProvincias.Location = new System.Drawing.Point(37, 104);
            this.cmbProvincias.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(161, 21);
            this.cmbProvincias.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad de personas";
            // 
            // nudCantPersonas
            // 
            this.nudCantPersonas.Location = new System.Drawing.Point(38, 273);
            this.nudCantPersonas.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantPersonas.Name = "nudCantPersonas";
            this.nudCantPersonas.Size = new System.Drawing.Size(90, 20);
            this.nudCantPersonas.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Precio por noche";
            // 
            // tbPrecioXNoche
            // 
            this.tbPrecioXNoche.Location = new System.Drawing.Point(37, 331);
            this.tbPrecioXNoche.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrecioXNoche.Name = "tbPrecioXNoche";
            this.tbPrecioXNoche.Size = new System.Drawing.Size(105, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(250, 382);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(222, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Características";
            // 
            // cbDesayuno
            // 
            this.cbDesayuno.AutoSize = true;
            this.cbDesayuno.Location = new System.Drawing.Point(140, 27);
            this.cbDesayuno.Margin = new System.Windows.Forms.Padding(2);
            this.cbDesayuno.Name = "cbDesayuno";
            this.cbDesayuno.Size = new System.Drawing.Size(74, 17);
            this.cbDesayuno.TabIndex = 11;
            this.cbDesayuno.Text = "Desayuno";
            this.cbDesayuno.UseVisualStyleBackColor = true;
            // 
            // cbPileta
            // 
            this.cbPileta.AutoSize = true;
            this.cbPileta.Location = new System.Drawing.Point(15, 56);
            this.cbPileta.Margin = new System.Windows.Forms.Padding(2);
            this.cbPileta.Name = "cbPileta";
            this.cbPileta.Size = new System.Drawing.Size(52, 17);
            this.cbPileta.TabIndex = 12;
            this.cbPileta.Text = "Pileta";
            this.cbPileta.UseVisualStyleBackColor = true;
            // 
            // cbMascotas
            // 
            this.cbMascotas.AutoSize = true;
            this.cbMascotas.Location = new System.Drawing.Point(140, 56);
            this.cbMascotas.Margin = new System.Windows.Forms.Padding(2);
            this.cbMascotas.Name = "cbMascotas";
            this.cbMascotas.Size = new System.Drawing.Size(72, 17);
            this.cbMascotas.TabIndex = 14;
            this.cbMascotas.Text = "Mascotas";
            this.cbMascotas.UseVisualStyleBackColor = true;
            // 
            // cbLimpieza
            // 
            this.cbLimpieza.AutoSize = true;
            this.cbLimpieza.Location = new System.Drawing.Point(68, 56);
            this.cbLimpieza.Margin = new System.Windows.Forms.Padding(2);
            this.cbLimpieza.Name = "cbLimpieza";
            this.cbLimpieza.Size = new System.Drawing.Size(67, 17);
            this.cbLimpieza.TabIndex = 13;
            this.cbLimpieza.Text = "Limpieza";
            this.cbLimpieza.UseVisualStyleBackColor = true;
            // 
            // cbCochera
            // 
            this.cbCochera.AutoSize = true;
            this.cbCochera.Location = new System.Drawing.Point(68, 27);
            this.cbCochera.Margin = new System.Windows.Forms.Padding(2);
            this.cbCochera.Name = "cbCochera";
            this.cbCochera.Size = new System.Drawing.Size(66, 17);
            this.cbCochera.TabIndex = 10;
            this.cbCochera.Text = "Cochera";
            this.cbCochera.UseVisualStyleBackColor = true;
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Location = new System.Drawing.Point(15, 27);
            this.cbWifi.Margin = new System.Windows.Forms.Padding(2);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(50, 17);
            this.cbWifi.TabIndex = 9;
            this.cbWifi.Text = "Wi-Fi";
            this.cbWifi.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(346, 507);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(314, 45);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(37, 507);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(303, 45);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbNumHabitacion
            // 
            this.tbNumHabitacion.Location = new System.Drawing.Point(19, 92);
            this.tbNumHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumHabitacion.Name = "tbNumHabitacion";
            this.tbNumHabitacion.Size = new System.Drawing.Size(105, 20);
            this.tbNumHabitacion.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "N° Habitación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
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
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(19, 151);
            this.cmbTipoHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(161, 21);
            this.cmbTipoHabitacion.TabIndex = 8;
            // 
            // tbNombreHotel
            // 
            this.tbNombreHotel.Location = new System.Drawing.Point(19, 39);
            this.tbNombreHotel.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreHotel.Name = "tbNombreHotel";
            this.tbNombreHotel.Size = new System.Drawing.Size(105, 20);
            this.tbNombreHotel.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
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
            this.gbHotel.Location = new System.Drawing.Point(250, 38);
            this.gbHotel.Name = "gbHotel";
            this.gbHotel.Size = new System.Drawing.Size(200, 325);
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
            this.cmbCantEstrellas.Location = new System.Drawing.Point(19, 206);
            this.cmbCantEstrellas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCantEstrellas.Name = "cmbCantEstrellas";
            this.cmbCantEstrellas.Size = new System.Drawing.Size(161, 21);
            this.cmbCantEstrellas.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 187);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cantidad de estrellas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Minimo de dias";
            // 
            // gbCasa
            // 
            this.gbCasa.Controls.Add(this.nudMinimoDias);
            this.gbCasa.Controls.Add(this.label12);
            this.gbCasa.Enabled = false;
            this.gbCasa.Location = new System.Drawing.Point(37, 382);
            this.gbCasa.Name = "gbCasa";
            this.gbCasa.Size = new System.Drawing.Size(200, 100);
            this.gbCasa.TabIndex = 28;
            this.gbCasa.TabStop = false;
            this.gbCasa.Text = "Casa";
            // 
            // nudMinimoDias
            // 
            this.nudMinimoDias.Location = new System.Drawing.Point(17, 46);
            this.nudMinimoDias.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudMinimoDias.Size = new System.Drawing.Size(163, 20);
            this.nudMinimoDias.TabIndex = 29;
            this.nudMinimoDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AgregarPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 581);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
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
    }
}