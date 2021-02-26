using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer22
{
    class cola
    {
        public int max;
        public int[] Id = new int[999];
        public decimal[] Importe = new decimal[999];
        public int primero = -1;
        public int ultimo = -1;

        public Boolean colavacia()
        {
            if (ultimo == -1 || primero == max)
            {
                return true;
            }
            else { return false; }
        }

        public Boolean colallena()
        {
            if (ultimo == max - 1)
            {
                return true;
            }
            else { return false; }
        }

        public void agregar(int num, decimal imp)
        {
            if (colavacia() == true)
            {
                Id[0] = num;
                Importe[0] = imp;
                primero = 0;
                ultimo = 0;
                MessageBox.Show("Elemento agregado");
            }
            else
            {
                ultimo++;
                Id[ultimo] = num;
                Importe[ultimo] = imp;
                MessageBox.Show("Elemento agregado");
            }
        }
        public void eliminar()
        {
            if (colavacia() == false)
            {
                Id[primero] = 0;
                Importe[primero] = 0;
                primero--;
                ultimo--;
                if (colavacia() == true)
                {
                    primero = -1;
                    ultimo = -1;
                }
                else
                { primero++; }
                MessageBox.Show("Elemento eliminado");
            }
            else
            {
                MessageBox.Show("Cola vacía");
            }
        }
        public string ver()
        {
            if (colavacia() == false)
            {
                return MessageBox.Show("Cliente a cobrar " + Id[primero]).ToString() + "        Importe" + Importe[primero].ToString();
            }
            else { return MessageBox.Show("Cola vacía").ToString(); }
        }
    }
}
