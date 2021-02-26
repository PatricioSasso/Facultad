using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ControlNacimiento : UserControl
    {
        public ControlNacimiento()
        {
            InitializeComponent();
        }

        private void ControlNacimiento_Load(object sender, EventArgs e)
        {
            this.textBox1.Location = new Point(0, 0);
            this.textBox1.Size = this.Size; 
        }

        private void ControlNacimiento_Resize(object sender, EventArgs e)
        {
            this.ControlNacimiento_Load(null, null);
        }

        public bool IsValido
        {
            get
            {
                string valorTexto = this.textBox1.Text;
                Regex regex = new Regex(@"\d{2}[-]\d{2}[-]\d{4}");
                return regex.IsMatch(valorTexto);
            }
        }

        public override string Text
        {
            get
            {
                return this.textBox1.Text;
            }

            set
            {
                this.textBox1.Text = value;
            }
        }
    }
}
