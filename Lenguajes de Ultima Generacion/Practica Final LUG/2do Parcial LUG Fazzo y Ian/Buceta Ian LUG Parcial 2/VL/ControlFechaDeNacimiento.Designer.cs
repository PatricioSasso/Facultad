namespace VL
{
    partial class ControlFechaDeNacimiento
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha De Nacimiento:";
            // 
            // textBoxFechaDeNacimiento
            // 
            this.textBoxFechaDeNacimiento.Location = new System.Drawing.Point(122, 3);
            this.textBoxFechaDeNacimiento.Name = "textBoxFechaDeNacimiento";
            this.textBoxFechaDeNacimiento.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaDeNacimiento.TabIndex = 3;
            // 
            // ControlFechaDeNacimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFechaDeNacimiento);
            this.Name = "ControlFechaDeNacimiento";
            this.Size = new System.Drawing.Size(230, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFechaDeNacimiento;
    }
}
