namespace Facade
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
			this.txtInvitados = new System.Windows.Forms.TextBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbModerada = new System.Windows.Forms.RadioButton();
			this.rdbCompleta = new System.Windows.Forms.RadioButton();
			this.btnCasamiento = new System.Windows.Forms.Button();
			this.txtPresupuesto = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label3.Location = new System.Drawing.Point(37, 17);
			this.Label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(229, 25);
			this.Label3.TabIndex = 17;
			this.Label3.Text = "Organización de eventos";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(25, 182);
			this.Label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(93, 13);
			this.Label2.TabIndex = 16;
			this.Label2.Text = "Fecha del evento:";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(23, 157);
			this.Label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(112, 13);
			this.Label1.TabIndex = 15;
			this.Label1.Text = "Cantidad de invitados:";
			// 
			// txtInvitados
			// 
			this.txtInvitados.Location = new System.Drawing.Point(137, 156);
			this.txtInvitados.Margin = new System.Windows.Forms.Padding(1);
			this.txtInvitados.Name = "txtInvitados";
			this.txtInvitados.Size = new System.Drawing.Size(70, 20);
			this.txtInvitados.TabIndex = 14;
			this.txtInvitados.Text = "150";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(137, 179);
			this.dtpFecha.Margin = new System.Windows.Forms.Padding(1);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(70, 20);
			this.dtpFecha.TabIndex = 13;
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.rdbModerada);
			this.GroupBox1.Controls.Add(this.rdbCompleta);
			this.GroupBox1.Location = new System.Drawing.Point(26, 66);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(1);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(1);
			this.GroupBox1.Size = new System.Drawing.Size(229, 70);
			this.GroupBox1.TabIndex = 12;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Nivel de gasto estimado";
			// 
			// rdbModerada
			// 
			this.rdbModerada.AutoSize = true;
			this.rdbModerada.Checked = true;
			this.rdbModerada.Location = new System.Drawing.Point(129, 25);
			this.rdbModerada.Margin = new System.Windows.Forms.Padding(1);
			this.rdbModerada.Name = "rdbModerada";
			this.rdbModerada.Size = new System.Drawing.Size(103, 17);
			this.rdbModerada.TabIndex = 2;
			this.rdbModerada.TabStop = true;
			this.rdbModerada.Text = "Fiesta moderada";
			this.rdbModerada.UseVisualStyleBackColor = true;
			// 
			// rdbCompleta
			// 
			this.rdbCompleta.AutoSize = true;
			this.rdbCompleta.Location = new System.Drawing.Point(16, 25);
			this.rdbCompleta.Margin = new System.Windows.Forms.Padding(1);
			this.rdbCompleta.Name = "rdbCompleta";
			this.rdbCompleta.Size = new System.Drawing.Size(99, 17);
			this.rdbCompleta.TabIndex = 1;
			this.rdbCompleta.Text = "Fiesta completa";
			this.rdbCompleta.UseVisualStyleBackColor = true;
			// 
			// btnCasamiento
			// 
			this.btnCasamiento.Location = new System.Drawing.Point(62, 240);
			this.btnCasamiento.Margin = new System.Windows.Forms.Padding(1);
			this.btnCasamiento.Name = "btnCasamiento";
			this.btnCasamiento.Size = new System.Drawing.Size(153, 22);
			this.btnCasamiento.TabIndex = 10;
			this.btnCasamiento.Text = "Casamiento";
			this.btnCasamiento.UseVisualStyleBackColor = true;
			this.btnCasamiento.Click += new System.EventHandler(this.btnCasamiento_Click);
			// 
			// txtPresupuesto
			// 
			this.txtPresupuesto.Location = new System.Drawing.Point(281, 10);
			this.txtPresupuesto.Margin = new System.Windows.Forms.Padding(1);
			this.txtPresupuesto.Multiline = true;
			this.txtPresupuesto.Name = "txtPresupuesto";
			this.txtPresupuesto.Size = new System.Drawing.Size(490, 405);
			this.txtPresupuesto.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 445);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtInvitados);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.btnCasamiento);
			this.Controls.Add(this.txtPresupuesto);
			this.Name = "Form1";
			this.Text = "Form1";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtInvitados;
		internal System.Windows.Forms.DateTimePicker dtpFecha;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton rdbModerada;
		internal System.Windows.Forms.RadioButton rdbCompleta;
		internal System.Windows.Forms.Button btnCasamiento;
		internal System.Windows.Forms.TextBox txtPresupuesto;
	}
}

