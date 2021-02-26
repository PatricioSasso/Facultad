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

namespace U3_Ej10
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

        private void Button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            try
            {
                int a = int.Parse(Interaction.InputBox("Ingrese un numerador"));
                int b = int.Parse(Interaction.InputBox("Ingrese el divisor menor que 10"));
                if (b > 10) { throw new NumeroMayorQue10(); }
                c = a / b;
            }
            catch (DivideByZeroException A)
            {
                MessageBox.Show(A.Message);
            }
            catch(FormatException A)
            {
                MessageBox.Show(A.Message);
            }
            catch(ArgumentException A)
            {
                MessageBox.Show(A.Message);
            }
            catch(NumeroMayorQue10 A)
            {
                MessageBox.Show(" El divisor es mayor que 10");
            }
            catch(Exception A)
            {
                MessageBox.Show(A.Message);
            }
            finally
            {
                MessageBox.Show("Finally: la división dio como resultado " + c ".");
            }
        }
    }

    public class NumeroMayorQue10 : Exception
    {

    }
}
