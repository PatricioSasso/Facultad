using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer21
{
    class Cola
    {
        public int max;
        public int[] vector=new int[100];
        public int primero=-1;
        public int ultimo=-1;

        public Boolean colavacia()
        {
            if (ultimo == -1 || primero==max)
            {
                return true;
            }
            else { return false; }
        }

        public Boolean colallena()
        {
            if (ultimo == max-1)
            {
                return true;
            }
            else { return false; }
        }

        public void agregar(int a)
        {
            int num = a;
            if (colavacia() == true)
            {
                vector[0] = num;
                primero = 0;
                ultimo = 0;
            }
            else
            {
                ultimo++;
                vector[ultimo] = num;  
            }  
        }
        public void eliminar()
        {
            if (colavacia() == false)
            {
                vector[primero] = 0;
                if (colavacia() == true)
                {
                    primero = -1;
                    ultimo = -1;
                }
                else
                { primero++; }
                MessageBox.Show("Elemento eliminado");
            }
        }
        public string ver()
        {
            if (colavacia() == false)
            {
                return MessageBox.Show("Número a eliminar "+ vector[primero]).ToString();
            }
            else {  return MessageBox.Show("Cola vacía").ToString(); }
        }


    }
}
