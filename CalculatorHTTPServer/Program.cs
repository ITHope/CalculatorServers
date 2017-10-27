using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorHTTPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerHTTPListener server = new ServerHTTPListener("localhost", "8888");
            Console.Read();
        }
    }
}
