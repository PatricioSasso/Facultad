using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using Vehiculo;

namespace Procesador
{
    public class ProcesadorVehiculo
    {
        public string Name;
        static ProcesadorVehiculo instancia;

        private ProcesadorVehiculo() { }

        static object bloqueo = new object();

        public static ProcesadorVehiculo GetInstance
        {
            get
            {
                lock (bloqueo)
                {
                    if (instancia == null)
                    {
                        instancia = new ProcesadorVehiculo();
                        instancia.Name = Thread.CurrentThread.Name;
                    }
                }
                return instancia;
            }
        }

        public void Procesar(object vehiculo)
        {
            lock (bloqueo)
            {
                int i = 1;
                while (true)
                {
                    if (File.Exists(vehiculo.GetType().Name + "_" + i + ".xml"))
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                Stream stream = File.Create(vehiculo.GetType().Name + "_" + i + ".xml");
                XmlSerializer serializer = new XmlSerializer(vehiculo.GetType());
                serializer.Serialize(stream, vehiculo);
                stream.Close();
                if (vehiculo.GetType().Name == "Auto")
                {
                    GuardarCSV(vehiculo as Auto);
                }
            }
        }

        void GuardarCSV(Auto auto)
        {
            lock (bloqueo)
            {
                if (!File.Exists("Autos.csv"))
                {
                    Stream x = File.Create("Autos.csv");
                    x.Close();
                }
                StringBuilder add = new StringBuilder();
                add.AppendLine(auto.Patente + "," + auto.Marca + "," + auto.Modelo + "\n");
                File.AppendAllText("Autos.csv", add.ToString());
            }
        }

        public List<Avion> GetListAviones()
        {
            List<Avion> aviones = new List<Avion>();
            int i = 1;
            while ( true )
            {
                if(File.Exists("Avion_"+ i +".xml"))
                {
                    Stream open = File.Open("Avion_" + i + ".xml",FileMode.Open);
                    XmlSerializer serializer = new XmlSerializer(typeof(Avion));
                    aviones.Add((Avion)serializer.Deserialize(open));
                    open.Close();
                    i++;
                }
                else
                {
                    break;
                }
            }
            return aviones;
        }
    }
}
