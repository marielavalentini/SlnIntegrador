using Entidades.Clase_derivada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        static List<Paciente> listaPacientes;

        public static List<Paciente> Listar ()
        {
            listaPacientes = new List<Paciente> ();

            Paciente paciente1 = new Paciente(54746654, "Catalina", "Juarez", "Don Bosco 654", "2234516442", null, 19873, new DateTime(1976,05,12));
            Paciente paciente2 = new Paciente(28536215, "Juan", "Garcia", "Av Edison 2761", "2234581981", "juangarcia@gmail.com", 56721, new DateTime(2001,09,12));
            Paciente paciente3 = new Paciente(45231781, "Jorgelina", "Thompson", "Av Constitucion 123", "2236712093", "jthompson@gmail.com", 72410, new DateTime(1982,11,9));
            Paciente paciente4 = new Paciente(21561944, "Martin", "Delgado", "Santa Fe 982", "2236778441", "martind@gmail.com", 66198, new DateTime(1945,8,21));
            Paciente paciente5 = new Paciente(36541998, "Lucila", "Castro", "Jujuy 2615", "2235661223", "lcastro@yahoo.com", 88765, new DateTime(1998,5,25));

            listaPacientes.Add (paciente1);
            listaPacientes.Add (paciente2);
            listaPacientes.Add (paciente3);
            listaPacientes.Add (paciente4);
            listaPacientes.Add (paciente5);

            return listaPacientes;
        }

        public static int Insertar (Paciente unPaciente)
        {
            //TODO agregar metodo para insertar un paciente en una lista
            return 0;
        }

        public static int Eliminar (int id)
        {
            //TODO agregar metodo que permita eliminar un paciente de una lista por id
            return 0;
        }

        public static Paciente TraerUno (int id)
        {
            //TODO agregar un metodo que reciba un id de paciente y me retorne el paciente con ese id
            return null;
        }
    }
}
