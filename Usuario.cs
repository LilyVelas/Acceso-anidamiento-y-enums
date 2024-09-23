using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso__anidamiento_y_enums
{
    public enum TipoUsuario { Vendedor, JefeVentas, Contador, Administrador }
    public class Usuario
    {
        private string nombre;
        private TipoUsuario tipoUsuario;

        public Usuario(string nombre, TipoUsuario tipoUsuario)
        {
            this.nombre = nombre;
            this.tipoUsuario = tipoUsuario;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public TipoUsuario TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
    }
}
