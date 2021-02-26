namespace PatronesEstructurales
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
			this.grpPizzeria = new System.Windows.Forms.GroupBox();
			this.btnRestaurante = new System.Windows.Forms.Button();
			this.rdbCadena = new System.Windows.Forms.RadioButton();
			this.btnTakeAway = new System.Windows.Forms.Button();
			this.rdbArtesanal = new System.Windows.Forms.RadioButton();
			this.txtTareas = new System.Windows.Forms.TextBox();
			this.grpPizzeria.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpPizzeria
			// 
			this.grpPizzeria.Controls.Add(this.btnRestaurante);
			this.grpPizzeria.Controls.Add(this.rdbCadena);
			this.grpPizzeria.Controls.Add(this.btnTakeAway);
			this.grpPizzeria.Controls.Add(this.rdbArtesanal);
			this.grpPizzeria.Location = new System.Drawing.Point(29, 37);
			this.grpPizzeria.Margin = new System.Windows.Forms.Padding(1);
			this.grpPizzeria.Name = "grpPizzeria";
			this.grpPizzeria.Padding = new System.Windows.Forms.Padding(1);
			this.grpPizzeria.Size = new System.Drawing.Size(189, 224);
			this.grpPizzeria.TabIndex = 7;
			this.grpPizzeria.TabStop = false;
			this.grpPizzeria.Text = "Pizzería";
			// 
			// btnRestaurante
			// 
			this.btnRestaurante.Location = new System.Drawing.Point(6, 134);
			this.btnRestaurante.Margin = new System.Windows.Forms.Padding(1);
			this.btnRestaurante.Name = "btnRestaurante";
			this.btnRestaurante.Size = new System.Drawing.Size(175, 28);
			this.btnRestaurante.TabIndex = 2;
			this.btnRestaurante.Text = "A la mesa";
			this.btnRestaurante.UseVisualStyleBackColor = true;
			this.btnRestaurante.Click += new System.EventHandler(this.btnRestaurante_Click);
			// 
			// rdbCadena
			// 
			this.rdbCadena.AutoSize = true;
			this.rdbCadena.Location = new System.Drawing.Point(101, 53);
			this.rdbCadena.Margin = new System.Windows.Forms.Padding(1);
			this.rdbCadena.Name = "rdbCadena";
			this.rdbCadena.Size = new System.Drawing.Size(64, 17);
			this.rdbCadena.TabIndex = 4;
			this.rdbCadena.Text = "Romario";
			this.rdbCadena.UseVisualStyleBackColor = true;
			// 
			// btnTakeAway
			// 
			this.btnTakeAway.Location = new System.Drawing.Point(6, 93);
			this.btnTakeAway.Margin = new System.Windows.Forms.Padding(1);
			this.btnTakeAway.Name = "btnTakeAway";
			this.btnTakeAway.Size = new System.Drawing.Size(175, 28);
			this.btnTakeAway.TabIndex = 1;
			this.btnTakeAway.Text = "Take away";
			this.btnTakeAway.UseVisualStyleBackColor = true;
			this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
			// 
			// rdbArtesanal
			// 
			this.rdbArtesanal.AutoSize = true;
			this.rdbArtesanal.Checked = true;
			this.rdbArtesanal.Location = new System.Drawing.Point(6, 53);
			this.rdbArtesanal.Margin = new System.Windows.Forms.Padding(1);
			this.rdbArtesanal.Name = "rdbArtesanal";
			this.rdbArtesanal.Size = new System.Drawing.Size(72, 17);
			this.rdbArtesanal.TabIndex = 3;
			this.rdbArtesanal.TabStop = true;
			this.rdbArtesanal.Text = "La Nonna";
			this.rdbArtesanal.UseVisualStyleBackColor = true;
			// 
			// txtTareas
			// 
			this.txtTareas.Location = new System.Drawing.Point(253, 37);
			this.txtTareas.Margin = new System.Windows.Forms.Padding(1);
			this.txtTareas.Multiline = true;
			this.txtTareas.Name = "txtTareas";
			this.txtTareas.Size = new System.Drawing.Size(422, 226);
			this.txtTareas.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 308);
			this.Controls.Add(this.grpPizzeria);
			this.Controls.Add(this.txtTareas);
			this.Name = "Form1";
			this.Text = "Form1";
			this.grpPizzeria.ResumeLayout(false);
			this.grpPizzeria.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.GroupBox grpPizzeria;
		internal System.Windows.Forms.Button btnRestaurante;
		internal System.Windows.Forms.RadioButton rdbCadena;
		internal System.Windows.Forms.Button btnTakeAway;
		internal System.Windows.Forms.RadioButton rdbArtesanal;
		internal System.Windows.Forms.TextBox txtTareas;
	}
}

