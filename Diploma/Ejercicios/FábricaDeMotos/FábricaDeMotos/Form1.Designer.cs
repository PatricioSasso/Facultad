namespace FábricaDeMotos
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
            this.CrearScooter = new System.Windows.Forms.Button();
            this.CrearEnduro = new System.Windows.Forms.Button();
            this.CrearPistero = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CrearScooter
            // 
            this.CrearScooter.Location = new System.Drawing.Point(12, 12);
            this.CrearScooter.Name = "CrearScooter";
            this.CrearScooter.Size = new System.Drawing.Size(165, 23);
            this.CrearScooter.TabIndex = 0;
            this.CrearScooter.Text = "Crear Scooter";
            this.CrearScooter.UseVisualStyleBackColor = true;
            this.CrearScooter.Click += new System.EventHandler(this.CrearScooter_Click);
            // 
            // CrearEnduro
            // 
            this.CrearEnduro.Location = new System.Drawing.Point(12, 41);
            this.CrearEnduro.Name = "CrearEnduro";
            this.CrearEnduro.Size = new System.Drawing.Size(165, 23);
            this.CrearEnduro.TabIndex = 1;
            this.CrearEnduro.Text = "Crear Enduro";
            this.CrearEnduro.UseVisualStyleBackColor = true;
            this.CrearEnduro.Click += new System.EventHandler(this.CrearEnduro_Click);
            // 
            // CrearPistero
            // 
            this.CrearPistero.Location = new System.Drawing.Point(12, 70);
            this.CrearPistero.Name = "CrearPistero";
            this.CrearPistero.Size = new System.Drawing.Size(165, 23);
            this.CrearPistero.TabIndex = 2;
            this.CrearPistero.Text = "Crear Pistero";
            this.CrearPistero.UseVisualStyleBackColor = true;
            this.CrearPistero.Click += new System.EventHandler(this.CrearPistero_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 267);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CrearPistero);
            this.Controls.Add(this.CrearEnduro);
            this.Controls.Add(this.CrearScooter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CrearScooter;
        private System.Windows.Forms.Button CrearEnduro;
        private System.Windows.Forms.Button CrearPistero;
        private System.Windows.Forms.TextBox textBox1;
    }
}

