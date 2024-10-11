using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directivo directivo = new Directivo("Javier","Santos",19,"54321779",23,"Informatica");
            Empleado empleado = new Empleado("Alejandro","Miranda",24,"67865626","332123467",5);
            EmpleadoEspecial emplEsp = new EmpleadoEspecial("Adrián","Estévez",24,"67830298","748394857",6);

            int seleccion;
            do
            {
                Console.WriteLine("1.- Visualizar los datos del Directivo\n2.- Visualizar los datos Empleado\n3.- Visualizar datos EmpleadoEspecial\n4.- Salir");
                seleccion = Convert.ToInt32(Console.ReadLine());
                switch (seleccion)
                {
                    case 1:
                        directivo.Muestra();
                        Ganancias(directivo);
                        Console.WriteLine($"Hacienda: {directivo.Hacienda()}");
                        break;
                    case 2:
                        empleado.Muestra();
                        Console.WriteLine($"Hacienda: {empleado.Hacienda()}");
                        break;
                    case 3:
                        emplEsp.Muestra();
                        Ganancias(emplEsp);
                        Console.WriteLine($"Hacienda: {emplEsp.Hacienda()}");
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            } while (seleccion !=4);


        }

        public static void Ganancias(IPastaGansa dirempl)
        {
            Console.WriteLine("Introduce las ganacias de la empresa: ");
            string ganacias = Console.ReadLine();
            Console.WriteLine($"Las ganancias son de {dirempl.ganarPasta(Convert.ToInt32(ganacias))}");
        }
    }




}
