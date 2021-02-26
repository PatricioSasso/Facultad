using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Procesador;
using Vehiculo;

namespace Practica2doParcial
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

        static Auto auto = new Auto("ASD-123","Fiat","Idk");
        static Avion avion = new Avion("ASDP-432", 10, 70);
        static Lancha lancha = new Lancha("MarcaPepito", 10, "MotorDeLancha");

        private void btn_1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while ( i < 5)
            {
                Random r = new Random(DateTime.Now.Millisecond);
                Thread tAutos = new Thread(delegate ()
                {
                    Thread.Sleep(r.Next(500, 2000));
                    ProcesadorVehiculo.GetInstance.Procesar(auto.Clone());
                });
                Thread tAviones = new Thread(delegate ()
                {
                    Thread.Sleep(r.Next(500, 2000));
                    ProcesadorVehiculo.GetInstance.Procesar(avion.Clone());
                });
                Thread tLancha = new Thread(delegate ()
                {
                    Thread.Sleep(r.Next(500, 2000));
                    ProcesadorVehiculo.GetInstance.Procesar(lancha.Clone());
                });
                tAutos.Start();
                tAviones.Start();
                tLancha.Start();
                i++;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Hangar hangar = new Hangar(ProcesadorVehiculo.GetInstance.GetListAviones());
            while (hangar.MoveNext())
            {
                Avion avion = hangar.Current as Avion;
                textBox1.Text += "Matricula: " + avion.Matricula +
                                 " , Autonomía: " + avion.Autonomia +
                                 " , Cantidad de Pasajeros: " + avion.CantidadPasajeros + Environment.NewLine;
            }
        }
    }
}
