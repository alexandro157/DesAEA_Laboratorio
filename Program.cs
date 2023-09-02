using Laboratorio1;

class Program
{
    static Grifo grifo = new Grifo(); // Instancia de la clase Grifo para almacenar usuarios

    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Mostrar Información de usuarios");
            Console.WriteLine("2. Agregar Cliente");
            Console.WriteLine("3. Agregar Empleado");
            Console.WriteLine("4. Salir");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        MostrarInformacionUsuarios();
                        break;
                    case 2:
                        AgregarCliente();
                        break;
                    case 3:
                        AgregarEmpleado();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente nuevamente.");
            }
        }
    }

    static void MostrarInformacionUsuarios()
    {
        Console.WriteLine("Información de usuarios:");
        int contador = 1;

        foreach (var usuario in grifo.Usuarios)
        {
            Console.WriteLine($"Usuario {contador}:");
            usuario.MostrarInformacion();
            Console.WriteLine();
            contador++;
        }
    }

    static void AgregarCliente()
    {
        Console.WriteLine("Ingrese el nombre del cliente:");
        string nombre = Console.ReadLine();

        double saldo;
        Console.WriteLine("Ingrese el saldo del cliente:");
        if (!double.TryParse(Console.ReadLine(), out saldo))
        {
            Console.WriteLine("Saldo no válido. El cliente no se ha agregado.");
            return;
        }

        double litrosCargados;
        Console.WriteLine("Ingrese los litros cargados del cliente:");
        if (!double.TryParse(Console.ReadLine(), out litrosCargados))
        {
            Console.WriteLine("Litros cargados no válidos. El cliente no se ha agregado.");
            return;
        }

        Cliente cliente = new Cliente(nombre, saldo, litrosCargados);
        grifo.AgregarUsuario(cliente);
        Console.WriteLine("Cliente agregado con éxito.");
    }

    static void AgregarEmpleado()
    {
        Console.WriteLine("Ingrese el nombre del empleado:");
        string nombre = Console.ReadLine();

        double saldo;
        Console.WriteLine("Ingrese el saldo del empleado:");
        if (!double.TryParse(Console.ReadLine(), out saldo))
        {
            Console.WriteLine("Saldo no válido. El empleado no se ha agregado.");
            return;
        }

        double sueldo;
        Console.WriteLine("Ingrese el sueldo del empleado:");
        if (!double.TryParse(Console.ReadLine(), out sueldo))
        {
            Console.WriteLine("Sueldo no válido. El empleado no se ha agregado.");
            return;
        }

        Empleado empleado = new Empleado(nombre, saldo, sueldo);
        grifo.AgregarUsuario(empleado);
        Console.WriteLine("Empleado agregado con éxito.");
    }
}
