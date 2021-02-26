using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);

            if (radioButton1.Checked == true)
            {
                label5.Text = "Horas";
                if (checkBox1.Checked == true)
                {
                    textBox2.Text = n.ToString();
                    label6.Text = "Horas";
                    checkBox1.Checked = false;
                }
                else if (checkBox2.Checked == true)
                {
                    textBox2.Text = (n * 60).ToString();
                    label6.Text = "Minutos ";
                    checkBox2.Checked = false;
                }
                else if (checkBox3.Checked == true)
                {
                    textBox2.Text = (n * 3600).ToString();
                    label6.Text = "Segundos ";
                    checkBox3.Checked = false;
                }
                else if (checkBox4.Checked == true)
                {
                    textBox2.Text = (n * 36000).ToString();
                    label6.Text = "Decisegundo ";
                    checkBox4.Checked = false;
                }
                else if (checkBox5.Checked == true)
                {
                    textBox2.Text = (n * 360000).ToString();
                    label6.Text = "CentiSegundo ";
                    checkBox5.Checked = false;

                }
                else if (checkBox6.Checked == true)
                {
                    textBox2.Text = (n * 3600000).ToString();
                    label6.Text = "Milisegundo ";
                    checkBox6.Checked = false;
                }
                else if (checkBox7.Checked == true)
                {
                    textBox2.Text = (n * 36000000).ToString();
                    label6.Text = "Microsegundo ";
                    checkBox7.Checked = false;
                }
                else if (checkBox8.Checked == true)
                {
                    textBox2.Text = (n * 360000000).ToString();
                    label6.Text = "Nanosegundo ";
                    checkBox8.Checked = false;
                }
                else if (checkBox9.Checked == true)
                {
                    textBox2.Text = (n * 3600000000).ToString();
                    label6.Text = "Picosegundo ";
                    checkBox9.Checked = false;
                }
                else if (checkBox10.Checked == true)
                {
                    textBox2.Text = (n * 36000000000).ToString();
                    label6.Text = "Femtosegundo ";
                    checkBox10.Checked = false;
                }
                else if (checkBox11.Checked == true)
                {
                    textBox2.Text = (n * 360000000000).ToString();
                    label6.Text = "Attosegundo ";
                    checkBox11.Checked = false;
                }
                else if (checkBox12.Checked == true)
                {
                    textBox2.Text = (n * 3600000000000).ToString();
                    label6.Text = "Zeptosegundo ";
                    checkBox12.Checked = false;
                }
                else if (checkBox13.Checked == true)
                {
                    textBox2.Text = (n * 36000000000000).ToString();
                    label6.Text = "Voctosegundo ";
                    checkBox13.Checked = false;
                }
            }
            else if (radioButton2.Checked == true)
            {
                double a = Convert.ToDouble(textBox1.Text);
                label5.Text = "Minutos";
                if (checkBox1.Checked == true)
                {
                    textBox2.Text = (a* (0.0166666667)).ToString();
                    label6.Text = "Horas";
                    checkBox1.Checked = false;
                }
                else if (checkBox2.Checked == true)
                {
                    textBox2.Text = (n).ToString();
                    label6.Text = "Minutos ";
                    checkBox2.Checked = false;
                }
                else if (checkBox3.Checked == true)
                {
                    textBox2.Text = (n * 60).ToString();
                    label6.Text = "Segundos ";
                    checkBox3.Checked = false;
                }
                else if (checkBox4.Checked == true)
                {
                    textBox2.Text = (n * 600).ToString();
                    label6.Text = "Decisegundo ";
                    checkBox4.Checked = false;
                }
                else if (checkBox5.Checked == true)
                {
                    textBox2.Text = (n * 6000).ToString();
                    label6.Text = "CentiSegundo ";
                    checkBox5.Checked = false;

                }
                else if (checkBox6.Checked == true)
                {
                    textBox2.Text = (n * 60000).ToString();
                    label6.Text = "Milisegundo ";
                    checkBox6.Checked = false;
                }
                else if (checkBox7.Checked == true)
                {
                    textBox2.Text = (n * 60000000).ToString();
                    label6.Text = "Microsegundo ";
                    checkBox7.Checked = false;
                }
                else if (checkBox8.Checked == true)
                {
                    textBox2.Text = (n * 60000000000).ToString();
                    label6.Text = "Nanosegundo ";
                    checkBox8.Checked = false;
                }
                else if (checkBox9.Checked == true)
                {
                    textBox2.Text = (n * 60000000000000).ToString();
                    label6.Text = "Picosegundo ";
                    checkBox9.Checked = false;
                }
                else if (checkBox10.Checked == true)
                {
                    textBox2.Text = (n * 600000000).ToString();
                    label6.Text = "Femtosegundo ";
                    checkBox10.Checked = false;
                }
                else if (checkBox11.Checked == true)
                {
                    textBox2.Text = (n * 6000000000).ToString();
                    label6.Text = "Attosegundo ";
                    checkBox11.Checked = false;
                }
                else if (checkBox12.Checked == true)
                {
                    textBox2.Text = (n * 60000000000).ToString();
                    label6.Text = "Zeptosegundo ";
                    checkBox12.Checked = false;
                }
                else if (checkBox13.Checked == true)
                {
                    textBox2.Text = (n * 600000000000).ToString();
                    label6.Text = "Voctosegundo ";
                    checkBox13.Checked = false;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
