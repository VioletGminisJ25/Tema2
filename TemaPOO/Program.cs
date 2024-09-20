using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaPOO;

namespace TemaPOO
{

    class Program
    {
        static void Main()
        {
            Perro objPerro = new Perro();
            objPerro.raza = "Mastín";
            objPerro.nombre = "Laika";
            objPerro.Edad = 5;
            Console.WriteLine(objPerro.Edad);
            Console.ReadLine();
        }
    }
}
