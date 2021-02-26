namespace Command
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
			this.txtTV = new System.Windows.Forms.TextBox();
			this.btnDeshacer = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.btnOnOff = new System.Windows.Forms.Button();
			this.cBajar = new System.Windows.Forms.Button();
			this.Subir = new System.Windows.Forms.Button();
			this.vBajar = new System.Windows.Forms.Button();
			this.vSubir = new System.Windows.Forms.Button();
			this.b12 = new System.Windows.Forms.Button();
			this.b11 = new System.Windows.Forms.Button();
			this.b10 = new System.Windows.Forms.Button();
			this.b9 = new System.Windows.Forms.Button();
			this.b8 = new System.Windows.Forms.Button();
			this.b7 = new System.Windows.Forms.Button();
			this.b6 = new System.Windows.Forms.Button();
			this.b5 = new System.Windows.Forms.Button();
			this.b4 = new System.Windows.Forms.Button();
			this.b3 = new System.Windows.Forms.Button();
			this.b2 = new System.Windows.Forms.Button();
			this.b1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtTV
			// 
			this.txtTV.Location = new System.Drawing.Point(179, 25);
			this.txtTV.Margin = new System.Windows.Forms.Padding(1);
			this.txtTV.Multiline = true;
			this.txtTV.Name = "txtTV";
			this.txtTV.Size = new System.Drawing.Size(407, 238);
			this.txtTV.TabIndex = 41;
			// 
			// btnDeshacer
			// 
			this.btnDeshacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeshacer.Location = new System.Drawing.Point(51, 282);
			this.btnDeshacer.Margin = new System.Windows.Forms.Padding(1);
			this.btnDeshacer.Name = "btnDeshacer";
			this.btnDeshacer.Size = new System.Drawing.Size(77, 29);
			this.btnDeshacer.TabIndex = 40;
			this.btnDeshacer.Text = "Deshacer";
			this.btnDeshacer.UseVisualStyleBackColor = true;
			this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(109, 222);
			this.Label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(42, 13);
			this.Label2.TabIndex = 39;
			this.Label2.Text = "PROG";
			this.Label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(39, 222);
			this.Label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(31, 13);
			this.Label1.TabIndex = 38;
			this.Label1.Text = "VOL";
			// 
			// btnOnOff
			// 
			this.btnOnOff.BackColor = System.Drawing.Color.IndianRed;
			this.btnOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOnOff.Location = new System.Drawing.Point(39, 313);
			this.btnOnOff.Margin = new System.Windows.Forms.Padding(1);
			this.btnOnOff.Name = "btnOnOff";
			this.btnOnOff.Size = new System.Drawing.Size(101, 31);
			this.btnOnOff.TabIndex = 37;
			this.btnOnOff.Text = "ON / OFF";
			this.btnOnOff.UseVisualStyleBackColor = false;
			this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
			// 
			// cBajar
			// 
			this.cBajar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cBajar.Location = new System.Drawing.Point(115, 240);
			this.cBajar.Margin = new System.Windows.Forms.Padding(1);
			this.cBajar.Name = "cBajar";
			this.cBajar.Size = new System.Drawing.Size(26, 26);
			this.cBajar.TabIndex = 36;
			this.cBajar.Text = "-";
			this.cBajar.UseVisualStyleBackColor = true;
			this.cBajar.Click += new System.EventHandler(this.cBajar_Click);
			// 
			// Subir
			// 
			this.Subir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Subir.Location = new System.Drawing.Point(115, 189);
			this.Subir.Margin = new System.Windows.Forms.Padding(1);
			this.Subir.Name = "Subir";
			this.Subir.Size = new System.Drawing.Size(26, 29);
			this.Subir.TabIndex = 35;
			this.Subir.Text = "+";
			this.Subir.UseVisualStyleBackColor = true;
			this.Subir.Click += new System.EventHandler(this.Subir_Click);
			// 
			// vBajar
			// 
			this.vBajar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vBajar.Location = new System.Drawing.Point(39, 240);
			this.vBajar.Margin = new System.Windows.Forms.Padding(1);
			this.vBajar.Name = "vBajar";
			this.vBajar.Size = new System.Drawing.Size(26, 26);
			this.vBajar.TabIndex = 34;
			this.vBajar.Text = "-";
			this.vBajar.UseVisualStyleBackColor = true;
			this.vBajar.Click += new System.EventHandler(this.vBajar_Click);
			// 
			// vSubir
			// 
			this.vSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vSubir.Location = new System.Drawing.Point(39, 189);
			this.vSubir.Margin = new System.Windows.Forms.Padding(1);
			this.vSubir.Name = "vSubir";
			this.vSubir.Size = new System.Drawing.Size(26, 29);
			this.vSubir.TabIndex = 33;
			this.vSubir.Text = "+";
			this.vSubir.UseVisualStyleBackColor = true;
			this.vSubir.Click += new System.EventHandler(this.vSubir_Click);
			// 
			// b12
			// 
			this.b12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b12.Location = new System.Drawing.Point(115, 142);
			this.b12.Margin = new System.Windows.Forms.Padding(1);
			this.b12.Name = "b12";
			this.b12.Size = new System.Drawing.Size(26, 26);
			this.b12.TabIndex = 32;
			this.b12.Text = "12";
			this.b12.UseVisualStyleBackColor = true;
			// 
			// b11
			// 
			this.b11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b11.Location = new System.Drawing.Point(77, 142);
			this.b11.Margin = new System.Windows.Forms.Padding(1);
			this.b11.Name = "b11";
			this.b11.Size = new System.Drawing.Size(26, 26);
			this.b11.TabIndex = 31;
			this.b11.Text = "11";
			this.b11.UseVisualStyleBackColor = true;
			// 
			// b10
			// 
			this.b10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b10.Location = new System.Drawing.Point(39, 142);
			this.b10.Margin = new System.Windows.Forms.Padding(1);
			this.b10.Name = "b10";
			this.b10.Size = new System.Drawing.Size(26, 26);
			this.b10.TabIndex = 30;
			this.b10.Text = "10";
			this.b10.UseVisualStyleBackColor = true;
			// 
			// b9
			// 
			this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b9.Location = new System.Drawing.Point(115, 102);
			this.b9.Margin = new System.Windows.Forms.Padding(1);
			this.b9.Name = "b9";
			this.b9.Size = new System.Drawing.Size(26, 26);
			this.b9.TabIndex = 29;
			this.b9.Text = "9";
			this.b9.UseVisualStyleBackColor = true;
			// 
			// b8
			// 
			this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b8.Location = new System.Drawing.Point(77, 102);
			this.b8.Margin = new System.Windows.Forms.Padding(1);
			this.b8.Name = "b8";
			this.b8.Size = new System.Drawing.Size(26, 26);
			this.b8.TabIndex = 28;
			this.b8.Text = "8";
			this.b8.UseVisualStyleBackColor = true;
			// 
			// b7
			// 
			this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b7.Location = new System.Drawing.Point(39, 102);
			this.b7.Margin = new System.Windows.Forms.Padding(1);
			this.b7.Name = "b7";
			this.b7.Size = new System.Drawing.Size(26, 26);
			this.b7.TabIndex = 27;
			this.b7.Text = "7";
			this.b7.UseVisualStyleBackColor = true;
			// 
			// b6
			// 
			this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b6.Location = new System.Drawing.Point(115, 63);
			this.b6.Margin = new System.Windows.Forms.Padding(1);
			this.b6.Name = "b6";
			this.b6.Size = new System.Drawing.Size(26, 26);
			this.b6.TabIndex = 26;
			this.b6.Text = "6";
			this.b6.UseVisualStyleBackColor = true;
			// 
			// b5
			// 
			this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b5.Location = new System.Drawing.Point(77, 63);
			this.b5.Margin = new System.Windows.Forms.Padding(1);
			this.b5.Name = "b5";
			this.b5.Size = new System.Drawing.Size(26, 26);
			this.b5.TabIndex = 25;
			this.b5.Text = "5";
			this.b5.UseVisualStyleBackColor = true;
			// 
			// b4
			// 
			this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b4.Location = new System.Drawing.Point(39, 63);
			this.b4.Margin = new System.Windows.Forms.Padding(1);
			this.b4.Name = "b4";
			this.b4.Size = new System.Drawing.Size(26, 26);
			this.b4.TabIndex = 24;
			this.b4.Text = "4";
			this.b4.UseVisualStyleBackColor = true;
			// 
			// b3
			// 
			this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b3.Location = new System.Drawing.Point(115, 25);
			this.b3.Margin = new System.Windows.Forms.Padding(1);
			this.b3.Name = "b3";
			this.b3.Size = new System.Drawing.Size(26, 26);
			this.b3.TabIndex = 23;
			this.b3.Text = "3";
			this.b3.UseVisualStyleBackColor = true;
			// 
			// b2
			// 
			this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b2.Location = new System.Drawing.Point(77, 25);
			this.b2.Margin = new System.Windows.Forms.Padding(1);
			this.b2.Name = "b2";
			this.b2.Size = new System.Drawing.Size(26, 26);
			this.b2.TabIndex = 22;
			this.b2.Text = "2";
			this.b2.UseVisualStyleBackColor = true;
			// 
			// b1
			// 
			this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b1.Location = new System.Drawing.Point(39, 25);
			this.b1.Margin = new System.Windows.Forms.Padding(1);
			this.b1.Name = "b1";
			this.b1.Size = new System.Drawing.Size(26, 26);
			this.b1.TabIndex = 21;
			this.b1.Text = "1";
			this.b1.UseVisualStyleBackColor = true;
			this.b1.Click += new System.EventHandler(this.b1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 357);
			this.Controls.Add(this.txtTV);
			this.Controls.Add(this.btnDeshacer);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnOnOff);
			this.Controls.Add(this.cBajar);
			this.Controls.Add(this.Subir);
			this.Controls.Add(this.vBajar);
			this.Controls.Add(this.vSubir);
			this.Controls.Add(this.b12);
			this.Controls.Add(this.b11);
			this.Controls.Add(this.b10);
			this.Controls.Add(this.b9);
			this.Controls.Add(this.b8);
			this.Controls.Add(this.b7);
			this.Controls.Add(this.b6);
			this.Controls.Add(this.b5);
			this.Controls.Add(this.b4);
			this.Controls.Add(this.b3);
			this.Controls.Add(this.b2);
			this.Controls.Add(this.b1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.TextBox txtTV;
		internal System.Windows.Forms.Button btnDeshacer;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button btnOnOff;
		internal System.Windows.Forms.Button cBajar;
		internal System.Windows.Forms.Button Subir;
		internal System.Windows.Forms.Button vBajar;
		internal System.Windows.Forms.Button vSubir;
		internal System.Windows.Forms.Button b12;
		internal System.Windows.Forms.Button b11;
		internal System.Windows.Forms.Button b10;
		internal System.Windows.Forms.Button b9;
		internal System.Windows.Forms.Button b8;
		internal System.Windows.Forms.Button b7;
		internal System.Windows.Forms.Button b6;
		internal System.Windows.Forms.Button b5;
		internal System.Windows.Forms.Button b4;
		internal System.Windows.Forms.Button b3;
		internal System.Windows.Forms.Button b2;
		internal System.Windows.Forms.Button b1;
	}
}

