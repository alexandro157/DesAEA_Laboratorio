using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Empleado : Usuario
    {
        // Propiedad adicional
        public double Sueldo { get; set; }

        // Constructor
        public Empleado(string nombre, double saldo, double sueldo)
            : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }

        // Sobrescribir el método MostrarInformacion
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }
}
