using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase06.Entidades;

namespace Clase06.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera t1 = new Tempera(ConsoleColor.Blue, "asd", 10);

            Paleta p = 8;

            p += t1;

            Console.WriteLine((string)p);
            Console.ReadLine();
        }
    }
}
