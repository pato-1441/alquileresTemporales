﻿namespace AlquileresTemporarios_TP2LAB2
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
            this.Imagenes = new System.Windows.Forms.DataGridViewImageColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPropiedad
            // 
            this.btnAgregarPropiedad.Location = new System.Drawing.Point(436, 32);
            this.btnAgregarPropiedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPropiedad.Name = "btnAgregarPropiedad";
            this.btnAgregarPropiedad.Size = new System.Drawing.Size(237, 82);
            this.btnAgregarPropiedad.TabIndex = 2;
            this.btnAgregarPropiedad.Text = "Agregar propiedad";
            this.btnAgregarPropiedad.UseVisualStyleBackColor = true;
            this.btnAgregarPropiedad.Click += new System.EventHandler(this.btnAgregarPropiedad_Click);
            // 
            // btnConsultarReserva
            // 
            this.btnConsultarReserva.Location = new System.Drawing.Point(691, 32);
            this.btnConsultarReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarReserva.Name = "btnConsultarReserva";
            this.btnConsultarReserva.Size = new System.Drawing.Size(237, 82);
            this.btnConsultarReserva.TabIndex = 3;
            this.btnConsultarReserva.Text = "Consultar Reserva";
            this.btnConsultarReserva.UseVisualStyleBackColor = true;
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Location = new System.Drawing.Point(948, 32);
            this.btnEliminarReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(237, 82);
            this.btnEliminarReserva.TabIndex = 4;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // dgvPropiedades
            // 
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
            this.Imagenes});
            this.dgvPropiedades.Location = new System.Drawing.Point(436, 143);
            this.dgvPropiedades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPropiedades.Name = "dgvPropiedades";
            this.dgvPropiedades.RowHeadersWidth = 51;
            this.dgvPropiedades.RowTemplate.Height = 24;
            this.dgvPropiedades.Size = new System.Drawing.Size(941, 496);
            this.dgvPropiedades.TabIndex = 5;
            // 
            // Imagenes
            // 
            this.Imagenes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Imagenes.HeaderText = "Imagenes";
            this.Imagenes.MinimumWidth = 6;
            this.Imagenes.Name = "Imagenes";
            this.Imagenes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ubicación";
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(39, 219);
            this.tbUbicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(203, 22);
            this.tbUbicacion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad de personas";
            // 
            // nudCantPersonas
            // 
            this.nudCantPersonas.Location = new System.Drawing.Point(249, 220);
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
            this.nudCantPersonas.Size = new System.Drawing.Size(143, 22);
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
            this.checkBox1.Location = new System.Drawing.Point(27, 33);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(39, 446);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(353, 111);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Características";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(225, 33);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(91, 20);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.Text = "Desayuno";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(27, 69);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(63, 20);
            this.checkBox5.TabIndex = 17;
            this.checkBox5.Text = "Pileta";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(225, 69);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(88, 20);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "Mascotas";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(116, 69);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 20);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Limpieza";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(116, 33);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 20);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Cochera";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(39, 585);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(353, 54);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(27, 54);
            this.fechaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaDesde.MinDate = new System.DateTime(2023, 10, 16, 0, 0, 0, 0);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(287, 22);
            this.fechaDesde.TabIndex = 17;
            this.fechaDesde.ValueChanged += new System.EventHandler(this.fechaDesde_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Desde";
            // 
            // lbfechaHasta
            // 
            this.lbfechaHasta.AutoSize = true;
            this.lbfechaHasta.Location = new System.Drawing.Point(23, 94);
            this.lbfechaHasta.Name = "lbfechaHasta";
            this.lbfechaHasta.Size = new System.Drawing.Size(43, 16);
            this.lbfechaHasta.TabIndex = 20;
            this.lbfechaHasta.Text = "Hasta";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(27, 117);
            this.fechaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(287, 22);
            this.fechaHasta.TabIndex = 19;
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.label4);
            this.gbFecha.Controls.Add(this.lbfechaHasta);
            this.gbFecha.Controls.Add(this.fechaDesde);
            this.gbFecha.Controls.Add(this.fechaHasta);
            this.gbFecha.Location = new System.Drawing.Point(39, 263);
            this.gbFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFecha.Size = new System.Drawing.Size(353, 165);
            this.gbFecha.TabIndex = 21;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AlquileresTemporarios_TP2LAB2.Properties.Resources.iconoAlquileres;
            this.pictureBox1.Location = new System.Drawing.Point(39, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 666);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler Temporal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPropiedades;
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
        private System.Windows.Forms.DataGridViewImageColumn Imagenes;
    }
}

