using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ejercicio19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        
        public void ganador(string a)
        {
           
            if (button1.Text!="" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                textBox1.Text = "Ganador " + a;
            }
            else if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                textBox1.Text = "Ganador " + a;
            }
            else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                textBox1.Text = "Ganador " + a;
            }
            else if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                textBox1.Text = "Ganador " + a;
            }
            else if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
            {
                textBox1.Text = "Ganador " + a;
            }
            else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                textBox1.Text = "Ganador " + a;
            }
            else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                textBox1.Text = "Ganador " + a;
            }
            else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                textBox1.Text = "Ganador " + a;
            }
            else { textBox1.Text = ""; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = (Interaction.InputBox("Ingrese X o O")).ToString();
            if (a == "x" || a == "X")
            {
                button1.Text = "X";
                ganador(a);
            }
            else if (a == "o" || a == "O")
            {
                button1.Text = "O";
                ganador(a);  
            }
            else
            {
                MessageBox.Show("Caracter no válido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = (Interaction.InputBox("Ingrese X o O")).ToString();
            if (a == "x" || a == "X")
            {
                button2.Text = "X";
                ganador(a);
            }
            else if (a == "o" || a == "O")
            {
                button2.Text = "O";
                ganador(a);
            }
            else
            {
                MessageBox.Show("Caracter no válido");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = (Interaction.InputBox("Ingrese X o O")).ToString();
            if (a == "x" || a == "X")
            {
                button3.Text = "X";
                ganador(a);
            }
            else if (a == "o" || a == "O")
            {
                button3.Text = "O";
                ganador(a);
            }
            else
            {
                MessageBox.Show("Caracter no válido");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = (Interaction.InputBox("Ingrese X o O")).ToString();
            if (a == "x" || a == "X")
            {
                button4.Text = "X";
                ganador(a);
            }
            else if (a == "o" || a == "O")
            {
                button4.Text = "O";
                ganador(a);
            }
            else
            {
                MessageBox.Show("Caracter no válido");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = (Interaction.InputBox("Ingrese X o O")).ToString();
            if (a == "x" || a == "X")
            {
                button5.Text = "X";
                ganador(a);
            }
            else if (a == "o" || a == "O")
            {
                button5.Text = "O";
                ganador(a);
            }
            else
            {
                MessageBox.Show("Caracter no válido");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string a = (Interaction.InputBox("Ingrese X o O")).ToString();
            if (a == "x" || a == "X")
            {
                button6.Text = "X";
                ganador(a);
            }
            else if (a == "o" || a == "O")
            {
                button6.Text = "O";
                ganador(a);
            }
            else
            {
                MessageBox.Show("Caracter no válido");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a = (Interaction.InputBox("Ingrese X o O")).ToString();
            if (a == "x" || a == "X")
            {
                button7.Text = "X";
                ganador(a);
            }
            else if (a == "o" || a == "O")
            {
                button7.Text = "O";
                ganador(a);
            }
            else
            {
                MessageBox.Show("Caracter no válido");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string a = (Interaction.InputBox("Ingrese X o O")).ToString();
            if (a == "x" || a == "X")
            {
                button8.Text = "X";
                ganador(a);
            }
            else if (a == "o" || a == "O")
            {
                button8.Text = "O";
                ganador(a);
            }
            else
            {
                MessageBox.Show("Caracter no válido");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string a = (Interaction.InputBox("Ingrese X o O")).ToString();
            if (a == "x" || a == "X")
            {
                button9.Text = "X";
                ganador(a);
            }
            else if (a == "o" || a == "O")
            {
                button9.Text = "O";
                ganador(a);
            }
            else
            {
                MessageBox.Show("Caracter no válido");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            textBox1.Text = " ";
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
