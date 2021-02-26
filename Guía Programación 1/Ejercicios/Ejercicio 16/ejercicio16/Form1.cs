using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int cuenta=0;
            cuenta = Convert.ToInt32(textBox1.Text);
            if (DeCelsius.Checked == true)
            {
                label6.Text = "Celsius";
                if (ConvertCelsius.Checked == true)
                {
                    textBox2.Text = textBox1.Text;
                    ConvertCelsius.Checked = false;
                    label8.Text = "Celsius";
                }
                else if (Convertfaren.Checked == true)
                {
                    textBox2.Text = ((cuenta * (1.8)) + 32).ToString();
                    Convertfaren.Checked = false;
                    label8.Text = "Fahrenheit";
                }
                else if (ConvertKelvin.Checked == true)
                {
                    textBox2.Text = (cuenta + 273.15).ToString();
                    ConvertKelvin.Checked = false;
                    label8.Text = "Kelvin";
                }
                else if (Convertrankine.Checked == true)
                {
                    textBox2.Text = (cuenta * 1.8000 + 491.67).ToString();
                    Convertrankine.Checked = false;
                    label8.Text = "Rankine";
                }
                DeCelsius.Checked = false;
            }
            else if (DeFaren.Checked == true)
            {
                label6.Text = "Fahrenheit";
                if (ConvertCelsius.Checked == true)
                {
                    textBox2.Text = ((cuenta - 32) / 1.8000).ToString();
                    ConvertCelsius.Checked = false;
                    label8.Text = "Celsius";
                }
                else if (Convertfaren.Checked == true)
                {
                    textBox2.Text = textBox1.Text;
                    Convertfaren.Checked = false;
                    label8.Text = "Fahrenheit";
                }
                else if (ConvertKelvin.Checked == true)
                {
                    textBox2.Text = (((cuenta - 32) / 1.8000) + 273.15).ToString();
                    ConvertKelvin.Checked = false;
                    label8.Text = "Kelvin";
                }
                else if (Convertrankine.Checked == true)
                {
                    textBox2.Text = ((cuenta - 32) + 491.67).ToString();
                    Convertrankine.Checked = false;
                    label8.Text = "Rankine";
                }
                DeFaren.Checked = false;
            }
            else if (DeKelvin.Checked == true)
            {
                label6.Text = "Kelvin";
                if (ConvertCelsius.Checked == true)
                {
                    textBox2.Text = (cuenta - 273.15).ToString();
                    ConvertCelsius.Checked = false;
                    label8.Text = "Celsius";
                }
                else if (Convertfaren.Checked == true)
                {
                    textBox2.Text = ((cuenta - 273.15) * 1.8000 + 32).ToString();
                    Convertfaren.Checked = false;
                    label8.Text = "Fahrenheit";
                }
                else if (ConvertKelvin.Checked == true)
                {
                    textBox2.Text = textBox1.Text;
                    ConvertKelvin.Checked = false;
                    label8.Text = "Kelvin";
                }
                else if (Convertrankine.Checked == true)
                {
                    textBox2.Text = ((cuenta - 273.15) * 1.8000 + 491.67).ToString();
                    Convertrankine.Checked = false;
                    label8.Text = "Rankine";
                }
                DeKelvin.Checked = false;
            }
            else if (DeRankine.Checked == true)
            {
                label6.Text = "Rankine";
                if (ConvertCelsius.Checked == true)
                {
                    textBox2.Text = ((cuenta - 491.67)/1.8000).ToString();
                    ConvertCelsius.Checked = false;
                    label8.Text = "Celsius";
                }
                else if (Convertfaren.Checked == true)
                {
                    textBox2.Text = ((cuenta - 491.67) + 32).ToString();
                    Convertfaren.Checked = false;
                    label8.Text = "Fahrenheit";
                }
                else if (ConvertKelvin.Checked == true)
                {
                    textBox2.Text = ((cuenta - 491.67)/1.8000 + 273.15).ToString();
                    ConvertKelvin.Checked = false;
                    label8.Text = "Kelvin";
                }
                else if (Convertrankine.Checked == true)
                {
                    textBox2.Text = textBox1.Text;
                    Convertrankine.Checked = false;
                    label8.Text = "Rankine";
                }
                DeRankine.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
