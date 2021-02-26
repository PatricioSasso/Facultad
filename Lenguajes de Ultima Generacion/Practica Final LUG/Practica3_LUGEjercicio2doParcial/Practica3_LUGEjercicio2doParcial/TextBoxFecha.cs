using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3_LUGEjercicio2doParcial
{
    public partial class TextBoxFecha : UserControl
    {
        public TextBoxFecha()
        {
            InitializeComponent();
        }

        bool isTextValid;

        public bool IsTextValid 
        {
            get
            {
                Regex patron = new Regex(@"^\d{2}/\d{2}/\d{4}$");
                return patron.IsMatch(textBox1.Text);
            }
            set => isTextValid = value; 
        }

        public override string Text { get => textBox1.Text; set => textBox1.Text = value; }

        private void TextBoxFecha_Load(object sender, EventArgs e)
        {

        }
    }
}
