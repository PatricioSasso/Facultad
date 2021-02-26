using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        Random dado1;
        private void button1_Click(object sender, EventArgs e)
        {
            dado1 = new Random(DateTime.Now.Millisecond);
            int num = dado1.Next(1,7);
            label1.Text = num.ToString();
            

        }
    }
}
