namespace Strategy
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
			this.btnCenaSuegros = new System.Windows.Forms.Button();
			this.btnCenaRomantica = new System.Windows.Forms.Button();
			this.txtPreparacionMesa = new System.Windows.Forms.TextBox();
			this.btnCenaSolo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCenaSuegros
			// 
			this.btnCenaSuegros.Location = new System.Drawing.Point(16, 127);
			this.btnCenaSuegros.Margin = new System.Windows.Forms.Padding(1);
			this.btnCenaSuegros.Name = "btnCenaSuegros";
			this.btnCenaSuegros.Size = new System.Drawing.Size(202, 22);
			this.btnCenaSuegros.TabIndex = 7;
			this.btnCenaSuegros.Text = "Mesa para cena con suegros";
			this.btnCenaSuegros.UseVisualStyleBackColor = true;
			this.btnCenaSuegros.Click += new System.EventHandler(this.btnCenaSuegros_Click);
			// 
			// btnCenaRomantica
			// 
			this.btnCenaRomantica.Location = new System.Drawing.Point(16, 77);
			this.btnCenaRomantica.Margin = new System.Windows.Forms.Padding(1);
			this.btnCenaRomantica.Name = "btnCenaRomantica";
			this.btnCenaRomantica.Size = new System.Drawing.Size(202, 22);
			this.btnCenaRomantica.TabIndex = 6;
			this.btnCenaRomantica.Text = "Mesa para cena romántica";
			this.btnCenaRomantica.UseVisualStyleBackColor = true;
			this.btnCenaRomantica.Click += new System.EventHandler(this.btnCenaRomantica_Click);
			// 
			// txtPreparacionMesa
			// 
			this.txtPreparacionMesa.Location = new System.Drawing.Point(254, 28);
			this.txtPreparacionMesa.Margin = new System.Windows.Forms.Padding(1);
			this.txtPreparacionMesa.Multiline = true;
			this.txtPreparacionMesa.Name = "txtPreparacionMesa";
			this.txtPreparacionMesa.Size = new System.Drawing.Size(471, 260);
			this.txtPreparacionMesa.TabIndex = 5;
			// 
			// btnCenaSolo
			// 
			this.btnCenaSolo.Location = new System.Drawing.Point(16, 28);
			this.btnCenaSolo.Margin = new System.Windows.Forms.Padding(1);
			this.btnCenaSolo.Name = "btnCenaSolo";
			this.btnCenaSolo.Size = new System.Drawing.Size(202, 22);
			this.btnCenaSolo.TabIndex = 4;
			this.btnCenaSolo.Text = "Mesa para cena solitaria";
			this.btnCenaSolo.UseVisualStyleBackColor = true;
			this.btnCenaSolo.Click += new System.EventHandler(this.btnCenaSolo_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 303);
			this.Controls.Add(this.btnCenaSuegros);
			this.Controls.Add(this.btnCenaRomantica);
			this.Controls.Add(this.txtPreparacionMesa);
			this.Controls.Add(this.btnCenaSolo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnCenaSuegros;
		internal System.Windows.Forms.Button btnCenaRomantica;
		internal System.Windows.Forms.TextBox txtPreparacionMesa;
		internal System.Windows.Forms.Button btnCenaSolo;
	}
}

