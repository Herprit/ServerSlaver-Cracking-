using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace ServerSlave
{
   public class EchoServices
    {
        TcpClient connectionSocket;

        public EchoServices(TcpClient connection)
        {
            this.connectionSocket = connection;
        }

        public void Dolt()
        {
            Stream ns = connectionSocket.GetStream();
            // Stream ns = new NetworkStream(connectionSocket);

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // e
            string message = sr.ReadLine();
            string answer = "";

            while (message != null && message != "")
            {

                Console.WriteLine("Client: " + message);
                answer = message.ToUpper();
                sw.WriteLine(answer);
                message = sr.ReadLine();

            }

            ns.Close();
            connectionSocket.Close();
            
        }
    }
}
