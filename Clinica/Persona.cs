using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    abstract class Persona
    {
        //ATRIBUTOS

        public String apellido { get; set; }
        public int dni { get; set; }
        public String nombre { get; set; }   
        public int edad { get; set; }


        public Persona()
        {
        }

        public Persona(String apellido, int dni, String nombre, int edad)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
