using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSlave
{
    public class HttpHeaders
    {
        public string RN = "\r\n"; // skifterlinje  //clrf

        public string _date = "Date: " + DateTime.Now.ToString();

        public string Length = "content lenght: ";

        public string contentType = "Content type: text/html";



        public HttpHeaders()
        {
           
            

        }
    }
}