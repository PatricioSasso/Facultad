using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;

namespace ServidorAhorcado
{
    public class Servidor
    {
        private struct InfoDeUnCliente
        {
            public Socket Socket;
            public Thread Thread;
        }

        Thread listenerThread;
        TcpListener listener;

        ConcurrentDictionary<IPEndPoint, InfoDeUnCliente> clientes = new ConcurrentDictionary<IPEndPoint, InfoDeUnCliente>();

        public event EventHandler<ServidorEventArgs> NuevaConexion;
        public event EventHandler<ServidorEventArgs> ConexionTerminada;
        public event EventHandler<DatosRecibidosEventArgs> DatosRecibidos;

        public int PuertoDeEscucha { get; }

        public Servidor(int puerto)
        {
            PuertoDeEscucha = puerto;
        }

        public void Escuchar()
        {
            listener = new TcpListener(IPAddress.Any, PuertoDeEscucha);

            listener.Start();

            listenerThread = new Thread(EsperarCliente);

            listenerThread.IsBackground = true;
            listenerThread.Start();
        }

        public void Cerrar()
        {
            foreach (var cliente in clientes.Values)
            {
                cliente.Socket.Close();
            }
        }

        public void EnviarDatos(string datos)
        {
            foreach (var cliente in clientes.Values)
            {
                cliente.Socket.Send(Encoding.UTF8.GetBytes(datos));
            }
        }

        private void EsperarCliente()
        {
            while (true)
            {
                var socket = listener.AcceptSocket();
                var endPoint = socket.RemoteEndPoint as IPEndPoint;
                var thread = new Thread(() => LeerSocket(endPoint));
                thread.IsBackground = true;
                clientes[endPoint] = new InfoDeUnCliente()
                {
                    Socket = socket,
                    Thread = thread,
                };
                NuevaConexion?.Invoke(this, new ServidorEventArgs(endPoint));
                thread.Start();
            }
        }

        private void LeerSocket(IPEndPoint endPoint)
        {
            var buffer = new byte[100];
            var cliente = clientes[endPoint];
            while (cliente.Socket.Connected)
            {
                try
                {
                    int cantidadRecibida = cliente.Socket.Receive(buffer, buffer.Length, SocketFlags.None);
                    if (cantidadRecibida > 0)
                    {
                        var datosRecibidos = Encoding.UTF8.GetString(buffer, 0, cantidadRecibida);
                        DatosRecibidos?.Invoke(this, new DatosRecibidosEventArgs(endPoint, datosRecibidos));
                    }
                    else
                    {
                        ConexionTerminada?.Invoke(this, new ServidorEventArgs(endPoint));
                        break;
                    }
                }
                catch
                {
                    if (!cliente.Socket.Connected)
                    {
                        ConexionTerminada?.Invoke(this, new ServidorEventArgs(endPoint));
                        break;
                    }
                }
            }
            clientes.TryRemove(endPoint, out cliente);
        }

    }

    public class ServidorEventArgs : EventArgs
    {
        public ServidorEventArgs(IPEndPoint ep)
        {
            EndPoint = ep;
        }

        public IPEndPoint EndPoint { get; }
    }

    public class DatosRecibidosEventArgs : ServidorEventArgs
    {
        public DatosRecibidosEventArgs(IPEndPoint ep, string datos) : base(ep)
        {
            DatosRecibidos = datos;
        }

        public string DatosRecibidos { get; set; }
    }
}
