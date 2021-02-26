using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace ClienteAhorcado
{
	public partial class ClienteForm : Form
	{
		public ClienteForm()
		{
			InitializeComponent();
		}

		private void ClienteForm_Load(object sender, EventArgs e)
		{
			cliente = new Cliente();
			cliente.ConexionTerminada += ConexionTerminada;
			cliente.DatosRecibidos += DatosRecibidos;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            button3.Enabled = cliente.Conectado;
        }

		Cliente cliente;

		private void Log(string texto)
		{	
			Invoke((Action)delegate
			{
                if(char.IsLetter(texto[0]) == true && texto.Length == 1)
                {
                    textBox4.AppendText($"{texto} - ");
                    textBox4.AppendText("\n");
                }
                else if (texto[0] == '@')
                {
                    int vida = int.Parse(texto[1].ToString());
                    switch (vida)
                    {
                        case 1: pictureBox2.Visible = true; break;
                        case 2: pictureBox3.Visible = true; break;
                        case 3: pictureBox4.Visible = true; break;
                        case 4: pictureBox5.Visible = true; break;
                        case 5: pictureBox6.Visible = true; break;
                        case 6: pictureBox7.Visible = true;
                            MessageBox.Show("¡Perdiste!");
                            button3.Enabled = true;
                            textBox5.Text = ""; break;
                    }
                }
                else if(texto.Length > 2 && texto != "Ganaste")
                {
                    textBox5.Text = texto;
                }
                else if(texto == "Ganaste")
                {
                    MessageBox.Show("¡Ganaste!");
                    button3.Enabled = true;
                    textBox5.Text = "";
                }
                else
                {
                    int cantidad_letras = int.Parse(texto);
                    label5.Text = "Tiene "+ cantidad_letras +" letras";
                    for (int i = 0; i < cantidad_letras; i++)
                    {
                        textBox5.Text += "_ ";
                    }
                }
			});
		}

		private void DatosRecibidos(object sender, DatosRecibidosEventArgs e)
		{
			Log(e.DatosRecibidos);
		}

		private void ConexionTerminada(object sender, EventArgs e)
		{
			Log("Finalizó la conexión");
			UpdateUI();
		}

		private void UpdateUI()
		{
			Invoke((Action)delegate
			{
				textBox2.Enabled = textBox1.Enabled = button1.Enabled = !cliente.Conectado;
				textBox3.Enabled = textBox3.Enabled = button3.Enabled = cliente.Conectado;

				if (cliente.Conectado)
				{
					Text = $"Cliente (IP = {cliente.LocalEndPoint.Address}, Puerto = {cliente.LocalEndPoint.Port})";
				}
				else
				{
					Text = "Cliente";
				}
			});
		}

        private void button1_Click(object sender, EventArgs e)
        {
            int puerto;
            if (!int.TryParse(textBox2.Text, out puerto))
            {
                MessageBox.Show("El puerto ingresado no es válido", Text);
                return;
            }
            string ip = textBox1.Text;
            cliente.Conectar(ip, puerto);
            UpdateUI();
        }

		private void button2_Click(object sender, EventArgs e)
		{
            if(textBox3.Text.Length != 1 || char.IsLetter(textBox3.Text[0]) == false)
            {
                MessageBox.Show("Solo puede enviarse una letra.");
                return;
            }
			cliente.EnviarDatos(textBox3.Text);
            textBox3.Clear();
		}

        private void Button3_Click(object sender, EventArgs e)
        {
            cliente.EnviarDatos(".");
            button3.Enabled = false;
        }
    }
}
