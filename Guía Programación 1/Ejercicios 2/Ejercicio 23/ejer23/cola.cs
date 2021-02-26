using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer23
{
    class cola
    {
        public int max;
        public int[] Id = new int[999];
        public int[] Paginas = new int[999];
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

        public void agregar(int num, int pag)
        {
            if (colavacia() == true)
            {
                Id[0] = num;
                Paginas[0] = pag;
                primero = 0;
                ultimo = 0;
            }
            else
            {
                ultimo++;
                Id[ultimo] = num;
                Paginas[ultimo] = pag;
            }
        }
        public void eliminar()
        {
            if (colavacia() == false)
            {
                Id[primero] = 0;
                Paginas[primero] = 0;
                primero--;
                ultimo--;
                if (colavacia() == true)
                {
                    primero = -1;
                    ultimo = -1;
                }
                else
                { primero++; }
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
                return MessageBox.Show("Cliente a cobrar " + Id[primero]).ToString() + "        Paginas " + Paginas[primero].ToString();
            }
            else { return MessageBox.Show("Cola vacía").ToString(); }
        }
    }
}
