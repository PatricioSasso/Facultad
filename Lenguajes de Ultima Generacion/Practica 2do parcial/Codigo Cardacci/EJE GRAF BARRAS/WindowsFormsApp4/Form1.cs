using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        int[] _Vector;
        int _Mayor = 0;
        string[] _Meses;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                _Vector = new int[10];
                _Meses = new string[] { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };
       
                for (int i = 0; i < 10; i++)
                {
                    int _Aux= int.Parse(Interaction.InputBox("Valor: "));
                    _Vector[i] = _Aux;
                    listBox1.Items.Add(_Aux);
                    if (_Mayor < _Aux) { _Mayor = _Aux; }
                }

               
            }
            catch (Exception ex) 
            { MessageBox.Show(ex.Message); }
           
           

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
                            Random _R = new Random(DateAndTime.Now.Millisecond);
                           

                            Graphics GR = this.CreateGraphics();
                            GR.Clear(Color.Black);
                            int _OffsetX = 0;
                            for (int i = 0; i < 10; i++)
                            {
                                int _AltoADibujar = (_Vector[i] * 300 / _Mayor);

                                SolidBrush _S =new SolidBrush(Color.FromArgb(_R.Next(0, 255), _R.Next(0, 255), _R.Next(0, 255)));
                                GR.FillRectangle(_S, 100 + _OffsetX, 50+300-_AltoADibujar, 30,_AltoADibujar);
                                GR.DrawString(_Vector[i].ToString(), new Font("Arial",12), _S, 105 + _OffsetX, 30 + 300 - _AltoADibujar);
                                GR.DrawString(_Meses[i].ToString(), new Font("Arial", 9), _S, 100 + _OffsetX, 360);

                _OffsetX += 50;
                            }
              
                            GR.Dispose();
        }
    }
}
