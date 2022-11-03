using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clinica
    {
        #region Constructores
        public Clinica (int pId, string pNombre, string pDomicilio, string pTelefono, string pEmail)
        {
            Id = pId;
            Nombre = pNombre;
            Domicilio = pDomicilio;
            Telefono = pTelefono;
            Email = pEmail;
        }
        #endregion
        public Clinica() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
