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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Stack Stack = new Stack();
        Stack StackCopia = new Stack();
        Stack StackCopia2 = new Stack();
        Stack auxstack = new Stack();
        Stack auxswapdos = new Stack();
        Stack auxswap;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Object numero = Interaction.InputBox("valor");
            Stack.Push(numero);
            StackCopia.Push(numero);
            StackCopia2.Push(numero);
            view();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Stack.Pop();
            view();
        }

        public void view()
        {
            Iterator ite = Stack.Iterator();
            listBox1.Items.Clear();
            while (ite.HasNext())
            {
                Object value = ite.Next();
                listBox1.Items.Add(value);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        public int viewtotal()
        {
            Iterator ite = Stack.Iterator();
            int total = 0;
            while (ite.HasNext())
            {
                Object value = ite.Next();
                total += int.Parse(value.ToString());
            }
            return total;
        }
        public int viewmax()
        {
            Iterator ite = Stack.Iterator();
            int total = 0;
            int mayor = 0;
            while (ite.HasNext())
            {
                Object value = ite.Next();
                int acomp = int.Parse(value.ToString());
                if (mayor < acomp)
                {
                    mayor = acomp;
                }
            }
            return total;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("el total es" + viewtotal());
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            view();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add();
            Stack.Push(Interaction.InputBox("valor"));
            adddos();
            view();
        }
        public void add()
        {
            Iterator ite = Stack.Iterator();
            int count = 0;
            while (ite.HasNext())
            {
                Node insertar = ite.Nextnodo();
                auxstack.Push(insertar.value);
                Stack.Pop();
            }
        }
        public void adddos()
        {
            Iterator ite = auxstack.Iterator();
            int count = 0;
            while (ite.HasNext())
            {
                Node insertar = ite.Nextnodo();
                Stack.Push(insertar.value);
                auxstack.Pop();
            }
        }

        public int viewcant()
        {
            Iterator ite = Stack.Iterator();
            int count = 0;
            while (ite.HasNext())
            {
                Object value = ite.Next();
                count++;
            }
            return count;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("la cantidad de elementos es " + viewcant());
        }
        Object primero;
        Object ultimo;
        private void button4_Click(object sender, EventArgs e)
        {
            auxswap = new Stack();
            primero = Stack.gethead().value;
            addswap();
            ultimo = auxswap.gethead().value;
            addvalues();
            view3();
        }

        public void swap()
        {
            Iterator ite = auxswapdos.Iterator();
            while (ite.HasNext())
            {
                Node insertar = ite.Nextnodo();
                Stack.Push(insertar.value);
                auxswapdos.Pop();
            }
        }
        public void addvalues()
        {
            Stack.Push(primero);
            auxswap.Pop();
            int cant = auxswap.GetSize();
            for (int i = 0; i < cant-1; i++)
            {
                Stack.Push(auxswap.gethead().value);
                auxswap.Pop();
            }
            Stack.Push(ultimo);
        }
        
        public void addswap()
        {
            Iterator ite = Stack.Iterator();
            
            while (ite.HasNext())
            {
                Node insertar = ite.Nextnodo();
                auxswap.Push(insertar.value);
                Stack.Pop();
            }
            
        }
        public void view2()
        {
            Iterator ite = auxswap.Iterator();
            listBox3.Items.Clear();
            while (ite.HasNext())
            {
                Object value = ite.Next();
                listBox3.Items.Add(value);
            }
        }
        public void view3()
        {

            Iterator ite = Stack.Iterator();
            listBox1.Items.Clear();
            while (ite.HasNext())
            {
                Object value = ite.Next();
                listBox1.Items.Add(value);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            auxswap = new Stack();

            int eliminar = int.Parse(Interaction.InputBox("Valor a borrar"));
            //este es
            addswap();
            int cant = auxswap.GetSize();
            for (int i = 0; i < cant; i++)
            {
                if(int.Parse(auxswap.gethead().value.ToString())!=eliminar)
                {
                    Stack.Push(int.Parse(auxswap.gethead().value.ToString()));
                }
                auxswap.Pop();
            }
            view();
        }

        /*no anda despues de la segunda ejecucion*/

        private void button7_Click(object sender, EventArgs e)
        {
            Verificar();
        }

        private void Verificar()
        {
            int a = 0;
            int cant = Stack.GetSize(), i = 0;
            int[] vec = new int[cant];
            Iterator ite = Stack.Iterator();
            while (ite.HasNext())
            {
                Node insertar = ite.Nextnodo();
                vec[i] = int.Parse(insertar.value.ToString());
                i++;
                auxstack.Push(insertar.value);
                Stack.Pop();
            }
            ite = auxstack.Iterator();
            while (ite.HasNext())
            {
                Node insertar = ite.Nextnodo();
                Stack.Push(insertar.value);
                auxstack.Pop();
            }
            int j = cant;
            for (i = 0; i < cant; i++)
            {
                if (vec[i] == vec[j-1])
                {
                    a++;
                }
                j--;
            }
            if (a==Stack.GetSize())
            {
                Interaction.MsgBox("Es palindromo");
            }
            else
            {
                Interaction.MsgBox("No es palindromo");
            }

        }



    }
    public class Iterator
    {
        private Node next;
        public Iterator(Node head)
        {
            this.next = head;
        }
        public bool HasNext()
        {
            return this.next != null;
        }
        public Object Next()
        {
            Node current = next;
            this.next = this.next.prior;
            return current.value;
        }



        public Node Nextnodo()
        {
            Node current = next;
            this.next = this.next.prior;
            return current;
        }
    }

    public class Stack
    {
        private Node head;
        private Node tail;
        private int size;
        public Stack()
        {
            this.size = 0;
        }

        public Iterator Iterator()
        {
            return new Iterator(this.head);
        }


        public void Push(object value)
        {

            Node newNode = new Node(value);
            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
                this.size++;
                return;
            }

            Node lastHead = this.head;
            this.head = newNode;
            this.head.prior = lastHead;
            this.size++;
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }

        public Object Peek()
        {
            if (IsEmpty())
            {
                return null;
            }
            return this.head.value;
        }
        public Object Pop()
        {
            if (IsEmpty())
            {
                return null;
            }

            Node first = this.head;
            this.head = this.head.prior;
            this.size--;
            return first.value;
        }
        public int GetSize()
        {
            return size;
        }
        public Node gethead()
        {
            return this.head;
        }

    }
    public class Node
    {
        public Object value;
        public Node prior;
       
        public Node(Object value)
        {
            this.value = value;
        }
    }
}
