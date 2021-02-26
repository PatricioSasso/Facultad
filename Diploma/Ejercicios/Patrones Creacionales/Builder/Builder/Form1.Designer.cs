namespace Builder
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
			this.btnPC = new System.Windows.Forms.Button();
			this.btnNotebook = new System.Windows.Forms.Button();
			this.btnTablet = new System.Windows.Forms.Button();
			this.btnSmart = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnPC
			// 
			this.btnPC.Location = new System.Drawing.Point(21, 51);
			this.btnPC.Name = "btnPC";
			this.btnPC.Size = new System.Drawing.Size(173, 30);
			this.btnPC.TabIndex = 0;
			this.btnPC.Text = "PC de escritorio";
			this.btnPC.UseVisualStyleBackColor = true;
			this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
			// 
			// btnNotebook
			// 
			this.btnNotebook.Location = new System.Drawing.Point(21, 87);
			this.btnNotebook.Name = "btnNotebook";
			this.btnNotebook.Size = new System.Drawing.Size(173, 30);
			this.btnNotebook.TabIndex = 1;
			this.btnNotebook.Text = "Notebook";
			this.btnNotebook.UseVisualStyleBackColor = true;
			this.btnNotebook.Click += new System.EventHandler(this.btnNotebook_Click);
			// 
			// btnTablet
			// 
			this.btnTablet.Location = new System.Drawing.Point(21, 123);
			this.btnTablet.Name = "btnTablet";
			this.btnTablet.Size = new System.Drawing.Size(173, 30);
			this.btnTablet.TabIndex = 2;
			this.btnTablet.Text = "Tablet";
			this.btnTablet.UseVisualStyleBackColor = true;
			this.btnTablet.Click += new System.EventHandler(this.btnTablet_Click);
			// 
			// btnSmart
			// 
			this.btnSmart.Location = new System.Drawing.Point(21, 159);
			this.btnSmart.Name = "btnSmart";
			this.btnSmart.Size = new System.Drawing.Size(173, 30);
			this.btnSmart.TabIndex = 3;
			this.btnSmart.Text = "SmartPhone";
			this.btnSmart.UseVisualStyleBackColor = true;
			this.btnSmart.Click += new System.EventHandler(this.btnSmart_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(239, 48);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(342, 140);
			this.textBox1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 219);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnSmart);
			this.Controls.Add(this.btnTablet);
			this.Controls.Add(this.btnNotebook);
			this.Controls.Add(this.btnPC);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPC;
		private System.Windows.Forms.Button btnNotebook;
		private System.Windows.Forms.Button btnTablet;
		private System.Windows.Forms.Button btnSmart;
		private System.Windows.Forms.TextBox textBox1;
	}
}

