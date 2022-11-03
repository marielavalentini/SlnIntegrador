using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ayudantes
{
    public static class UtilidadesFechas
    {
        //Programar un método CalcularEdad, recibe por parámetro la fecha de nacimiento.
        public static int CalcularEdad (DateTime FechaNacimiento)
        {
            DateTime FechaActual = DateTime.Now;
            int Edad = (FechaActual.Year - FechaNacimiento.Year);
            if(FechaNacimiento.Month > FechaActual.Month)
            {
                Edad = Edad - 1;
            }
            return Edad;
        }
    }
}
