namespace AlquileresTemporarios_TP2LAB2
{
    partial class RegistrarHuesped
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarHuesped));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.lDNI = new System.Windows.Forms.Label();
            this.lFecNacimiento = new System.Windows.Forms.Label();
            this.dtpFecNacimiento = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(15, 178);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 32);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(99, 178);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 32);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(12, 22);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(15, 38);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(162, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(15, 90);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(162, 20);
            this.tbDNI.TabIndex = 5;
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Location = new System.Drawing.Point(12, 74);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(26, 13);
            this.lDNI.TabIndex = 4;
            this.lDNI.Text = "DNI";
            // 
            // lFecNacimiento
            // 
            this.lFecNacimiento.AutoSize = true;
            this.lFecNacimiento.Location = new System.Drawing.Point(12, 126);
            this.lFecNacimiento.Name = "lFecNacimiento";
            this.lFecNacimiento.Size = new System.Drawing.Size(84, 13);
            this.lFecNacimiento.TabIndex = 6;
            this.lFecNacimiento.Text = "Fec. Nacimiento";
            // 
            // dtpFecNacimiento
            // 
            this.dtpFecNacimiento.Location = new System.Drawing.Point(15, 142);
            this.dtpFecNacimiento.Name = "dtpFecNacimiento";
            this.dtpFecNacimiento.Size = new System.Drawing.Size(162, 20);
            this.dtpFecNacimiento.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 223);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(195, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(162, 17);
            this.toolStripStatusLabel1.Text = "Ingrese los datos del huesped";
            // 
            // RegistrarHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 245);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtpFecNacimiento);
            this.Controls.Add(this.lFecNacimiento);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.lDNI);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarHuesped";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Huesped";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.Label lFecNacimiento;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbDNI;
        public System.Windows.Forms.DateTimePicker dtpFecNacimiento;
    }
}