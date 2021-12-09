using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Paciente : Persona
    {
        //ATRIBUTOS

        public ObraSocial obraSocial;

        //CONSTRUCTORES

        public Paciente() { }

        public Paciente(ObraSocial obraSocial)
        {
            this.obraSocial = obraSocial;
        }


        //Devuelve un string con el nombre del paciente 

        public override string ToString()
        {
            return nombre;

        }
    }
}
