namespace CreaCar
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
            this.buttonFiesta = new System.Windows.Forms.Button();
            this.buttonFocus = new System.Windows.Forms.Button();
            this.buttonSiena = new System.Windows.Forms.Button();
            this.buttonPalio = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonFiesta
            // 
            this.buttonFiesta.Location = new System.Drawing.Point(12, 33);
            this.buttonFiesta.Name = "buttonFiesta";
            this.buttonFiesta.Size = new System.Drawing.Size(115, 25);
            this.buttonFiesta.TabIndex = 0;
            this.buttonFiesta.Text = "Ford Fiesta";
            this.buttonFiesta.UseVisualStyleBackColor = true;
            this.buttonFiesta.Click += new System.EventHandler(this.buttonFiesta_Click);
            // 
            // buttonFocus
            // 
            this.buttonFocus.Location = new System.Drawing.Point(12, 64);
            this.buttonFocus.Name = "buttonFocus";
            this.buttonFocus.Size = new System.Drawing.Size(115, 25);
            this.buttonFocus.TabIndex = 1;
            this.buttonFocus.Text = "Ford Focus";
            this.buttonFocus.UseVisualStyleBackColor = true;
            this.buttonFocus.Click += new System.EventHandler(this.buttonFocus_Click);
            // 
            // buttonSiena
            // 
            this.buttonSiena.Location = new System.Drawing.Point(12, 95);
            this.buttonSiena.Name = "buttonSiena";
            this.buttonSiena.Size = new System.Drawing.Size(115, 25);
            this.buttonSiena.TabIndex = 2;
            this.buttonSiena.Text = "Fiat Siena";
            this.buttonSiena.UseVisualStyleBackColor = true;
            this.buttonSiena.Click += new System.EventHandler(this.buttonSiena_Click);
            // 
            // buttonPalio
            // 
            this.buttonPalio.Location = new System.Drawing.Point(12, 126);
            this.buttonPalio.Name = "buttonPalio";
            this.buttonPalio.Size = new System.Drawing.Size(115, 25);
            this.buttonPalio.TabIndex = 3;
            this.buttonPalio.Text = "Fiat Palio";
            this.buttonPalio.UseVisualStyleBackColor = true;
            this.buttonPalio.Click += new System.EventHandler(this.buttonPalio_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 118);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 192);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonPalio);
            this.Controls.Add(this.buttonSiena);
            this.Controls.Add(this.buttonFocus);
            this.Controls.Add(this.buttonFiesta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFiesta;
        private System.Windows.Forms.Button buttonFocus;
        private System.Windows.Forms.Button buttonSiena;
        private System.Windows.Forms.Button buttonPalio;
        private System.Windows.Forms.TextBox textBox1;
    }
}

