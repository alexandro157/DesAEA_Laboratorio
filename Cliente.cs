using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Cliente : Usuario
    {
        // Propiedad adicional
        public double LitrosCargados { get; set; }

        // Constructor
        public Cliente(string nombre, double saldo, double litrosCargados)
            : base(nombre, saldo)
        {
            LitrosCargados = litrosCargados;
        }

        // Sobrescribir el método MostrarInformacion
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Litros Cargados: {LitrosCargados}");
        }
    }
}
