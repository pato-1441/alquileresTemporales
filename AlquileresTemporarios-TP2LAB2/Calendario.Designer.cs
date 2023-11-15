namespace AlquileresTemporarios_TP2LAB2
{
    partial class Calendario
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
            this.mcCalendario = new System.Windows.Forms.MonthCalendar();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnImportarCalendario = new System.Windows.Forms.Button();
            this.btnExportarCal = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcCalendario
            // 
            this.mcCalendario.Location = new System.Drawing.Point(47, 13);
            this.mcCalendario.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcCalendario.MaxDate = new System.DateTime(2024, 1, 31, 0, 0, 0, 0);
            this.mcCalendario.MinDate = new System.DateTime(2023, 10, 30, 0, 0, 0, 0);
            this.mcCalendario.Name = "mcCalendario";
            this.mcCalendario.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(24, 235);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 34);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 273);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(383, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(270, 20);
            this.toolStripStatusLabel1.Text = "Calendario de reservas de la propiedad";
            // 
            // btnImportarCalendario
            // 
            this.btnImportarCalendario.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnImportarCalendario.Location = new System.Drawing.Point(143, 235);
            this.btnImportarCalendario.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportarCalendario.Name = "btnImportarCalendario";
            this.btnImportarCalendario.Size = new System.Drawing.Size(100, 34);
            this.btnImportarCalendario.TabIndex = 3;
            this.btnImportarCalendario.Text = "Importar";
            this.btnImportarCalendario.UseVisualStyleBackColor = true;
            // 
            // btnExportarCal
            // 
            this.btnExportarCal.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnExportarCal.Location = new System.Drawing.Point(261, 235);
            this.btnExportarCal.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportarCal.Name = "btnExportarCal";
            this.btnExportarCal.Size = new System.Drawing.Size(100, 34);
            this.btnExportarCal.TabIndex = 4;
            this.btnExportarCal.Text = "Exportar";
            this.btnExportarCal.UseVisualStyleBackColor = true;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 299);
            this.ControlBox = false;
            this.Controls.Add(this.btnExportarCal);
            this.Controls.Add(this.btnImportarCalendario);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mcCalendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendario";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MonthCalendar mcCalendario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.Button btnImportarCalendario;
        public System.Windows.Forms.Button btnExportarCal;
    }
}