using Entidades.Ayudantes;
using Entidades.Clases_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase_derivada
{
    public class Paciente : Persona
    {
        #region Constructores
        public Paciente(int pId, string pNombre, string pApellido, string pDomicilio,
            string pTelefono, string pEmail, int pNroHistoriaClinica, DateTime pFechaNacimiento) : base(pId, pNombre, pApellido, pDomicilio, pTelefono, pEmail)
        {
            NroHistoriaClinica = pNroHistoriaClinica;
            FechaNacimiento = pFechaNacimiento;
            edad = UtilidadesFechas.CalcularEdad(FechaNacimiento);
            
        }

        #endregion
        public int NroHistoriaClinica { get; set; }
        public DateTime FechaNacimiento { get; set; }
        private int edad;

        public int Edad
        {
            get { return edad; }
          
        }

    }
}
