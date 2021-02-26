namespace ChainOfResponsability
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
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.cmbNivel = new System.Windows.Forms.ComboBox();
			this.txtIncidente = new System.Windows.Forms.TextBox();
			this.btnTicket = new System.Windows.Forms.Button();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label3.Location = new System.Drawing.Point(119, 20);
			this.Label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(254, 24);
			this.Label3.TabIndex = 12;
			this.Label3.Text = "Sistema de tickets de soporte";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(19, 106);
			this.Label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(54, 13);
			this.Label2.TabIndex = 11;
			this.Label2.Text = "Incidente:";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(19, 66);
			this.Label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(93, 13);
			this.Label1.TabIndex = 10;
			this.Label1.Text = "Nivel complejidad:";
			// 
			// cmbNivel
			// 
			this.cmbNivel.FormattingEnabled = true;
			this.cmbNivel.Location = new System.Drawing.Point(123, 65);
			this.cmbNivel.Margin = new System.Windows.Forms.Padding(1);
			this.cmbNivel.Name = "cmbNivel";
			this.cmbNivel.Size = new System.Drawing.Size(246, 21);
			this.cmbNivel.TabIndex = 9;
			// 
			// txtIncidente
			// 
			this.txtIncidente.Location = new System.Drawing.Point(79, 104);
			this.txtIncidente.Margin = new System.Windows.Forms.Padding(1);
			this.txtIncidente.Name = "txtIncidente";
			this.txtIncidente.Size = new System.Drawing.Size(476, 20);
			this.txtIncidente.TabIndex = 8;
			// 
			// btnTicket
			// 
			this.btnTicket.Location = new System.Drawing.Point(202, 133);
			this.btnTicket.Margin = new System.Windows.Forms.Padding(1);
			this.btnTicket.Name = "btnTicket";
			this.btnTicket.Size = new System.Drawing.Size(165, 29);
			this.btnTicket.TabIndex = 7;
			this.btnTicket.Text = "Nuevo ticket de soporte";
			this.btnTicket.UseVisualStyleBackColor = true;
			this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.AutoSize = true;
			this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRespuesta.Location = new System.Drawing.Point(76, 187);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(0, 18);
			this.lblRespuesta.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 262);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.cmbNivel);
			this.Controls.Add(this.txtIncidente);
			this.Controls.Add(this.btnTicket);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ComboBox cmbNivel;
		internal System.Windows.Forms.TextBox txtIncidente;
		internal System.Windows.Forms.Button btnTicket;
		private System.Windows.Forms.Label lblRespuesta;
	}
}

