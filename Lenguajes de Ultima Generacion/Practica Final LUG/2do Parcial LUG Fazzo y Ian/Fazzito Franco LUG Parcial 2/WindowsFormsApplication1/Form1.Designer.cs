namespace WindowsFormsApplication1
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_baja = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_persona = new System.Windows.Forms.DataGridView();
            this.dgv_persona_incremental = new System.Windows.Forms.DataGridView();
            this.txt_incremental = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.controlNacimiento = new WindowsFormsApplication1.ControlNacimiento();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persona_incremental)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(106, 38);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(106, 64);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(106, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 4;
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(505, 46);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(96, 34);
            this.btn_baja.TabIndex = 5;
            this.btn_baja.Text = "baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "modificacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "fecha nacimiento";
            // 
            // dgv_persona
            // 
            this.dgv_persona.AllowUserToAddRows = false;
            this.dgv_persona.AllowUserToDeleteRows = false;
            this.dgv_persona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_persona.Location = new System.Drawing.Point(15, 144);
            this.dgv_persona.Name = "dgv_persona";
            this.dgv_persona.ReadOnly = true;
            this.dgv_persona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_persona.Size = new System.Drawing.Size(586, 195);
            this.dgv_persona.TabIndex = 11;
            this.dgv_persona.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_persona_CellClick);
            this.dgv_persona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_persona_CellContentClick);
            // 
            // dgv_persona_incremental
            // 
            this.dgv_persona_incremental.AllowUserToAddRows = false;
            this.dgv_persona_incremental.AllowUserToDeleteRows = false;
            this.dgv_persona_incremental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_persona_incremental.Location = new System.Drawing.Point(607, 144);
            this.dgv_persona_incremental.Name = "dgv_persona_incremental";
            this.dgv_persona_incremental.ReadOnly = true;
            this.dgv_persona_incremental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_persona_incremental.Size = new System.Drawing.Size(396, 195);
            this.dgv_persona_incremental.TabIndex = 12;
            // 
            // txt_incremental
            // 
            this.txt_incremental.Location = new System.Drawing.Point(607, 114);
            this.txt_incremental.Name = "txt_incremental";
            this.txt_incremental.Size = new System.Drawing.Size(184, 20);
            this.txt_incremental.TabIndex = 13;
            this.txt_incremental.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "incremental";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "sort edad des";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(758, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "sort edad asc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(505, 2);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(96, 38);
            this.btn_alta.TabIndex = 1;
            this.btn_alta.Text = "alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(877, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 38);
            this.button4.TabIndex = 17;
            this.button4.Text = "dibujar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // controlNacimiento
            // 
            this.controlNacimiento.Location = new System.Drawing.Point(106, 90);
            this.controlNacimiento.Name = "controlNacimiento";
            this.controlNacimiento.Size = new System.Drawing.Size(150, 22);
            this.controlNacimiento.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 676);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_incremental);
            this.Controls.Add(this.dgv_persona_incremental);
            this.Controls.Add(this.dgv_persona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.controlNacimiento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persona_incremental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlNacimiento controlNacimiento;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_persona;
        private System.Windows.Forms.DataGridView dgv_persona_incremental;
        private System.Windows.Forms.TextBox txt_incremental;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button button4;
    }
}

