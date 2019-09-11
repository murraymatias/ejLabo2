namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvetPeso = new System.Windows.Forms.Button();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.lblPesoA = new System.Windows.Forms.Label();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(27, 79);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(27, 110);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(27, 141);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso";
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageList = this.imageList1;
            this.btnLockCotizacion.Location = new System.Drawing.Point(184, 3);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(81, 40);
            this.btnLockCotizacion.TabIndex = 3;
            this.btnLockCotizacion.Text = "button1";
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(184, 73);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(81, 25);
            this.btnConvertEuro.TabIndex = 4;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(184, 104);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(81, 25);
            this.btnConvertDolar.TabIndex = 5;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            // 
            // btnConvetPeso
            // 
            this.btnConvetPeso.Location = new System.Drawing.Point(184, 135);
            this.btnConvetPeso.Name = "btnConvetPeso";
            this.btnConvetPeso.Size = new System.Drawing.Size(81, 25);
            this.btnConvetPeso.TabIndex = 6;
            this.btnConvetPeso.Text = "->";
            this.btnConvetPeso.UseVisualStyleBackColor = true;
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(84, 76);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(82, 20);
            this.txtEuro.TabIndex = 7;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(84, 107);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(82, 20);
            this.txtDolar.TabIndex = 8;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(84, 138);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(82, 20);
            this.txtPeso.TabIndex = 9;
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(298, 15);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(82, 20);
            this.txtCotizacionEuro.TabIndex = 10;
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(386, 15);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(82, 20);
            this.txtCotizacionDolar.TabIndex = 11;
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(474, 15);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(82, 20);
            this.txtCotizacionPeso.TabIndex = 12;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(298, 76);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.ReadOnly = true;
            this.txtEuroAEuro.Size = new System.Drawing.Size(82, 20);
            this.txtEuroAEuro.TabIndex = 13;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(298, 107);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.ReadOnly = true;
            this.txtDolarAEuro.Size = new System.Drawing.Size(82, 20);
            this.txtDolarAEuro.TabIndex = 14;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(298, 138);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.ReadOnly = true;
            this.txtPesoAEuro.Size = new System.Drawing.Size(82, 20);
            this.txtPesoAEuro.TabIndex = 15;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(386, 138);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.ReadOnly = true;
            this.txtPesoADolar.Size = new System.Drawing.Size(82, 20);
            this.txtPesoADolar.TabIndex = 18;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(386, 107);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.ReadOnly = true;
            this.txtDolarADolar.Size = new System.Drawing.Size(82, 20);
            this.txtDolarADolar.TabIndex = 17;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(386, 76);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.ReadOnly = true;
            this.txtEuroADolar.Size = new System.Drawing.Size(82, 20);
            this.txtEuroADolar.TabIndex = 16;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(474, 138);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.ReadOnly = true;
            this.txtPesoAPeso.Size = new System.Drawing.Size(82, 20);
            this.txtPesoAPeso.TabIndex = 21;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(474, 107);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.ReadOnly = true;
            this.txtDolarAPeso.Size = new System.Drawing.Size(82, 20);
            this.txtDolarAPeso.TabIndex = 20;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(474, 76);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.ReadOnly = true;
            this.txtEuroAPeso.Size = new System.Drawing.Size(82, 20);
            this.txtEuroAPeso.TabIndex = 19;
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Location = new System.Drawing.Point(299, 60);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(29, 13);
            this.lblEuroA.TabIndex = 22;
            this.lblEuroA.Text = "Euro";
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.Location = new System.Drawing.Point(383, 60);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(32, 13);
            this.lblDolarA.TabIndex = 23;
            this.lblDolarA.Text = "Dolar";
            // 
            // lblPesoA
            // 
            this.lblPesoA.AutoSize = true;
            this.lblPesoA.Location = new System.Drawing.Point(471, 60);
            this.lblPesoA.Name = "lblPesoA";
            this.lblPesoA.Size = new System.Drawing.Size(31, 13);
            this.lblPesoA.TabIndex = 24;
            this.lblPesoA.Text = "Peso";
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Location = new System.Drawing.Point(81, 17);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(56, 13);
            this.lblCotizacion.TabIndex = 25;
            this.lblCotizacion.Text = "Cotizacion";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 192);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.lblPesoA);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.btnConvetPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvetPeso;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label lblPesoA;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.ImageList imageList1;
    }
}

