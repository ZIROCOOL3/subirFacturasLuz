namespace SubirFacturasLuz
{
    partial class FrmPrincipal
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
            this.OfdSelecionarArchivo = new System.Windows.Forms.OpenFileDialog();
            this.BtnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutaARchivo = new System.Windows.Forms.TextBox();
            this.DtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSubir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OfdSelecionarArchivo
            // 
            this.OfdSelecionarArchivo.FileName = "openFileDialog1";
            // 
            // BtnSeleccionarArchivo
            // 
            this.BtnSeleccionarArchivo.Location = new System.Drawing.Point(354, 27);
            this.BtnSeleccionarArchivo.Name = "BtnSeleccionarArchivo";
            this.BtnSeleccionarArchivo.Size = new System.Drawing.Size(112, 23);
            this.BtnSeleccionarArchivo.TabIndex = 0;
            this.BtnSeleccionarArchivo.Text = "Selecionar Archivo";
            this.BtnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.BtnSeleccionarArchivo.Click += new System.EventHandler(this.BtnSeleccionarArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ruta del archivo";
            // 
            // txtRutaARchivo
            // 
            this.txtRutaARchivo.Location = new System.Drawing.Point(12, 29);
            this.txtRutaARchivo.Name = "txtRutaARchivo";
            this.txtRutaARchivo.ReadOnly = true;
            this.txtRutaARchivo.Size = new System.Drawing.Size(336, 20);
            this.txtRutaARchivo.TabIndex = 2;
            // 
            // DtpPeriodo
            // 
            this.DtpPeriodo.CustomFormat = "MM/yyyy";
            this.DtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpPeriodo.Location = new System.Drawing.Point(12, 72);
            this.DtpPeriodo.Name = "DtpPeriodo";
            this.DtpPeriodo.Size = new System.Drawing.Size(97, 20);
            this.DtpPeriodo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Periodo";
            // 
            // BtnSubir
            // 
            this.BtnSubir.Location = new System.Drawing.Point(205, 210);
            this.BtnSubir.Name = "BtnSubir";
            this.BtnSubir.Size = new System.Drawing.Size(75, 23);
            this.BtnSubir.TabIndex = 5;
            this.BtnSubir.Text = "Subir";
            this.BtnSubir.UseVisualStyleBackColor = true;
            this.BtnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Consumo";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(15, 118);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(94, 20);
            this.txtConsumo.TabIndex = 7;
            // 
            // TxtImporte
            // 
            this.TxtImporte.Location = new System.Drawing.Point(15, 155);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(94, 20);
            this.TxtImporte.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Importe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtImporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSubir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpPeriodo);
            this.Controls.Add(this.txtRutaARchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSeleccionarArchivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subir Facturas de Luz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OfdSelecionarArchivo;
        private System.Windows.Forms.Button BtnSeleccionarArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutaARchivo;
        private System.Windows.Forms.DateTimePicker DtpPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSubir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

