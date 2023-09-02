using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1

{
    class Usuario
    {
        // Propiedades
        public string Nombre { get; set; }
        public double Saldo { get; set; }

        // Constructor
        public Usuario(string nombre, double saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }

        // Método virtual para mostrar información
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}
