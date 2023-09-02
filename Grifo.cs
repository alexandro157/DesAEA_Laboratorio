using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Grifo
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public List<Usuario> Usuarios
        {
            get { return usuarios; }
        }

        // Agregar un usuario a la lista
        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        // Mostrar la información de todos los usuarios en el grifo
        public void MostrarUsuarios()
        {
            foreach (var usuario in usuarios)
            {
                usuario.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }
}
