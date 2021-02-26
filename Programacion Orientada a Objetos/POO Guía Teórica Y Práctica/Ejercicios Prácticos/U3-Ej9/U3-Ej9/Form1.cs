using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_Ej9
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			A a = new A();
			a.DoIt();
			a = null;
			GC.Collect();
			B.IntA.DoIt();
		}
	}

	public class B
	{
		static public A IntA;
	}

	public class A
	{
		private int x = 10;
		public void DoIt()
		{
			 MessageBox.Show("Valor: " + x); 
		}

		~A()
		{
			B.IntA = this; GC.ReRegisterForFinalize(this);
		}
	}
}
