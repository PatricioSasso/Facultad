namespace PatronAdapter1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Main = new System.Windows.Forms.TextBox();
            this.btn_Acelerar = new System.Windows.Forms.Button();
            this.btn_Encender = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motor";
            // 
            // txt_Main
            // 
            this.txt_Main.Location = new System.Drawing.Point(12, 71);
            this.txt_Main.Multiline = true;
            this.txt_Main.Name = "txt_Main";
            this.txt_Main.Size = new System.Drawing.Size(240, 176);
            this.txt_Main.TabIndex = 2;
            // 
            // btn_Acelerar
            // 
            this.btn_Acelerar.Location = new System.Drawing.Point(96, 42);
            this.btn_Acelerar.Name = "btn_Acelerar";
            this.btn_Acelerar.Size = new System.Drawing.Size(75, 23);
            this.btn_Acelerar.TabIndex = 3;
            this.btn_Acelerar.Text = "Acelerar";
            this.btn_Acelerar.UseVisualStyleBackColor = true;
            this.btn_Acelerar.Click += new System.EventHandler(this.btn_Acelerar_Click);
            // 
            // btn_Encender
            // 
            this.btn_Encender.Location = new System.Drawing.Point(12, 42);
            this.btn_Encender.Name = "btn_Encender";
            this.btn_Encender.Size = new System.Drawing.Size(78, 23);
            this.btn_Encender.TabIndex = 4;
            this.btn_Encender.Text = "Encender";
            this.btn_Encender.UseVisualStyleBackColor = true;
            this.btn_Encender.Click += new System.EventHandler(this.btn_Encender_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Location = new System.Drawing.Point(177, 42);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(75, 23);
            this.btn_Apagar.TabIndex = 5;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 256);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Encender);
            this.Controls.Add(this.btn_Acelerar);
            this.Controls.Add(this.txt_Main);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Main;
        private System.Windows.Forms.Button btn_Acelerar;
        private System.Windows.Forms.Button btn_Encender;
        private System.Windows.Forms.Button btn_Apagar;
    }
}

