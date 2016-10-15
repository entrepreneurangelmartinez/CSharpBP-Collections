using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaEjecution
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClaseGenerica<string> anel = new MiClaseGenerica<string>("Dominion","prueba");

            Console.WriteLine(anel.Result + " " + anel.Message);

            
        }
    }
}
