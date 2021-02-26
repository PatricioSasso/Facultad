namespace Prototype
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
			this.chkExtraBacon = new System.Windows.Forms.CheckBox();
			this.chkExtraQueso = new System.Windows.Forms.CheckBox();
			this.btnMN = new System.Windows.Forms.Button();
			this.btnCBO = new System.Windows.Forms.Button();
			this.btnMP = new System.Windows.Forms.Button();
			this.btnBM = new System.Windows.Forms.Button();
			this.lstHamburgesas = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// chkExtraBacon
			// 
			this.chkExtraBacon.AutoSize = true;
			this.chkExtraBacon.Location = new System.Drawing.Point(22, 235);
			this.chkExtraBacon.Margin = new System.Windows.Forms.Padding(1);
			this.chkExtraBacon.Name = "chkExtraBacon";
			this.chkExtraBacon.Size = new System.Drawing.Size(83, 17);
			this.chkExtraBacon.TabIndex = 12;
			this.chkExtraBacon.Text = "Extra bacon";
			this.chkExtraBacon.UseVisualStyleBackColor = true;
			// 
			// chkExtraQueso
			// 
			this.chkExtraQueso.AutoSize = true;
			this.chkExtraQueso.Location = new System.Drawing.Point(22, 206);
			this.chkExtraQueso.Margin = new System.Windows.Forms.Padding(1);
			this.chkExtraQueso.Name = "chkExtraQueso";
			this.chkExtraQueso.Size = new System.Drawing.Size(82, 17);
			this.chkExtraQueso.TabIndex = 11;
			this.chkExtraQueso.Text = "Extra queso";
			this.chkExtraQueso.UseVisualStyleBackColor = true;
			// 
			// btnMN
			// 
			this.btnMN.Location = new System.Drawing.Point(22, 153);
			this.btnMN.Margin = new System.Windows.Forms.Padding(1);
			this.btnMN.Name = "btnMN";
			this.btnMN.Size = new System.Drawing.Size(91, 25);
			this.btnMN.TabIndex = 10;
			this.btnMN.Text = "McNífica";
			this.btnMN.UseVisualStyleBackColor = true;
			this.btnMN.Click += new System.EventHandler(this.btnMN_Click);
			// 
			// btnCBO
			// 
			this.btnCBO.Location = new System.Drawing.Point(22, 103);
			this.btnCBO.Margin = new System.Windows.Forms.Padding(1);
			this.btnCBO.Name = "btnCBO";
			this.btnCBO.Size = new System.Drawing.Size(91, 25);
			this.btnCBO.TabIndex = 9;
			this.btnCBO.Text = "CBO";
			this.btnCBO.UseVisualStyleBackColor = true;
			this.btnCBO.Click += new System.EventHandler(this.btnCBO_Click);
			// 
			// btnMP
			// 
			this.btnMP.Location = new System.Drawing.Point(22, 55);
			this.btnMP.Margin = new System.Windows.Forms.Padding(1);
			this.btnMP.Name = "btnMP";
			this.btnMP.Size = new System.Drawing.Size(91, 25);
			this.btnMP.TabIndex = 8;
			this.btnMP.Text = "McPollo";
			this.btnMP.UseVisualStyleBackColor = true;
			this.btnMP.Click += new System.EventHandler(this.btnMP_Click);
			// 
			// btnBM
			// 
			this.btnBM.Location = new System.Drawing.Point(22, 10);
			this.btnBM.Margin = new System.Windows.Forms.Padding(1);
			this.btnBM.Name = "btnBM";
			this.btnBM.Size = new System.Drawing.Size(91, 25);
			this.btnBM.TabIndex = 7;
			this.btnBM.Text = "BigMac";
			this.btnBM.UseVisualStyleBackColor = true;
			this.btnBM.Click += new System.EventHandler(this.btnBM_Click);
			// 
			// lstHamburgesas
			// 
			this.lstHamburgesas.FormattingEnabled = true;
			this.lstHamburgesas.Location = new System.Drawing.Point(158, 10);
			this.lstHamburgesas.Margin = new System.Windows.Forms.Padding(1);
			this.lstHamburgesas.Name = "lstHamburgesas";
			this.lstHamburgesas.Size = new System.Drawing.Size(632, 173);
			this.lstHamburgesas.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 268);
			this.Controls.Add(this.lstHamburgesas);
			this.Controls.Add(this.chkExtraBacon);
			this.Controls.Add(this.chkExtraQueso);
			this.Controls.Add(this.btnMN);
			this.Controls.Add(this.btnCBO);
			this.Controls.Add(this.btnMP);
			this.Controls.Add(this.btnBM);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.CheckBox chkExtraBacon;
		internal System.Windows.Forms.CheckBox chkExtraQueso;
		internal System.Windows.Forms.Button btnMN;
		internal System.Windows.Forms.Button btnCBO;
		internal System.Windows.Forms.Button btnMP;
		internal System.Windows.Forms.Button btnBM;
		internal System.Windows.Forms.ListBox lstHamburgesas;
	}
}

