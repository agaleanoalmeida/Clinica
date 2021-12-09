using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Clinica
{
    internal class Medico : Persona
    {
        //ATRIBUTOS

        public String especialidad { get; set; }
        public List<Paciente> pacientes { get; set; }

        public Boolean ocupado;

        //CONSTRUCTORES
        public Medico() { 
        
            this.pacientes = new List<Paciente>();
        }

        public Medico(String especialidad, List<Paciente> pacientes)
        {
            this.especialidad = especialidad;

            this.pacientes = new List<Paciente>();

        }




        //METODOS


        //Asigna un paciente a un medico y lo pone en estado ocupado.
        public void asignarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
            ocupado = true;
        }


        //Atiende un paciente y vuelve el estado a desocupado del medico

        public void atenderPaciente(Paciente paciente)
        {
            pacientes.Remove(paciente);
            ocupado = false;
        }


        // Muestra la lista de pacientes
        public void verPacientesAsignados()
        {
            foreach (Paciente item in pacientes)
            {
                Console.WriteLine(item.nombre);
            }
        }
    }
}
