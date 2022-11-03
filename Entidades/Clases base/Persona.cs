using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_base
{
    public abstract class Persona
    {
        #region Constructores
        public Persona (int pId, string pNombre, string pApellido, string pDomicilio,
            string pTelefono, string pEmail)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
            Domicilio = pDomicilio;
            Telefono = pTelefono;
            Email = pEmail;
        }
        public Persona() { }
        #endregion
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
