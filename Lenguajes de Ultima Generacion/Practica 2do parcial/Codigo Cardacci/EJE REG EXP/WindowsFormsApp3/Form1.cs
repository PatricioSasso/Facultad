using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Regex _RE;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _RE = new Regex("");
        }

        private void ActualizoTextBox3(object sender, EventArgs e)
        {
            try
            {
                          
                _RE = new Regex(textBox1.Text,RegexOptions.Multiline);
                MatchCollection _MC = _RE.Matches(textBox2.Text);
                textBox3.Clear();
                textBox3.Text += $"Cantidad de Ocurrencias: {_MC.Count} \r\n\r\n";
                foreach (Match m in _MC)
                {
                    textBox3.Text += $"{m.Value}  Lugar: {m.Index}  Largo: {m.Length}\r\n";
                }
                if (textBox1.Text.Length == 0) { textBox3.Clear(); }
            }
            catch (Exception) { textBox3.Clear(); }
           
         

        }

       
    }
}
