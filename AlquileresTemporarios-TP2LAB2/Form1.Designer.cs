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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAgregarPropiedad = new System.Windows.Forms.Button();
            this.btnConsultarReserva = new System.Windows.Forms.Button();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCantPersonas = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbfechaHasta = new System.Windows.Forms.Label();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnConsultarReserva.Location = new System.Drawing.Point(518, 26);
            this.btnConsultarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarReserva.Name = "btnConsultarReserva";
            this.btnConsultarReserva.Size = new System.Drawing.Size(178, 67);
            this.btnConsultarReserva.TabIndex = 3;
            this.btnConsultarReserva.Text = "Consultar Reserva";
            this.btnConsultarReserva.UseVisualStyleBackColor = true;
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Location = new System.Drawing.Point(711, 26);
            this.btnEliminarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(178, 67);
            this.btnEliminarReserva.TabIndex = 4;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(706, 403);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ubicación";
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(29, 178);
            this.tbUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(153, 20);
            this.tbUbicacion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad de personas";
            // 
            // nudCantPersonas
            // 
            this.nudCantPersonas.Location = new System.Drawing.Point(187, 179);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 27);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Wi-Fi";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(29, 362);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(265, 90);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Características";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(169, 27);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(74, 17);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.Text = "Desayuno";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(20, 56);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(52, 17);
            this.checkBox5.TabIndex = 17;
            this.checkBox5.Text = "Pileta";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(169, 56);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 17);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "Mascotas";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(87, 56);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 17);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Limpieza";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(87, 27);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Cochera";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(29, 475);
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
            this.gbFecha.Location = new System.Drawing.Point(29, 214);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(265, 134);
            this.gbFecha.TabIndex = 21;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudCantPersonas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUbicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.btnConsultarReserva);
            this.Controls.Add(this.btnAgregarPropiedad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler Temporal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarPropiedad;
        private System.Windows.Forms.Button btnConsultarReserva;
        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCantPersonas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbfechaHasta;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

