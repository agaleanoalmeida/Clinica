namespace Clinica
{
    class Program
    {

        static object Main()
        {
            Paciente paciente = new Paciente();
            paciente.dni = 36746324;
            paciente.apellido = "Sevilla";
            paciente.nombre = "Juanito";
            paciente.obraSocial = ObraSocial.NoTiene;
            paciente.edad = 29;


            Paciente paciente1 = new Paciente();
            paciente1.dni = 42874655;
            paciente1.apellido = "Chavez";
            paciente1.nombre = "Pepito";
            paciente1.obraSocial = ObraSocial.CobreturaCompleta;
            paciente1.edad = 24;


            Medico medico1 = new Medico();
            medico1.nombre = "Willy";
            medico1.especialidad = "Cardiologo";
            medico1.edad = 32;
            medico1.dni = 32123443;
            medico1.apellido = "Milagro";

            Medico medico2 = new Medico();
            medico2.nombre = "Peter";
            medico2.especialidad = "Proctólogo";
            medico2.edad = 45;
            medico2.dni = 26145443;
            medico2.apellido = "Vergara";

                medico1.asignarPaciente(paciente);
                medico1.verPacientesAsignados();

                medico1.atenderPaciente(paciente);

        }
    }
}