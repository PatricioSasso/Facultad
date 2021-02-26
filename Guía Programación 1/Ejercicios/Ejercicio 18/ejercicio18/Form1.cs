using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long n = Convert.ToInt32(textBox1.Text);

            if (radioButton1.Checked == true)
            {
                label6.Text = "Bit";
                if (checkBox1.Checked == true)
                {
                    textBox2.Text = n.ToString();
                    label8.Text = "Bit";
                    checkBox1.Checked = false;
                }
                else if (checkBox2.Checked == true)
                {
                    textBox2.Text = (n * 8).ToString();
                    label8.Text = "Byte ";
                    checkBox2.Checked = false;
                }
                else if (checkBox3.Checked == true)
                {
                    textBox2.Text = (n * 8000).ToString();
                    label8.Text = "KiloByte ";
                    checkBox3.Checked = false;
                }
                else if (checkBox4.Checked == true)
                {
                    textBox2.Text = (n * 8000000).ToString();
                    label8.Text = "MegaByte ";
                    checkBox4.Checked = false;
                }
                else if (checkBox5.Checked == true)
                {
                    textBox2.Text = (n * 8000000000).ToString();
                    label8.Text = "GigaByte ";
                    checkBox5.Checked = false;
                }
                else if (checkBox6.Checked == true)
                {
                    textBox2.Text = (n * 8000000000000).ToString();
                    label8.Text = "TeraByte ";
                    checkBox6.Checked = false;
                }
                else if (checkBox7.Checked == true)
                {
                    textBox2.Text = (n * 8000000000000000).ToString();
                    label8.Text = "PetaByte ";
                    checkBox7.Checked = false;
                }
                else if (checkBox8.Checked == true)
                {
                    textBox2.Text = (n * 8000000000000000000).ToString();
                    label8.Text = "ExaByte ";
                    checkBox8.Checked = false;
                }
                else if (checkBox9.Checked == true)
                {
                    textBox2.Text = (n * 8000000000000000000000).ToString();
                    label8.Text = "ZetaByte ";
                    checkBox9.Checked = false;
                }
                else if (checkBox10.Checked == true)
                {
                    textBox2.Text = (n * 8000000000000000000000000).ToString();
                    label8.Text = "Yofta ";
                    checkBox10.Checked = false;
                }
                else if (checkBox11.Checked == true)
                {
                    textBox2.Text = (n * 8000000000000000000000000000).ToString();
                    label8.Text = "BrontoByte ";
                    checkBox11.Checked = false;
                }
                else if (checkBox12.Checked == true)
                {
                    textBox2.Text = (n * 8000000000000000000000000000000).ToString();
                    label8.Text = "GeopByte ";
                    checkBox12.Checked = false;
                }
            }
            else if (radioButton2.Checked == true)
            {
                label6.Text = "Byte";
                if (checkBox1.Checked == true)
                {
                    textBox2.Text = (n * 0.125).ToString();
                    label8.Text = "Bit";
                    checkBox1.Checked = false;
                }
                else if (checkBox2.Checked == true)
                {
                    textBox2.Text = n.ToString();
                    label8.Text = "Byte ";
                    checkBox2.Checked = false;
                }
                else if (checkBox3.Checked == true)
                {
                    textBox2.Text = (n * 1000).ToString();
                    label8.Text = "KiloByte ";
                    checkBox3.Checked = false;
                }
                else if (checkBox4.Checked == true)
                {
                    textBox2.Text = (n * 1000000).ToString();
                    label8.Text = "Megabyte ";
                    checkBox4.Checked = false;
                }
                else if (checkBox5.Checked == true)
                {
                    textBox2.Text = (n * 1000000000).ToString();
                    label8.Text = "GigaByte ";
                    checkBox5.Checked = false;
                }
                else if (checkBox6.Checked == true)
                {
                    textBox2.Text = (n * 1000000000000).ToString();
                    label8.Text = "TeraByte ";
                    checkBox6.Checked = false;
                }
                else if (checkBox7.Checked == true)
                {
                    textBox2.Text = (n * 1000000000000000).ToString();
                    label8.Text = "PetaByte ";
                    checkBox7.Checked = false;
                }
                else if (checkBox8.Checked == true)
                {
                    textBox2.Text = (n * 1000000000000000000).ToString();
                    label8.Text = "ExaByte ";
                    checkBox8.Checked = false;
                }
                else if (checkBox9.Checked == true)
                {
                    textBox2.Text = (n * 1000000000000000000000).ToString();
                    label8.Text = "ZetaByte ";
                    checkBox9.Checked = false;
                }
                else if (checkBox10.Checked == true)
                {
                    textBox2.Text = (n * 1000000000000000000000000).ToString();
                    label8.Text = "YoftaByte ";
                    checkBox10.Checked = false;
                }
                else if (checkBox11.Checked == true)
                {
                    textBox2.Text = (n * 1000000000000000000000000000).ToString();
                    label8.Text = "BrontoByte ";
                    checkBox11.Checked = false;
                }
                else if (checkBox12.Checked == true)
                {
                    textBox2.Text = (n * 1000000000000000000000000000).ToString();
                    label8.Text = "GeopByte ";
                    checkBox12.Checked = false;
                }
            }
        }
    }
}
