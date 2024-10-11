using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        private int edad;
        private string dni;
        public int Edad   //TODO revisar set/get OK
        {
            get
            {
                return edad;
            }
            set
            {
                if (value < 0)
                {
                    edad = 0;
                }
                else
                {
                    edad = value;
                }
            }
        }
        public string Dni
        {
            get
            {
                return dni + ("TRWAGMYFPDXBNJZSQVHLCKE"[(Convert.ToInt32(dni) % 23)]).ToString();
            }
            set
            {
                dni = value;
            }
        }//No cumple espef OK

        public virtual void Muestra()
        {
            Console.WriteLine($"Nombre: {Nombre}\nApellidos: {Apellidos}\nEdad: {Edad}\nDNI: {Dni}");
        }

        public virtual void Sobres()
        {
            Nombre = PedirDatos("Nombre: ");
            Apellidos = PedirDatos("Apellidos: ");
            Edad = Convert.ToInt32(PedirDatos("Edad: "));
            Dni = PedirDatos("DNI: ");
        }
        public string PedirDatos(string dato)
        {
            Console.WriteLine($"{dato}: ");
            return Console.ReadLine();
        }

        public Persona(string nombre, string apellidos, int edad, string dni)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Dni = dni;
        }

        public abstract double Hacienda();
    }
}
