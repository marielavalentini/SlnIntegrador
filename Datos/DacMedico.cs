using Entidades.Clase_derivada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class DacMedico
    {
        //List<Medico> listaMedicos;

        public static List<Medico> Select()
        {
            //TODO agregar metodo que retorne una lista de medicos
            return null;
        }

        public static List<Medico> Select (string Especialidad)
        {
            //TODO agregar un metodo que retorne una lista de medicos por especialidad
            return null;
        }

        public static int Insert (Medico unMedico)
        {
            //TODO agregar un metodo para insertar un medico
            return 0;
        }

        public static int Eliminar (int id)
        {
            //TODO agregar metodo para eliminar un medico por id
            return 0;
        }
        public static Medico SelectById (int id)
        {
            //TODO agregar metodopara seleccionar medico por id
            return null;
        }
    }
}
