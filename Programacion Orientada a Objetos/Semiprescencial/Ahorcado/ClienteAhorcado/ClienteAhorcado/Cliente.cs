using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace ClienteAhorcado
{
	public class Cliente
	{
		Socket socket; 
		Thread thread; 

		public bool Conectado { get; private set; }

		public IPEndPoint LocalEndPoint
		{
			get { return socket?.LocalEndPoint as IPEndPoint; }
		}

		public IPEndPoint RemoteEndPoint
		{
			get { return socket?.RemoteEndPoint as IPEndPoint; }
		}

		public event EventHandler ConexionTerminada;
		public event EventHandler<DatosRecibidosEventArgs> DatosRecibidos;

		public void Conectar(string ip, int puerto)
		{
			if (Conectado)
            {
                socket.Disconnect(true);
            }
			socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
			socket.Connect(ip, puerto);
			Conectado = true;

			thread = new Thread(LeerSocket);
			thread.IsBackground = true; 
			thread.Start();
		}

		public void EnviarDatos(string datos)
		{
			if (!Conectado) return;
			byte[] bytes = Encoding.UTF8.GetBytes(datos);
			socket?.Send(bytes);
		}

		private void LeerSocket()
		{
			var buffer = new byte[100];
			while (true)
			{
				try
				{
					int cantidadRecibida = socket.Receive(buffer, buffer.Length, SocketFlags.None);
					if (cantidadRecibida > 0)
					{
						string mensaje = Encoding.UTF8.GetString(buffer, 0, cantidadRecibida);
						DatosRecibidos?.Invoke(this, new DatosRecibidosEventArgs(mensaje));
					}
				}
				catch
				{
					socket.Close();
					break;
				}
			}

			Conectado = false;
			ConexionTerminada?.Invoke(this, new EventArgs());
		}
	}

	public class DatosRecibidosEventArgs : EventArgs
	{
		public DatosRecibidosEventArgs(string datos)
		{
			DatosRecibidos = datos;
		}

		public string DatosRecibidos { get; set; }
	}
}
