namespace drawingMR202832
{
    partial class Lineas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtEspaciado = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnDibular = new System.Windows.Forms.Button();
            this.areaDibujo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPuntoInicioX = new System.Windows.Forms.TextBox();
            this.txtPuntoInicioY = new System.Windows.Forms.TextBox();
            this.txtPuntoFinX = new System.Windows.Forms.TextBox();
            this.txtPuntoFinY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.areaDibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espaciado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(124, 36);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(207, 22);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtEspaciado
            // 
            this.txtEspaciado.Location = new System.Drawing.Point(124, 87);
            this.txtEspaciado.Name = "txtEspaciado";
            this.txtEspaciado.Size = new System.Drawing.Size(207, 22);
            this.txtEspaciado.TabIndex = 4;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "amarillo",
            "rojo",
            "azul",
            "negro"});
            this.cmbColor.Location = new System.Drawing.Point(124, 332);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(207, 24);
            this.cmbColor.TabIndex = 5;
            // 
            // btnDibular
            // 
            this.btnDibular.Location = new System.Drawing.Point(40, 373);
            this.btnDibular.Name = "btnDibular";
            this.btnDibular.Size = new System.Drawing.Size(291, 65);
            this.btnDibular.TabIndex = 6;
            this.btnDibular.Text = "DIBUJAR LÍNEAS";
            this.btnDibular.UseVisualStyleBackColor = true;
            this.btnDibular.Click += new System.EventHandler(this.btnDibular_Click);
            // 
            // areaDibujo
            // 
            this.areaDibujo.Location = new System.Drawing.Point(385, 13);
            this.areaDibujo.Name = "areaDibujo";
            this.areaDibujo.Size = new System.Drawing.Size(403, 425);
            this.areaDibujo.TabIndex = 7;
            this.areaDibujo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Punto Inicio X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Punto Inicio Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Punto Fin X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Punto Fin Y";
            // 
            // txtPuntoInicioX
            // 
            this.txtPuntoInicioX.Location = new System.Drawing.Point(124, 136);
            this.txtPuntoInicioX.Name = "txtPuntoInicioX";
            this.txtPuntoInicioX.Size = new System.Drawing.Size(207, 22);
            this.txtPuntoInicioX.TabIndex = 12;
            // 
            // txtPuntoInicioY
            // 
            this.txtPuntoInicioY.Location = new System.Drawing.Point(124, 183);
            this.txtPuntoInicioY.Name = "txtPuntoInicioY";
            this.txtPuntoInicioY.Size = new System.Drawing.Size(207, 22);
            this.txtPuntoInicioY.TabIndex = 13;
            // 
            // txtPuntoFinX
            // 
            this.txtPuntoFinX.Location = new System.Drawing.Point(124, 232);
            this.txtPuntoFinX.Name = "txtPuntoFinX";
            this.txtPuntoFinX.Size = new System.Drawing.Size(207, 22);
            this.txtPuntoFinX.TabIndex = 14;
            // 
            // txtPuntoFinY
            // 
            this.txtPuntoFinY.Location = new System.Drawing.Point(124, 281);
            this.txtPuntoFinY.Name = "txtPuntoFinY";
            this.txtPuntoFinY.Size = new System.Drawing.Size(207, 22);
            this.txtPuntoFinY.TabIndex = 15;
            // 
            // Lineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPuntoFinY);
            this.Controls.Add(this.txtPuntoFinX);
            this.Controls.Add(this.txtPuntoInicioY);
            this.Controls.Add(this.txtPuntoInicioX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.areaDibujo);
            this.Controls.Add(this.btnDibular);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.txtEspaciado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lineas";
            this.Text = "Líneas";
            ((System.ComponentModel.ISupportInitialize)(this.areaDibujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtEspaciado;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnDibular;
        private System.Windows.Forms.PictureBox areaDibujo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPuntoInicioX;
        private System.Windows.Forms.TextBox txtPuntoInicioY;
        private System.Windows.Forms.TextBox txtPuntoFinX;
        private System.Windows.Forms.TextBox txtPuntoFinY;
    }
}