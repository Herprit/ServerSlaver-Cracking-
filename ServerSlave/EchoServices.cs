using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace ServerSlave
{
   public class EchoServices
    {
        TcpClient connectionSocket;

         HttpHeaders header;
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

            header = new HttpHeaders();

            string message = sr.ReadLine();
            string answer = "";

            while (message != null && message != "")
            {

                Console.WriteLine("Client: " + message + header.RN + header._date+ header.RN +  header.Length + header.RN+ header.contentType);
                answer = message.ToUpper();
                sw.WriteLine(answer);
                message = sr.ReadLine();

            }

            ns.Close();
            connectionSocket.Close();
            
        }
    }
}