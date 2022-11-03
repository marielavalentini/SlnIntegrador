using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    public class Habitacion
    {
        #region Constructores
        public Habitacion(int pId, int pNumero, string pEstado)
        {
            Id = pId;
            Numero = pNumero;
            Estado = pEstado;
        }
        public Habitacion() { }
       
        #endregion
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
    }
}
