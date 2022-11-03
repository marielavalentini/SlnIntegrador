using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmHabitacion
    {
         static List<Habitacion> listaHabitaciones;

        public static List<Habitacion> Listar()
        {
            listaHabitaciones = new List<Habitacion>();

            Habitacion habitacion1 = new Habitacion(0, 5123, "ocupada");
            Habitacion habitacion2 = new Habitacion(1, 9876, "libre");
            Habitacion habitacion3 = new Habitacion(2, 5674, "ocupada");
            Habitacion habitacion4 = new Habitacion(3, 8769,"ocupada");
            Habitacion habitacion5 = new Habitacion(4, 6501, "libre");

            listaHabitaciones.Add(habitacion1);
            listaHabitaciones.Add(habitacion2);
            listaHabitaciones.Add(habitacion3);
            listaHabitaciones.Add(habitacion4);
            listaHabitaciones.Add(habitacion5);


            return listaHabitaciones;
        }

        public static List<Habitacion> Listar (string Estado)
        {
            //TODO agregar metodo para listar habitaciones por estado, recibido por parametro
            return null;
        }

        public static int Insertar (Habitacion unaHabitacion)
        {
            //TODO agregar un metodo para insertar una habitacion en la lista
            return 0;
        }

        public static int Eliminar (int id)
        {
            //TODO agregar un metodo para eliminar una habitacion de una lista por id
            return 0;
        }

        public static Habitacion TraerUno (int Numero)
        {
            //TODO agregar un metodo para traer una habitacion por numero
            return null;
        }
    }
}
