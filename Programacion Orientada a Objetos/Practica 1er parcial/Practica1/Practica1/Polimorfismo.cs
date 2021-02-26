using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    abstract class A
    {
        public int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        abstract public int Restar(int n1, int n2);
    }

    class B : A
    {
        public override int Restar(int n1, int n2) // Sobreescritura
        {
            return n1 + n2;
        }

        public int[] Sumar(int[] n)
        {
            int t = 0;
            for (int i = 0; i < n.Length; i++)
            {
                t += n[i];
            }
            return n;
        }
    }

    class C : A
    {
        public override int Restar(int n1, int n2)
        {
            int n3 = n1 + n2;
            return n3;
        }
    }
}
