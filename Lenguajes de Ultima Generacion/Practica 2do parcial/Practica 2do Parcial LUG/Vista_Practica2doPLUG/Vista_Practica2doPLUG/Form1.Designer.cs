namespace Vista_Practica2doPLUG
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxId2 = new System.Windows.Forms.TextBox();
            this.btn_EliminarInmobiliaria = new System.Windows.Forms.Button();
            this.btn_ModificarInmobiliaria = new System.Windows.Forms.Button();
            this.btn_AgregarInmobiliaria = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVenta = new System.Windows.Forms.TextBox();
            this.textBoxPublicacion = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.btn_EliminarInmueble = new System.Windows.Forms.Button();
            this.btn_ModificarInmueble = new System.Windows.Forms.Button();
            this.btn_AgregarInmueble = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_Id_Y_Direccion1 = new Vista_Practica2doPLUG.TextBox_Id_Y_Direccion();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.textBoxId2);
            this.groupBox1.Controls.Add(this.btn_EliminarInmobiliaria);
            this.groupBox1.Controls.Add(this.btn_ModificarInmobiliaria);
            this.groupBox1.Controls.Add(this.btn_AgregarInmobiliaria);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inmobiliaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(580, 146);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(155, 22);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxId2
            // 
            this.textBoxId2.Location = new System.Drawing.Point(580, 117);
            this.textBoxId2.Name = "textBoxId2";
            this.textBoxId2.Size = new System.Drawing.Size(155, 22);
            this.textBoxId2.TabIndex = 5;
            // 
            // btn_EliminarInmobiliaria
            // 
            this.btn_EliminarInmobiliaria.Location = new System.Drawing.Point(565, 85);
            this.btn_EliminarInmobiliaria.Name = "btn_EliminarInmobiliaria";
            this.btn_EliminarInmobiliaria.Size = new System.Drawing.Size(178, 26);
            this.btn_EliminarInmobiliaria.TabIndex = 4;
            this.btn_EliminarInmobiliaria.Text = "Eliminar";
            this.btn_EliminarInmobiliaria.UseVisualStyleBackColor = true;
            this.btn_EliminarInmobiliaria.Click += new System.EventHandler(this.btn_EliminarInmobiliaria_Click);
            // 
            // btn_ModificarInmobiliaria
            // 
            this.btn_ModificarInmobiliaria.Location = new System.Drawing.Point(565, 53);
            this.btn_ModificarInmobiliaria.Name = "btn_ModificarInmobiliaria";
            this.btn_ModificarInmobiliaria.Size = new System.Drawing.Size(178, 26);
            this.btn_ModificarInmobiliaria.TabIndex = 3;
            this.btn_ModificarInmobiliaria.Text = "Modificar";
            this.btn_ModificarInmobiliaria.UseVisualStyleBackColor = true;
            this.btn_ModificarInmobiliaria.Click += new System.EventHandler(this.btn_ModificarInmobiliaria_Click);
            // 
            // btn_AgregarInmobiliaria
            // 
            this.btn_AgregarInmobiliaria.Location = new System.Drawing.Point(565, 21);
            this.btn_AgregarInmobiliaria.Name = "btn_AgregarInmobiliaria";
            this.btn_AgregarInmobiliaria.Size = new System.Drawing.Size(178, 26);
            this.btn_AgregarInmobiliaria.TabIndex = 2;
            this.btn_AgregarInmobiliaria.Text = "Agregar";
            this.btn_AgregarInmobiliaria.UseVisualStyleBackColor = true;
            this.btn_AgregarInmobiliaria.Click += new System.EventHandler(this.btn_AgregarInmobiliaria_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(499, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxVenta);
            this.groupBox2.Controls.Add(this.textBoxPublicacion);
            this.groupBox2.Controls.Add(this.textBoxValor);
            this.groupBox2.Controls.Add(this.btn_EliminarInmueble);
            this.groupBox2.Controls.Add(this.btn_ModificarInmueble);
            this.groupBox2.Controls.Add(this.btn_AgregarInmueble);
            this.groupBox2.Controls.Add(this.textBox_Id_Y_Direccion1);
            this.groupBox2.Location = new System.Drawing.Point(777, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inmueble";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Publicacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Valor:";
            // 
            // textBoxVenta
            // 
            this.textBoxVenta.Location = new System.Drawing.Point(165, 241);
            this.textBoxVenta.Name = "textBoxVenta";
            this.textBoxVenta.Size = new System.Drawing.Size(155, 22);
            this.textBoxVenta.TabIndex = 7;
            this.textBoxVenta.Text = "3/3/2014";
            // 
            // textBoxPublicacion
            // 
            this.textBoxPublicacion.Location = new System.Drawing.Point(165, 213);
            this.textBoxPublicacion.Name = "textBoxPublicacion";
            this.textBoxPublicacion.Size = new System.Drawing.Size(155, 22);
            this.textBoxPublicacion.TabIndex = 6;
            this.textBoxPublicacion.Text = "1/1/2010";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(165, 184);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(155, 22);
            this.textBoxValor.TabIndex = 5;
            this.textBoxValor.Text = "1000001";
            // 
            // btn_EliminarInmueble
            // 
            this.btn_EliminarInmueble.Location = new System.Drawing.Point(150, 85);
            this.btn_EliminarInmueble.Name = "btn_EliminarInmueble";
            this.btn_EliminarInmueble.Size = new System.Drawing.Size(178, 26);
            this.btn_EliminarInmueble.TabIndex = 4;
            this.btn_EliminarInmueble.Text = "Eliminar";
            this.btn_EliminarInmueble.UseVisualStyleBackColor = true;
            this.btn_EliminarInmueble.Click += new System.EventHandler(this.btn_EliminarInmueble_Click);
            // 
            // btn_ModificarInmueble
            // 
            this.btn_ModificarInmueble.Location = new System.Drawing.Point(150, 53);
            this.btn_ModificarInmueble.Name = "btn_ModificarInmueble";
            this.btn_ModificarInmueble.Size = new System.Drawing.Size(178, 26);
            this.btn_ModificarInmueble.TabIndex = 3;
            this.btn_ModificarInmueble.Text = "Modificar";
            this.btn_ModificarInmueble.UseVisualStyleBackColor = true;
            this.btn_ModificarInmueble.Click += new System.EventHandler(this.btn_ModificarInmueble_Click);
            // 
            // btn_AgregarInmueble
            // 
            this.btn_AgregarInmueble.Location = new System.Drawing.Point(150, 21);
            this.btn_AgregarInmueble.Name = "btn_AgregarInmueble";
            this.btn_AgregarInmueble.Size = new System.Drawing.Size(178, 26);
            this.btn_AgregarInmueble.TabIndex = 2;
            this.btn_AgregarInmueble.Text = "Agregar";
            this.btn_AgregarInmueble.UseVisualStyleBackColor = true;
            this.btn_AgregarInmueble.Click += new System.EventHandler(this.btn_AgregarInmueble_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(12, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 277);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inmuebles de la Inmobiliaria Seleccionada";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(747, 242);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(792, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 276);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            this.groupBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox4_Paint);
            // 
            // textBox_Id_Y_Direccion1
            // 
            this.textBox_Id_Y_Direccion1.Location = new System.Drawing.Point(85, 117);
            this.textBox_Id_Y_Direccion1.Name = "textBox_Id_Y_Direccion1";
            this.textBox_Id_Y_Direccion1.Size = new System.Drawing.Size(249, 61);
            this.textBox_Id_Y_Direccion1.TabIndex = 1;
            this.textBox_Id_Y_Direccion1.TextBoxDireccion_Valido = false;
            this.textBox_Id_Y_Direccion1.TextBoxId_Valido = false;
            this.textBox_Id_Y_Direccion1.TextDireccion = "";
            this.textBox_Id_Y_Direccion1.TextId = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 598);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_EliminarInmobiliaria;
        private System.Windows.Forms.Button btn_ModificarInmobiliaria;
        private System.Windows.Forms.Button btn_AgregarInmobiliaria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxId2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVenta;
        private System.Windows.Forms.TextBox textBoxPublicacion;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button btn_EliminarInmueble;
        private System.Windows.Forms.Button btn_ModificarInmueble;
        private System.Windows.Forms.Button btn_AgregarInmueble;
        private TextBox_Id_Y_Direccion textBox_Id_Y_Direccion1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

