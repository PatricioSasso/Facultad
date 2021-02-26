namespace Practica3_LUGEjercicio2doParcial
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
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modificacion = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_OrdenarNombreAsc = new System.Windows.Forms.Button();
            this.btn_OrdenarNombreDesc = new System.Windows.Forms.Button();
            this.btn_Barras = new System.Windows.Forms.Button();
            this.btn_Torta = new System.Windows.Forms.Button();
            this.groupBoxBarras = new System.Windows.Forms.GroupBox();
            this.textBoxFecha = new Practica3_LUGEjercicio2doParcial.TextBoxFecha();
            this.groupBoxTorta = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 449);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(246, 6);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(166, 22);
            this.textBoxFiltro.TabIndex = 1;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Busqueda Incremental por Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(40, 488);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(110, 22);
            this.textBoxId.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(220, 488);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(110, 22);
            this.textBoxNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(400, 488);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(110, 22);
            this.textBoxApellido.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(12, 549);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(157, 23);
            this.btn_Alta.TabIndex = 11;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // btn_Modificacion
            // 
            this.btn_Modificacion.Location = new System.Drawing.Point(12, 578);
            this.btn_Modificacion.Name = "btn_Modificacion";
            this.btn_Modificacion.Size = new System.Drawing.Size(157, 23);
            this.btn_Modificacion.TabIndex = 12;
            this.btn_Modificacion.Text = "Modificacion";
            this.btn_Modificacion.UseVisualStyleBackColor = true;
            this.btn_Modificacion.Click += new System.EventHandler(this.btn_Modificacion_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(12, 607);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(157, 23);
            this.btn_Baja.TabIndex = 13;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_OrdenarNombreAsc
            // 
            this.btn_OrdenarNombreAsc.Location = new System.Drawing.Point(175, 549);
            this.btn_OrdenarNombreAsc.Name = "btn_OrdenarNombreAsc";
            this.btn_OrdenarNombreAsc.Size = new System.Drawing.Size(249, 36);
            this.btn_OrdenarNombreAsc.TabIndex = 14;
            this.btn_OrdenarNombreAsc.Text = "Ordenar Por Nombre Ascendente";
            this.btn_OrdenarNombreAsc.UseVisualStyleBackColor = true;
            this.btn_OrdenarNombreAsc.Click += new System.EventHandler(this.btn_OrdenarNombreAsc_Click);
            // 
            // btn_OrdenarNombreDesc
            // 
            this.btn_OrdenarNombreDesc.Location = new System.Drawing.Point(175, 594);
            this.btn_OrdenarNombreDesc.Name = "btn_OrdenarNombreDesc";
            this.btn_OrdenarNombreDesc.Size = new System.Drawing.Size(249, 36);
            this.btn_OrdenarNombreDesc.TabIndex = 15;
            this.btn_OrdenarNombreDesc.Text = "Ordenar Por Nombre Descendente";
            this.btn_OrdenarNombreDesc.UseVisualStyleBackColor = true;
            this.btn_OrdenarNombreDesc.Click += new System.EventHandler(this.btn_OrdenarNombreDesc_Click);
            // 
            // btn_Barras
            // 
            this.btn_Barras.Location = new System.Drawing.Point(430, 549);
            this.btn_Barras.Name = "btn_Barras";
            this.btn_Barras.Size = new System.Drawing.Size(189, 36);
            this.btn_Barras.TabIndex = 16;
            this.btn_Barras.Text = "Dibujar Gráfico de Barras";
            this.btn_Barras.UseVisualStyleBackColor = true;
            this.btn_Barras.Click += new System.EventHandler(this.btn_Barras_Click);
            // 
            // btn_Torta
            // 
            this.btn_Torta.Location = new System.Drawing.Point(430, 594);
            this.btn_Torta.Name = "btn_Torta";
            this.btn_Torta.Size = new System.Drawing.Size(189, 36);
            this.btn_Torta.TabIndex = 17;
            this.btn_Torta.Text = "Dibujar Gráfico de Torta";
            this.btn_Torta.UseVisualStyleBackColor = true;
            this.btn_Torta.Click += new System.EventHandler(this.btn_Torta_Click);
            // 
            // groupBoxBarras
            // 
            this.groupBoxBarras.Location = new System.Drawing.Point(625, 9);
            this.groupBoxBarras.Name = "groupBoxBarras";
            this.groupBoxBarras.Size = new System.Drawing.Size(534, 301);
            this.groupBoxBarras.TabIndex = 18;
            this.groupBoxBarras.TabStop = false;
            this.groupBoxBarras.Text = "Gráfico de Barras";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.IsTextValid = false;
            this.textBoxFecha.Location = new System.Drawing.Point(159, 516);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(150, 30);
            this.textBoxFecha.TabIndex = 10;
            // 
            // groupBoxTorta
            // 
            this.groupBoxTorta.Location = new System.Drawing.Point(625, 333);
            this.groupBoxTorta.Name = "groupBoxTorta";
            this.groupBoxTorta.Size = new System.Drawing.Size(358, 301);
            this.groupBoxTorta.TabIndex = 19;
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
            this.dataGridView2.Location = new System.Drawing.Point(989, 333);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(404, 324);
            this.dataGridView2.TabIndex = 20;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(607, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ordenar Por ID Ascendente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOrdenarId_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBoxTorta);
            this.Controls.Add(this.groupBoxBarras);
            this.Controls.Add(this.btn_Torta);
            this.Controls.Add(this.btn_Barras);
            this.Controls.Add(this.btn_OrdenarNombreDesc);
            this.Controls.Add(this.btn_OrdenarNombreAsc);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Modificacion);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFiltro);
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
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private TextBoxFecha textBoxFecha;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modificacion;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_OrdenarNombreAsc;
        private System.Windows.Forms.Button btn_OrdenarNombreDesc;
        private System.Windows.Forms.Button btn_Barras;
        private System.Windows.Forms.Button btn_Torta;
        private System.Windows.Forms.GroupBox groupBoxBarras;
        private System.Windows.Forms.GroupBox groupBoxTorta;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
    }
}

