namespace TemplateMethod
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
			this.Label1 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.cmbFormaPago = new System.Windows.Forms.ComboBox();
			this.grdProductos = new System.Windows.Forms.DataGridView();
			this.btnMostrador = new System.Windows.Forms.Button();
			this.btnEnvio = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(241, 233);
			this.Label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(34, 13);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "Total:";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(294, 232);
			this.txtTotal.Margin = new System.Windows.Forms.Padding(1);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(108, 20);
			this.txtTotal.TabIndex = 10;
			// 
			// cmbFormaPago
			// 
			this.cmbFormaPago.FormattingEnabled = true;
			this.cmbFormaPago.Location = new System.Drawing.Point(51, 163);
			this.cmbFormaPago.Margin = new System.Windows.Forms.Padding(1);
			this.cmbFormaPago.Name = "cmbFormaPago";
			this.cmbFormaPago.Size = new System.Drawing.Size(130, 21);
			this.cmbFormaPago.TabIndex = 9;
			// 
			// grdProductos
			// 
			this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdProductos.Location = new System.Drawing.Point(29, 10);
			this.grdProductos.Margin = new System.Windows.Forms.Padding(1);
			this.grdProductos.Name = "grdProductos";
			this.grdProductos.RowTemplate.Height = 40;
			this.grdProductos.Size = new System.Drawing.Size(430, 113);
			this.grdProductos.TabIndex = 8;
			// 
			// btnMostrador
			// 
			this.btnMostrador.Location = new System.Drawing.Point(36, 198);
			this.btnMostrador.Margin = new System.Windows.Forms.Padding(1);
			this.btnMostrador.Name = "btnMostrador";
			this.btnMostrador.Size = new System.Drawing.Size(164, 21);
			this.btnMostrador.TabIndex = 7;
			this.btnMostrador.Text = "Cerrar venta x mostrador";
			this.btnMostrador.UseVisualStyleBackColor = true;
			this.btnMostrador.Click += new System.EventHandler(this.btnMostrador_Click);
			// 
			// btnEnvio
			// 
			this.btnEnvio.Location = new System.Drawing.Point(36, 230);
			this.btnEnvio.Margin = new System.Windows.Forms.Padding(1);
			this.btnEnvio.Name = "btnEnvio";
			this.btnEnvio.Size = new System.Drawing.Size(164, 21);
			this.btnEnvio.TabIndex = 6;
			this.btnEnvio.Text = "Cerrar venta con envío";
			this.btnEnvio.UseVisualStyleBackColor = true;
			this.btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 273);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.cmbFormaPago);
			this.Controls.Add(this.grdProductos);
			this.Controls.Add(this.btnMostrador);
			this.Controls.Add(this.btnEnvio);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtTotal;
		internal System.Windows.Forms.ComboBox cmbFormaPago;
		internal System.Windows.Forms.DataGridView grdProductos;
		internal System.Windows.Forms.Button btnMostrador;
		internal System.Windows.Forms.Button btnEnvio;
	}
}

