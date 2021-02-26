using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i1.max = 2000;
            i2.max = 2000;
        }

        cola i1 = new cola();
        cola i2 = new cola();

        int i1aimp = 0;
        int i2aimp = 0;
        int i1imp = 0;
        int i2imp = 0;

        int seg = 0;
        int min = 0;
        int hor = 0;

        int seg2 = 0;
        int min2 = 0;
        int hor2 = 0;

        int i1cantpag = 0;
        int i2cantpag = 0;

        int i1totaltiempo = 0;
        int i2totaltiempo = 0;

        int tseg = 0;
        int tmin = 0;
        int thor = 0;

        int tseg2 = 0;
        int tmin2 = 0;
        int thor2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Activar Timer")
            {
                button1.Text = "Desactivar Timer";
                timer1.Enabled = true;
                timer3.Enabled = true;
                seg = 0;
                min = 0;
                hor = 0;
                textBox5.Text = "0 : 0 : 0";
            }
            else
            {
                button1.Text = "Activar Timer";
                timer1.Enabled = false;
                timer3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i1.ver();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i2.ver();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "Activar Timer")
            {
                button6.Text = "Desactivar Timer";
                timer2.Enabled = true;
                timer4.Enabled = true;
                seg2 = 0;
                min2 = 0;
                hor2 = 0;
                textBox6.Text = "0 : 0 : 0";
            }
            else
            {
                button6.Text = "Activar Timer";
                timer2.Enabled = false;
                timer4.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int Id = 1;
            int Pag = r.Next(1, 60);
            if (Pag % 2 == 0)
            {
                i1.agregar(Id, Pag);
                i1aimp++;
                textBox1.Text = i1aimp.ToString();
                Id++;
                i1cantpag += i1.Paginas[i1.primero];
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int Id = 1;
            int Pag = r.Next(1, 60);
            if (Pag % 2 == 1)
            {
                i2.agregar(Id, Pag);
                i2aimp++;
                textBox3.Text = i2aimp.ToString();
                Id++;
                i2cantpag += i2.Paginas[i2.primero];
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                seg = 0;
                min++;
                if (min == 60)
                {
                    min = 0;
                    hor++;
                }
            }
            textBox5.Text = hor.ToString() + " : " + min.ToString() + " : " + seg.ToString();
            i1totaltiempo = i1cantpag * 500;
            tseg = 0;
            tmin = 0;
            thor = 0;
            tseg = i1totaltiempo / 1000;
            if (tseg >= 60)
            {
                for (int i = 0; tseg < 60; i++)
                {
                    tseg -= 60;
                    tmin++;
                }
                for (int i = 0; tmin < 60; i++)
                {
                    tmin -= 60;
                    thor++;
                }
            }
            if (tseg > 1)
            {
                i1cantpag -= 2;
            }
            if(tseg == 1)
            {
                tseg = 0;
            }
            textBox7.Text = thor.ToString() + " : " + tmin.ToString() + " : " + tseg.ToString();
            if (tseg == 0 & tmin == 0 & thor == 0)
            {
                if (i1.colavacia() == false)
                {
                    i1aimp--;
                    textBox1.Text = i1aimp.ToString();
                    i1imp++;
                    textBox2.Text = i1imp.ToString();
                    i1.eliminar();
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            seg2++;
            if (seg2 == 60)
            {
                seg2 = 0;
                min2++;
                if (min2 == 60)
                {
                    min2 = 0;
                    hor2++;
                }
            }
            textBox6.Text = hor2.ToString() + " : " + min2.ToString() + " : " + seg2.ToString();
            i2totaltiempo = i2cantpag * 500;
            tseg2 = 0;
            tmin2 = 0;
            thor2 = 0;
            tseg2 = i2totaltiempo / 1000;
            if (tseg2 >= 60)
            {
                for (int i = 0; tseg2 < 60; i++)
                {
                    tseg2 -= 60;
                    tmin2++;
                }
                for (int i = 0; tmin2 < 60; i++)
                {
                    tmin2 -= 60;
                    thor2++;
                }
            }
            if(tseg2 > 1)
            {
                i2cantpag -= 2;
            }
            if (tseg2 == 1)
            {
                tseg2 = 0;
            }
            textBox8.Text = thor2.ToString() + " : " + tmin2.ToString() + " : " + tseg2.ToString();
            if (tseg2 == 0 & tmin2 == 0 & thor2 == 0)
            {

                if (i2.colavacia() == false)
                {
                    i2aimp--;
                    textBox3.Text = i2aimp.ToString();
                    i2imp++;
                    textBox4.Text = i2imp.ToString();
                    i2.eliminar();
                }
            }
        }
    }
}
