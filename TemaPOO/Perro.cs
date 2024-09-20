using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPOO
{
    class Perro
    {

        public string raza;
        public string nombre;

        private int edad;
        // Nota: aunque lo veas así en este ejemplo,
        // en C# NO haremos el set y el get de esta forma.
        // La correcta se explica en un apartado posterior.

        public int Edad { 
            get 
            {
                return edad;
            }
            set
            { 
                if (value < 0) { 
                    value = 0;
                }
                this.edad = value;
            }
        }
        //public int getEdad()
        //{
        //    return edad;
        //}
        //public void setEdad(int edad)
        //{
        //    this.edad = edad;
        //}

        public Perro()
        {
            this.Edad = 0;
            this.raza = "";
            this.nombre = "";
        }
    }
    

}
