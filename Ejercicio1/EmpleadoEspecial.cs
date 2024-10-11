using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class EmpleadoEspecial : Empleado, IPastaGansa
    {
        public double ganarPasta(double benefEmpr)
        {
            return benefEmpr * 0.005;
        }
        public override double Hacienda()
        {
            return base.Hacienda() + 1.5;
        }
        public EmpleadoEspecial(string nombre, string apellidos, int edad, string dni, string tlf,double salario) :base(nombre,apellidos,edad,dni,tlf,salario) {}
        public EmpleadoEspecial() : base("","",0,"1","",0.0) {}
    }
}
