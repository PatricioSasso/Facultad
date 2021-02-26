namespace PatronComposite1
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_CrearCaja = new System.Windows.Forms.Button();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.txt_main = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_Caja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 308);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_CrearCaja
            // 
            this.btn_CrearCaja.Location = new System.Drawing.Point(12, 326);
            this.btn_CrearCaja.Name = "btn_CrearCaja";
            this.btn_CrearCaja.Size = new System.Drawing.Size(120, 23);
            this.btn_CrearCaja.TabIndex = 1;
            this.btn_CrearCaja.Text = "Crear Caja";
            this.btn_CrearCaja.UseVisualStyleBackColor = true;
            this.btn_CrearCaja.Click += new System.EventHandler(this.btn_CrearCaja_Click);
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Location = new System.Drawing.Point(13, 356);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(119, 23);
            this.btn_AgregarProducto.TabIndex = 2;
            this.btn_AgregarProducto.Text = "Agregar Producto";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // txt_main
            // 
            this.txt_main.Location = new System.Drawing.Point(138, 12);
            this.txt_main.Multiline = true;
            this.txt_main.Name = "txt_main";
            this.txt_main.Size = new System.Drawing.Size(310, 308);
            this.txt_main.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // txt_Caja
            // 
            this.txt_Caja.Location = new System.Drawing.Point(202, 327);
            this.txt_Caja.Name = "txt_Caja";
            this.txt_Caja.Size = new System.Drawing.Size(246, 22);
            this.txt_Caja.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // txt_Producto
            // 
            this.txt_Producto.Location = new System.Drawing.Point(202, 359);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(118, 22);
            this.txt_Producto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(380, 359);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(68, 22);
            this.txt_Precio.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 405);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Caja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_main);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.btn_CrearCaja);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_CrearCaja;
        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.TextBox txt_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_Caja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Precio;
    }
}

