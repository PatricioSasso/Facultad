namespace Practica2_LUGEjercicio2doParcial
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_OrdenNombreAscendente = new System.Windows.Forms.Button();
            this.btn_OrdenNombreDescendente = new System.Windows.Forms.Button();
            this.groupBoxBarras = new System.Windows.Forms.GroupBox();
            this.btn_Barras = new System.Windows.Forms.Button();
            this.btn_Torta = new System.Windows.Forms.Button();
            this.groupBoxTorta = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userControl11 = new Practica2_LUGEjercicio2doParcial.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(99, 344);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(80, 22);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(99, 372);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(122, 22);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(99, 400);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(122, 22);
            this.textBoxApellido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(149, 3);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(154, 22);
            this.textBoxFiltro.TabIndex = 7;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar por Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de\r\nNacimiento\r\n";
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(237, 347);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(175, 32);
            this.btn_Alta.TabIndex = 11;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(237, 423);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(175, 32);
            this.btn_Baja.TabIndex = 12;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(237, 385);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(175, 32);
            this.btn_Modificar.TabIndex = 13;
            this.btn_Modificar.Text = "Modificacion";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_OrdenNombreAscendente
            // 
            this.btn_OrdenNombreAscendente.Location = new System.Drawing.Point(418, 347);
            this.btn_OrdenNombreAscendente.Name = "btn_OrdenNombreAscendente";
            this.btn_OrdenNombreAscendente.Size = new System.Drawing.Size(175, 47);
            this.btn_OrdenNombreAscendente.TabIndex = 14;
            this.btn_OrdenNombreAscendente.Text = "Ordenar Por Nombre Ascendentemente";
            this.btn_OrdenNombreAscendente.UseVisualStyleBackColor = true;
            this.btn_OrdenNombreAscendente.Click += new System.EventHandler(this.btn_OrdenNombreAscendente_Click);
            // 
            // btn_OrdenNombreDescendente
            // 
            this.btn_OrdenNombreDescendente.Location = new System.Drawing.Point(418, 408);
            this.btn_OrdenNombreDescendente.Name = "btn_OrdenNombreDescendente";
            this.btn_OrdenNombreDescendente.Size = new System.Drawing.Size(175, 47);
            this.btn_OrdenNombreDescendente.TabIndex = 15;
            this.btn_OrdenNombreDescendente.Text = "Ordenar Por Nombre Descendentemente";
            this.btn_OrdenNombreDescendente.UseVisualStyleBackColor = true;
            this.btn_OrdenNombreDescendente.Click += new System.EventHandler(this.btn_OrdenNombreDescendente_Click);
            // 
            // groupBoxBarras
            // 
            this.groupBoxBarras.Location = new System.Drawing.Point(625, 6);
            this.groupBoxBarras.Name = "groupBoxBarras";
            this.groupBoxBarras.Size = new System.Drawing.Size(409, 223);
            this.groupBoxBarras.TabIndex = 17;
            this.groupBoxBarras.TabStop = false;
            this.groupBoxBarras.Text = "Gráfico de Barras";
            // 
            // btn_Barras
            // 
            this.btn_Barras.Location = new System.Drawing.Point(12, 465);
            this.btn_Barras.Name = "btn_Barras";
            this.btn_Barras.Size = new System.Drawing.Size(274, 32);
            this.btn_Barras.TabIndex = 18;
            this.btn_Barras.Text = "Dibujar Gráfico de Barras";
            this.btn_Barras.UseVisualStyleBackColor = true;
            this.btn_Barras.Click += new System.EventHandler(this.btn_Barras_Click);
            // 
            // btn_Torta
            // 
            this.btn_Torta.Location = new System.Drawing.Point(292, 465);
            this.btn_Torta.Name = "btn_Torta";
            this.btn_Torta.Size = new System.Drawing.Size(274, 32);
            this.btn_Torta.TabIndex = 19;
            this.btn_Torta.Text = "Dibujar Gráfico de Torta";
            this.btn_Torta.UseVisualStyleBackColor = true;
            this.btn_Torta.Click += new System.EventHandler(this.btn_Torta_Click);
            // 
            // groupBoxTorta
            // 
            this.groupBoxTorta.Location = new System.Drawing.Point(625, 257);
            this.groupBoxTorta.Name = "groupBoxTorta";
            this.groupBoxTorta.Size = new System.Drawing.Size(258, 216);
            this.groupBoxTorta.TabIndex = 20;
            this.groupBoxTorta.TabStop = false;
            this.groupBoxTorta.Text = "Gráfico de Torta";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView2.Location = new System.Drawing.Point(889, 257);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(408, 326);
            this.dataGridView2.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edad";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Color";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // userControl11
            // 
            this.userControl11.IsTextValid = false;
            this.userControl11.Location = new System.Drawing.Point(99, 428);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(105, 27);
            this.userControl11.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 587);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBoxTorta);
            this.Controls.Add(this.btn_Torta);
            this.Controls.Add(this.btn_Barras);
            this.Controls.Add(this.groupBoxBarras);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btn_OrdenNombreDescendente);
            this.Controls.Add(this.btn_OrdenNombreAscendente);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_OrdenNombreAscendente;
        private System.Windows.Forms.Button btn_OrdenNombreDescendente;
        private UserControl1 userControl11;
        private System.Windows.Forms.GroupBox groupBoxBarras;
        private System.Windows.Forms.Button btn_Barras;
        private System.Windows.Forms.Button btn_Torta;
        private System.Windows.Forms.GroupBox groupBoxTorta;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

