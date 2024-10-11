using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Empleado : Persona
    {
        private string tlf;
        private double salario;
        public double Salario
        {
            get
            {
                return salario;
            }
            set 
            {
                
                if (value < 600)
                {
                    irpf = 7;// value * 0.07;
                }if(value >=600 && value <= 3000)
                {
                    irpf = 15;
                }
                else
                {
                    irpf = 2;
                }
                salario = value;
            }
        }//No cumple espec OK
        private double irpf;
        private double Irpf 
        { 
            get 
            {
                return irpf;
            } 
        }
        public string Tlf
        {
            get
            {
                return "+34" + tlf;
            }
            set
            {
                tlf = value;
            }
        }

        public override void Muestra()
        {
            base.Muestra();
            Console.WriteLine($"Tlf: {tlf}");
            Console.WriteLine($"Salario: {Salario}");
            Console.WriteLine($"IRPF: {Irpf}");
        }
        public override void Sobres()
        {
            base.Sobres();
            Tlf = PedirDatos("Tlf: ");
            Salario =Convert.ToInt32(PedirDatos("Salario: "));
        }

        public void Muestra(int n)
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine($"Nombre {Nombre}");
                    break;
                case 1:
                    Console.WriteLine($"Apellidos: {Apellidos}");
                    break;
                case 2:
                    Console.WriteLine($"Edad: {Edad}");
                    break;
                case 3:
                    Console.WriteLine($"DNI: {Dni}");
                    break;
                case 4:
                    Console.WriteLine($"Telefono: {Tlf}");
                    break;
                case 5:
                    Console.WriteLine($"Salario: {Salario}");
                    break;
                case 6:
                    Console.WriteLine($"IRPF: {Irpf}");
                    break;
            }
        }

        public override double Hacienda()
        {
            return Irpf * Salario / 100;
        }

        public Empleado(string nombre, string apellidos, int edad, string dni, string tlf, double salario) : base(nombre, apellidos, edad, dni)
        {
            this.Tlf = tlf;
            this.Salario = salario;
        }
        public Empleado() : this("", "", 0, "1", "", 0.0) { }
    }
}
