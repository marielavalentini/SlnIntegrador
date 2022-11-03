using Entidades.Clases_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase_derivada
{
    public class Medico : Persona
    {
        #region Constructores
        public Medico (int pId, string pNombre, string pApellido, string pDomicilio,
            string pTelefono, string pEmail, string pEspecialidad, string pMatricula) : base(pId, pNombre, pApellido, pDomicilio, pTelefono, pEmail)
        {
            Especialidad = pEspecialidad;
            Matricula = pMatricula;
        }
        public Medico() { }
        #endregion

        public string Especialidad { get; set; }
        public string Matricula { get; set; }
    }
}
