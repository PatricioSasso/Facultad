namespace ejercicio16
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeCelsius = new System.Windows.Forms.CheckBox();
            this.DeFaren = new System.Windows.Forms.CheckBox();
            this.DeKelvin = new System.Windows.Forms.CheckBox();
            this.DeRankine = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Convertrankine = new System.Windows.Forms.CheckBox();
            this.ConvertKelvin = new System.Windows.Forms.CheckBox();
            this.Convertfaren = new System.Windows.Forms.CheckBox();
            this.ConvertCelsius = new System.Windows.Forms.CheckBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el valor a transformar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione unidad";
            // 
            // DeCelsius
            // 
            this.DeCelsius.AutoSize = true;
            this.DeCelsius.Location = new System.Drawing.Point(408, 39);
            this.DeCelsius.Name = "DeCelsius";
            this.DeCelsius.Size = new System.Drawing.Size(59, 17);
            this.DeCelsius.TabIndex = 3;
            this.DeCelsius.Text = "Celsius";
            this.DeCelsius.UseVisualStyleBackColor = true;
            // 
            // DeFaren
            // 
            this.DeFaren.AutoSize = true;
            this.DeFaren.Location = new System.Drawing.Point(408, 63);
            this.DeFaren.Name = "DeFaren";
            this.DeFaren.Size = new System.Drawing.Size(76, 17);
            this.DeFaren.TabIndex = 4;
            this.DeFaren.Text = "Fahrenheit";
            this.DeFaren.UseVisualStyleBackColor = true;
            // 
            // DeKelvin
            // 
            this.DeKelvin.AutoSize = true;
            this.DeKelvin.Location = new System.Drawing.Point(408, 87);
            this.DeKelvin.Name = "DeKelvin";
            this.DeKelvin.Size = new System.Drawing.Size(55, 17);
            this.DeKelvin.TabIndex = 5;
            this.DeKelvin.Text = "Kelvin";
            this.DeKelvin.UseVisualStyleBackColor = true;
            // 
            // DeRankine
            // 
            this.DeRankine.AutoSize = true;
            this.DeRankine.Location = new System.Drawing.Point(408, 111);
            this.DeRankine.Name = "DeRankine";
            this.DeRankine.Size = new System.Drawing.Size(66, 17);
            this.DeRankine.TabIndex = 6;
            this.DeRankine.Text = "Rankine";
            this.DeRankine.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleccione Unidad a transformar";
            // 
            // Convertrankine
            // 
            this.Convertrankine.AutoSize = true;
            this.Convertrankine.Location = new System.Drawing.Point(685, 110);
            this.Convertrankine.Name = "Convertrankine";
            this.Convertrankine.Size = new System.Drawing.Size(66, 17);
            this.Convertrankine.TabIndex = 11;
            this.Convertrankine.Text = "Rankine";
            this.Convertrankine.UseVisualStyleBackColor = true;
            // 
            // ConvertKelvin
            // 
            this.ConvertKelvin.AutoSize = true;
            this.ConvertKelvin.Location = new System.Drawing.Point(685, 86);
            this.ConvertKelvin.Name = "ConvertKelvin";
            this.ConvertKelvin.Size = new System.Drawing.Size(55, 17);
            this.ConvertKelvin.TabIndex = 10;
            this.ConvertKelvin.Text = "Kelvin";
            this.ConvertKelvin.UseVisualStyleBackColor = true;
            // 
            // Convertfaren
            // 
            this.Convertfaren.AutoSize = true;
            this.Convertfaren.Location = new System.Drawing.Point(685, 62);
            this.Convertfaren.Name = "Convertfaren";
            this.Convertfaren.Size = new System.Drawing.Size(76, 17);
            this.Convertfaren.TabIndex = 9;
            this.Convertfaren.Text = "Fahrenheit";
            this.Convertfaren.UseVisualStyleBackColor = true;
            // 
            // ConvertCelsius
            // 
            this.ConvertCelsius.AutoSize = true;
            this.ConvertCelsius.Location = new System.Drawing.Point(685, 38);
            this.ConvertCelsius.Name = "ConvertCelsius";
            this.ConvertCelsius.Size = new System.Drawing.Size(59, 17);
            this.ConvertCelsius.TabIndex = 8;
            this.ConvertCelsius.Text = "Celsius";
            this.ConvertCelsius.UseVisualStyleBackColor = true;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(549, 135);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(82, 35);
            this.Calcular.TabIndex = 12;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor Final";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "De:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "A:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Convertrankine);
            this.Controls.Add(this.ConvertKelvin);
            this.Controls.Add(this.Convertfaren);
            this.Controls.Add(this.ConvertCelsius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeRankine);
            this.Controls.Add(this.DeKelvin);
            this.Controls.Add(this.DeFaren);
            this.Controls.Add(this.DeCelsius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox DeCelsius;
        private System.Windows.Forms.CheckBox DeFaren;
        private System.Windows.Forms.CheckBox DeKelvin;
        private System.Windows.Forms.CheckBox DeRankine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Convertrankine;
        private System.Windows.Forms.CheckBox ConvertKelvin;
        private System.Windows.Forms.CheckBox Convertfaren;
        private System.Windows.Forms.CheckBox ConvertCelsius;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

