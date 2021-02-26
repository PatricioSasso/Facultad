using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Ej15
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Numeros numeros = new Numeros();
			IEnumerator<int> pares = new Enumerador();
			while (pares.MoveNext() && pares.Current < 15)
			{
				listBox1.Items.Add(pares.Current);
			}
			pares.Reset();
            foreach (var n in numeros)
            {
                if (n >= 20)
                {
                    break;
                }
				listBox2.Items.Add(n);
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Numeros : IEnumerable<int>
	{
		public IEnumerator<int> GetEnumerator(){return new Enumerador();}

		IEnumerator IEnumerable.GetEnumerator(){return new Enumerador();}
	}

	public class Enumerador : IEnumerator<int>
	{
		public int Current { get; set; } = 0;
		object IEnumerator.Current { get { return Current; } }
		public void Dispose(){}
		public bool MoveNext(){Current++; return true;}
		public void Reset(){Current = 0;}
	}
}
