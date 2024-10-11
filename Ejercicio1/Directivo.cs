using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Directivo : Persona, IPastaGansa
    {
        private string departamento;
        private double beneficios; 
        private double PastaGanada;
        private int personasACargo;
        public int PersonasACargo
        {
            get
            {
                return personasACargo;
            }
            set
            {
                if (value < 10)
                {
                    beneficios = 2;
                }
                if (value >= 11 && value <= 50)
                {
                    beneficios = 3.5;
                }
                else
                {
                    beneficios = 4;
                }
                personasACargo = value;
            }
        }

        public override double Hacienda()
        {
            return PastaGanada * 0.3;
        }

        public static Directivo operator --(Directivo d)
        {
            d.beneficios--;
            if (d.beneficios <= 0)
            {
                d.beneficios = 0;
            }
            return d;
        }

        

        public override void Sobres()
        {
            base.Sobres();
            departamento = PedirDatos("Departamento");
            do
            {
                PersonasACargo = Convert.ToInt32(PedirDatos("Personas a cargo"));
            } while (PersonasACargo < 0);
        }

        public Directivo(string nombre, string apellidos, int edad, string dni, int personasCargo, string departamento) : base(nombre, apellidos, edad, dni)
        {
            this.PersonasACargo = personasCargo;
            this.departamento = departamento;
        }
        public Directivo() : this("", "", 0, "1", 0, "") { }
        public double ganarPasta(double pasta)
        {
            if (beneficios < 0)
            {
                Directivo d = this;
                d--;
                PastaGanada = 0;
                return 0;
            }
            else
            {
                PastaGanada = beneficios * pasta / 100;
                return beneficios * pasta / 100;
            }
        }
        public override void Muestra()
        {
            base.Muestra();
            Console.WriteLine($"Departamento: {departamento}");
            Console.WriteLine($"Beneficios: {beneficios}");
            Console.WriteLine($"Personas a cargo: {PersonasACargo}");
        }
    }
    interface IPastaGansa
    {
        double ganarPasta(double pasta);
    }

}
