using Entidades.Clases_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase_derivada
{
    public class Enfermero : Persona
    {
        #region Constructores

        public Enfermero(int pId, string pNombre, string pApellido, string pDomicilio,
            string pTelefono, string pEmail, string pCuil) : base(pId, pNombre, pApellido, pDomicilio, pTelefono, pEmail)
        {
            Cuil = pCuil;
        }
        public Enfermero() { }

        #endregion
        public string Cuil { get; set; }

    }
}
