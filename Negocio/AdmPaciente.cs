using Entidades.Clase_derivada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmPaciente
    {
        List<Paciente> listaPacientes;

        public List<Paciente> Listar ()
        {
            listaPacientes = new List<Paciente> ();

            Paciente paciente1 = new Paciente(54746654, "Catalina", "Juarez", "Don Bosco 654", "2234516442", null, 19873);
            Paciente paciente2 = new Paciente(28536215, "Juan", "Garcia", "Av Edison 2761", "2234581981", "juangarcia@gmail.com", 56721);
            Paciente paciente3 = new Paciente(45231781, "Jorgelina", "Thompson", "Av Constitucion 123", "2236712093", "jthompson@gmail.com", 72410);
            Paciente paciente4 = new Paciente(21561944, "Martin", "Delgado", "Santa Fe 982", "2236778441", "martind@gmail.com", 66198);
            Paciente paciente5 = new Paciente(36541998, "Lucila", "Castro", "Jujuy 2615", "2235661223", "lcastro@yahoo.com", 88765);

            listaPacientes.Add (paciente1);
            listaPacientes.Add (paciente2);
            listaPacientes.Add (paciente3);
            listaPacientes.Add (paciente4);
            listaPacientes.Add (paciente5);

            return listaPacientes;
        }

        public int Insertar (Paciente unPaciente)
        {
            //TODO agregar metodo para insertar un paciente en una lista
            return 0;
        }

        public int Eliminar (int id)
        {
            //TODO agregar metodo que permita eliminar un paciente de una lista por id
            return 0;
        }

        public Paciente TraerUno (int id)
        {
            //TODO agregar un metodo que reciba un id de paciente y me retorne el paciente con ese id
            return null;
        }
    }
}
