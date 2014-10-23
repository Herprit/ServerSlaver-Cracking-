using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;

namespace ServerSlave
{
   public class HttpServer
   {
      
         public void Socket()
       {

           TcpListener serverSocket = new TcpListener(8080);
           TcpClient connectionSocket;
          
           serverSocket.Start();
           while (true)
           {    
               
               connectionSocket = serverSocket.AcceptTcpClient();
               
               Console.WriteLine("Server activated");
              

               NetworkStream ns = connectionSocket.GetStream();
              

               string theMessage = OpenReader(ns);

               while (theMessage != null && theMessage != "")
               {

                   Console.WriteLine("Client: " + theMessage);
                
                   theMessage = OpenReader(ns);


               }

               string OkMessage = "OK";
               OpenWriter(ns, OkMessage);
               Console.WriteLine("Message Sent: " + OkMessage);
 
               
               

               

               ns.Close();
               connectionSocket.Close();

               Console.ReadLine();
           }

            
           serverSocket.Stop();
           connectionSocket.Close();
       }

       public void OpenWriter(NetworkStream ns, string message)
       {
           StreamWriter sw = new StreamWriter(ns);
           sw.AutoFlush = true;
           sw.Write(message);

       }

       public string OpenReader(NetworkStream ns)
       {
           StreamReader sr = new StreamReader(ns);
           string getResponse = sr.ReadLine();

           return getResponse;

       }
   }
}
