using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_LUGEjercicio2doParcial
{
    public partial class TextBoxSoloFecha : UserControl
    {
        public TextBoxSoloFecha()
        {
            InitializeComponent();
        }

        bool isValid;

        public bool IsValid 
        {
            get
            {
                Regex patronTexto = new Regex(@"\d{2}/\d{2}/\d{4}");
                return patronTexto.IsMatch(textBox1.Text);  
            } 
            set => isValid = value; 
        }
        public override string Text { get => textBox1.Text; set => textBox1.Text = value; }

        private void TextBoxSoloFecha_Load(object sender, EventArgs e)
        {

        }
    }
}
