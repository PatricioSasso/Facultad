using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controler;





namespace _2019_09_20_Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ControlerForm1 Controler1;
        private void Button1_Click(object sender, EventArgs e)
        {

            Controler1.Alta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controler1 = new ControlerForm1(this);
            Controler1.ConsultaTodos();
        }
    }
}
