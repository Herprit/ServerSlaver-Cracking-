using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace ServerSlave
{
    public class Program
    {
        static void Main(string[] args)
        {

            HttpServer Server = new HttpServer();
            Server.Socket();
           


        }
    }
}
