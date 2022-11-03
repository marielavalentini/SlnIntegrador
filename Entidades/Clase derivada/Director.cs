using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase_derivada
{
    public class Director : Medico
    {
        #region Constructores

        public Director(int pId, string pNombre, string pApellido, string pDomicilio,
            string pTelefono, string pEmail, string pEspecialidad, string pMatricula,string pPostGrado) : base(pId,pNombre,pApellido,pDomicilio,
                pTelefono,pEmail,pEspecialidad,pMatricula)
        {
            PostGrado = pPostGrado; 
        }

        public Director() { }

        #endregion
        public string PostGrado { get; set; }
    }
}
