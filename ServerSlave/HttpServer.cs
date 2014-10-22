using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace ServerSlave
{
   public class HttpServer
   {
      
         public void Socket()
       {
     
           TcpListener serverSocket = new TcpListener(8080);

           serverSocket.Start();
           while (true)
           {
               TcpClient connectionSocket = serverSocket.AcceptTcpClient();
               //Socket connectionSocket = serverSocket.AcceptSocket();
               Console.WriteLine("Server activated");
               EchoServices EchoS = new EchoServices(connectionSocket); //henter EchoServices. og metode.
               EchoS.Dolt();
           }

           serverSocket.Stop();
       }
   }
}
