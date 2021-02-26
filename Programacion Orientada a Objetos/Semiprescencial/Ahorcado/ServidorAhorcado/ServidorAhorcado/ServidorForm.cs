using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorAhorcado
{
    public partial class ServidorForm : Form
    {
        public ServidorForm()
        {
            InitializeComponent();
        }

        Servidor servidor;

        private void Form1_Load(object sender, EventArgs e)
        {
            servidor = new Servidor(8050);
            servidor.NuevaConexion += Servidor_NuevaConexion;
            servidor.ConexionTerminada += Servidor_ConexionTerminada;
            servidor.DatosRecibidos += Servidor_DatosRecibidos;
            servidor.Escuchar();
            CargarPalabras();
        }

        string[] palabras = new string[91];
        string elegida;
        int cantidad_letras;
        int vidas = 0;
        bool jugar = false;
        string estado_palabra = "";

        private void Log(string texto)
        {
            Invoke((Action)delegate
            {
                textBox1.AppendText($"{DateTime.Now.ToLongTimeString()} - {texto}");
                textBox1.AppendText("\n");
            });
        }

        private void Servidor_NuevaConexion(object sender, ServidorEventArgs e)
        {
            Log($"\n\rSe ha conectado un nuevo cliente desde la IP = {e.EndPoint.Address}, Puerto = {e.EndPoint.Port}\n\r");
        }

        private void Servidor_ConexionTerminada(object sender, ServidorEventArgs e)
        {
            Log($"\n\rSe ha desconectado el cliente de la IP = {e.EndPoint.Address}, Puerto = {e.EndPoint.Port}\n\r");
        }

        private void Servidor_DatosRecibidos(object sender, DatosRecibidosEventArgs e)
        {
            Log($"\n\rNuevo mensaje desde IP = {e.EndPoint.Address}, Puerto = {e.EndPoint.Port}\n\r");
            Log("\n\r" + e.DatosRecibidos + "\n\r");
            if(jugar == true)
            {
                ChequearLetra(e.DatosRecibidos);
            }
            else if(e.DatosRecibidos == ".")
            {
                IniciarJuego();
            }
            else
            {
            }
        }

        public void IniciarJuego()
        {
            if(jugar != true)
            {
                Random a = new Random();
                elegida = palabras[a.Next(0, palabras.Count())].ToUpper();
                cantidad_letras = elegida.Length;
                jugar = true;
                servidor.EnviarDatos(cantidad_letras.ToString());
            }
        }

        public void ChequearLetra(string letra)
        {
            letra = letra.ToUpper();
            if(estado_palabra == "")
            {
                for (int a = 0; a < cantidad_letras; a++)
                {
                    estado_palabra += "_ ";
                }
            }
            char[] p = Descomponer();
            int i = 0;
            int pos = 0;
            foreach (var l in elegida)
            {
                if(l == letra[0])
                {
                    p[pos] = l;
                    i++;
                    pos += 2;
                }
                else
                {
                    pos += 2;
                }
            }
            if(i < 1)
            {
                servidor.EnviarDatos(letra);
                vidas++;
                servidor.EnviarDatos('@'+vidas.ToString());
                if (vidas == 6) { FinJuego(); }
            }
            estado_palabra = Componer(p);
            if (estado_palabra.Contains('_'))
            {
                servidor.EnviarDatos(estado_palabra);
            }
            else
            {
                servidor.EnviarDatos(estado_palabra);
                servidor.EnviarDatos("Ganaste");
                FinJuego();
            }
        }

        public char[] Descomponer()
        {
            char[] p = new char[estado_palabra.Length];
            for (int i = 0; i < estado_palabra.Length; i++)
            {
                p[i] = estado_palabra[i];
            }
            return p;
        }

        public string Componer(char[] p)
        {
            estado_palabra = "";
            for (int i = 0; i < p.Length; i++)
            {
                estado_palabra += p[i];
            }
            return estado_palabra;
        }

        public void FinJuego()
        {
            elegida = "";
            cantidad_letras = 0;
            vidas = 0;
            jugar = false;
            estado_palabra = "";
        }

        public void CargarPalabras()
        {
            palabras[0] = "hola"; palabras[1] = "Ventilador"; palabras[2] = "Mesa"; palabras[3] = "Heladera"; palabras[4] = "Television"; palabras[5] = "placar"; palabras[6] = "estufa"; palabras[7] = "Baño"; palabras[8] = "Linterna"; palabras[9] = "Cama";
            palabras[10] = "silla"; palabras[11] = "sillon"; palabras[12] = "ventana"; palabras[13] = "espejo"; palabras[14] = "lampara"; palabras[15] = "cortina"; palabras[16] = "puerta"; palabras[17] = "sillon"; palabras[18] = "almohada"; palabras[19] = "sabanas";
            palabras[20] = "modular"; palabras[21] = "gato"; palabras[22] = "perro"; palabras[23] = "burro"; palabras[24] = "elefante"; palabras[25] = "gaviota"; palabras[26] = "delfin"; palabras[27] = "vibora"; palabras[28] = "foca"; palabras[29] = "ballena";
			palabras[30] = "gusano"; palabras[31] = "hamster"; palabras[32] = "leon"; palabras[33] = "puma"; palabras[34] = "cebra"; palabras[35] = "mono"; palabras[36] = "vaca"; palabras[37] = "caballo"; palabras[38] = "rinoceronte"; palabras[39] = "loro";
            palabras[40] = "pescado"; palabras[41] = "camaron"; palabras[42] = "tortuga"; palabras[43] = "cabeza"; palabras[44] = "orejas"; palabras[45] = "nariz"; palabras[46] = "ojos"; palabras[47] = "labios"; palabras[48] = "boca"; palabras[49] = "pestañas";
            palabras[50] = "dedos"; palabras[51] = "pies"; palabras[52] = "tobillo"; palabras[53] = "codo"; palabras[54] = "rodilla"; palabras[55] = "brazos"; palabras[56] = "pecho"; palabras[57] = "antebrazo"; palabras[58] = "manzana"; palabras[59] = "apio";
            palabras[60] = "mango"; palabras[61] = "zanahoria"; palabras[62] = "banana"; palabras[63] = "calabaza"; palabras[64] = "frutilla"; palabras[65] = "frambuesa"; palabras[66] = "papaya"; palabras[67] = "aguacate"; palabras[68] = "brocoli"; palabras[69] = "cebolla";
            palabras[70] = "betabel"; palabras[71] = "uva"; palabras[72] = "chayote"; palabras[73] = "rabano"; palabras[74] = "cilantro"; palabras[75] = "ingles"; palabras[76] = "matematicas"; palabras[77] = "geografia"; palabras[78] = "historia"; palabras[79] = "civica";
            palabras[80] = "psicologia"; palabras[81] = "frances"; palabras[82] = "biologia"; palabras[83] = "quimica"; palabras[84] = "fisica"; palabras[85] = "filosofia"; palabras[86] = "Telescopio"; palabras[87] = "Camion"; palabras[88] = "motocicleta"; palabras[89] = "dinosaurio";
            palabras[90] = "adios";
        }
    }
}
