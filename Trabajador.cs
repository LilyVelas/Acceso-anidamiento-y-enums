using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Acceso__anidamiento_y_enums
{
    public class Trabajador
    {
        private string nombre;
        private string profesión;
        private string identificación;
        private int edad;

        public Trabajador(string nombre, string profesión, string identificación, int edad)
        {
            this.nombre = nombre;
            this.profesión = profesión;
            this.identificación = identificación;
            this.edad = edad;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Porfavor ingrese su nombre >:(");
                }

                this.nombre = value;
            }

        }

        protected string[] profesiones = { "Administración de Empresas", "Marketing", "Comercio Internacional", "Relaciones Públicas", "Ingeniería Comercial", "Contaduría Pública", "Finanzas", "Economía", "Ingeniería Industral" };
        public string Profesión
        {
            get { return this.profesión; }
            set
            {
                if (!profesiones.Contains(value))
                {
                    throw new ArgumentException("Profesión invalida para el tipo de trabajo");
                }
                profesión = value;
            }
        }

        public string Identificación
        {
            get { return this.identificación; }
            set
            {
                if (!Regex.IsMatch(value, @"^[0-9A-Z){14}$"))
                {
                    throw new ArgumentException("Ingrese el formato correcto de cédula nicaragüense correcto");
                }
                identificación = value;
            }
        }

        public int Edad
        { get { return this.edad; }
          set
          {
                if (value < 0 || value > 75)
                { 
                    throw new ArgumentException("Ingrese una edad valida o permitida");
                }
                value = edad;
          }
        }

    }
}
