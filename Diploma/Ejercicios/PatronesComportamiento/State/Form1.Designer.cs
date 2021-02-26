namespace State
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
			this.btnFrenar = new System.Windows.Forms.Button();
			this.btnAcelerar = new System.Windows.Forms.Button();
			this.btnApagar = new System.Windows.Forms.Button();
			this.btnEncender = new System.Windows.Forms.Button();
			this.txtEstadoAuto = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.btnCombustible = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnFrenar
			// 
			this.btnFrenar.Location = new System.Drawing.Point(16, 160);
			this.btnFrenar.Margin = new System.Windows.Forms.Padding(1);
			this.btnFrenar.Name = "btnFrenar";
			this.btnFrenar.Size = new System.Drawing.Size(190, 21);
			this.btnFrenar.TabIndex = 14;
			this.btnFrenar.Text = "Frenar";
			this.btnFrenar.UseVisualStyleBackColor = true;
			this.btnFrenar.Click += new System.EventHandler(this.btnFrenar_Click);
			// 
			// btnAcelerar
			// 
			this.btnAcelerar.Location = new System.Drawing.Point(16, 129);
			this.btnAcelerar.Margin = new System.Windows.Forms.Padding(1);
			this.btnAcelerar.Name = "btnAcelerar";
			this.btnAcelerar.Size = new System.Drawing.Size(190, 21);
			this.btnAcelerar.TabIndex = 13;
			this.btnAcelerar.Text = "Acelerar";
			this.btnAcelerar.UseVisualStyleBackColor = true;
			this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
			// 
			// btnApagar
			// 
			this.btnApagar.Location = new System.Drawing.Point(16, 98);
			this.btnApagar.Margin = new System.Windows.Forms.Padding(1);
			this.btnApagar.Name = "btnApagar";
			this.btnApagar.Size = new System.Drawing.Size(190, 21);
			this.btnApagar.TabIndex = 12;
			this.btnApagar.Text = "Apagar";
			this.btnApagar.UseVisualStyleBackColor = true;
			this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
			// 
			// btnEncender
			// 
			this.btnEncender.Location = new System.Drawing.Point(16, 66);
			this.btnEncender.Margin = new System.Windows.Forms.Padding(1);
			this.btnEncender.Name = "btnEncender";
			this.btnEncender.Size = new System.Drawing.Size(190, 21);
			this.btnEncender.TabIndex = 11;
			this.btnEncender.Text = "Encender";
			this.btnEncender.UseVisualStyleBackColor = true;
			this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
			// 
			// txtEstadoAuto
			// 
			this.txtEstadoAuto.Location = new System.Drawing.Point(239, 19);
			this.txtEstadoAuto.Margin = new System.Windows.Forms.Padding(1);
			this.txtEstadoAuto.Multiline = true;
			this.txtEstadoAuto.Name = "txtEstadoAuto";
			this.txtEstadoAuto.Size = new System.Drawing.Size(314, 162);
			this.txtEstadoAuto.TabIndex = 10;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(16, 22);
			this.txtCantidad.Margin = new System.Windows.Forms.Padding(1);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(40, 20);
			this.txtCantidad.TabIndex = 9;
			this.txtCantidad.Text = "30";
			// 
			// btnCombustible
			// 
			this.btnCombustible.Location = new System.Drawing.Point(62, 19);
			this.btnCombustible.Margin = new System.Windows.Forms.Padding(1);
			this.btnCombustible.Name = "btnCombustible";
			this.btnCombustible.Size = new System.Drawing.Size(144, 21);
			this.btnCombustible.TabIndex = 8;
			this.btnCombustible.Text = "Cargar combustible";
			this.btnCombustible.UseVisualStyleBackColor = true;
			this.btnCombustible.Click += new System.EventHandler(this.btnCombustible_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 207);
			this.Controls.Add(this.btnFrenar);
			this.Controls.Add(this.btnAcelerar);
			this.Controls.Add(this.btnApagar);
			this.Controls.Add(this.btnEncender);
			this.Controls.Add(this.txtEstadoAuto);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.btnCombustible);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnFrenar;
		internal System.Windows.Forms.Button btnAcelerar;
		internal System.Windows.Forms.Button btnApagar;
		internal System.Windows.Forms.Button btnEncender;
		internal System.Windows.Forms.TextBox txtEstadoAuto;
		internal System.Windows.Forms.TextBox txtCantidad;
		internal System.Windows.Forms.Button btnCombustible;
	}
}

