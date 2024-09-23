using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso__anidamiento_y_enums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Trabajador trabajador = new Trabajador("Gabriel", "Ingeniería Industrial", "161290394N", 30);

            // Intentamos acceder a los miembros privados dando un error
            // Console.WriteLine(trabajador.nombre); // Error: 'Trabajador.nombre' is inaccessible due to its protection level

            // Utilizamos getters y setters para acceder
          
            Console.WriteLine(trabajador.Nombre);
            trabajador.Edad = 31;
            Console.WriteLine(trabajador.Edad); // 31 



            List<Usuario> usuarios = new List<Usuario>();

            // Registro de usuarios
            usuarios.Add(new Usuario("Josue", TipoUsuario.Vendedor));
            usuarios.Add(new Usuario("Nery", TipoUsuario.JefeVentas));
            usuarios.Add(new Usuario("Jared", TipoUsuario.Contador));
            usuarios.Add(new Usuario("Angel", TipoUsuario.Administrador));
            usuarios.Add(new Usuario("Gabriel", TipoUsuario.Contador));
            usuarios.Add(new Usuario("Abby", TipoUsuario.Administrador));

            // Desplegamos las operaciones según el tipo de usuario
            foreach (var usuario in usuarios)
            {
                switch (usuario.TipoUsuario)
                {
                    case TipoUsuario.Vendedor:
                        Console.WriteLine($"Usuario {usuario.Nombre} es un vendedor");
                        break;
                    case TipoUsuario.JefeVentas:
                        Console.WriteLine($"Usuario {usuario.Nombre} es un jefe de ventas");
                        break;
                    case TipoUsuario.Contador:
                        Console.WriteLine($"Usuario {usuario.Nombre} es un contador");
                        break;
                    case TipoUsuario.Administrador:
                        Console.WriteLine($"Usuario {usuario.Nombre} es un administrador");
                        break;
                }
            }

        }   


    }
}
