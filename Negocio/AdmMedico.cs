using Entidades.Clase_derivada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmMedico
    {
        List<Medico> listaMedicos;

        public List<Medico> Listar()
        {
            listaMedicos = new List<Medico>();

            Medico medico1 = new Medico(123, "Mario", "Lopez", "Av Colon 2324", "2235678342",
                                        "mariolopez@gmail.com", "pediatra", "MP2345");
            Medico medico2 = new Medico(341, "Jorge", "Perez", "Av Independencia 3451",
                                        "2235671231", "jorgeperez@gmail.com", "Obstetra", "MN7654");
            Medico medico3 = new Medico(574, "Maria", "Gimenez", "San Luis 1239",
                                        "2235985482", "mariagimenez@hotmail.com", "pediatra", "MP7642");
            Medico medico4 = new Medico(984, "Estela", "Ramirez", "Cordoba 6542",
                                        "2234561765", "eramirez@outlook.com", "clinico", "MN8732");
            Medico medico5 = new Medico(872, "Griselda", "Vargas", "Las heras 2351",
                                        "2235784265", "gvargas@gmail.com", "traumatologa", "MN5642");


            listaMedicos.Add(medico1);
            listaMedicos.Add(medico2);
            listaMedicos.Add(medico3);
            listaMedicos.Add(medico4);
            listaMedicos.Add(medico5);

            return listaMedicos;
        }

        public List<Medico> Listar(string Especialidad)
        {
            listaMedicos = Listar();
            List<Medico> listaAux = new List<Medico>();

            foreach (Medico medico in listaMedicos)
            {
                if (medico.Especialidad == Especialidad)
                {
                    listaAux.Add(medico);
                }
            }
            return listaAux;
        }

        public int Insertar (Medico unMedico)
        {
            //TODO completar metodo para insertar un medico en la lista
            return 0;
        }

        public int Eliminar (int id)
        {
            //TODO agregar metodo para eliminar un medico de la lista por id
            return 0;
        }

        public Medico TraerUno (int id)
        {
            //TODO agregar el metodo para buscar un medico en la lista por id
            return null;
        }

        public List<Medico> Cargar (List<Medico> unaListaMedicos)
        {
            unaListaMedicos = new List<Medico>();

            Medico medico1 = new Medico(123, "Mario", "Lopez", "Av Colon 2324", "2235678342", 
                                        "mariolopez@gmail.com", "pediatra", "MP2345");
            Medico medico2 = new Medico(341, "Jorge", "Perez", "Av Independencia 3451",
                                        "2235671231", "jorgeperez@gmail.com", "Obstetra", "MN7654");
            Medico medico3 = new Medico(574, "Maria", "Gimenez", "San Luis 1239",
                                        "2235985482", "mariagimenez@hotmail.com", "pediatra", "MP7642");
            Medico medico4 = new Medico(984, "Estela", "Ramirez", "Cordoba 6542",
                                        "2234561765", "eramirez@outlook.com", "clinico", "MN8732");
            Medico medico5 = new Medico(872, "Griselda", "Vargas", "Las heras 2351", 
                                        "2235784265", "gvargas@gmail.com", "traumatologa", "MN5642");


            unaListaMedicos.Add(medico1);
            unaListaMedicos.Add(medico2);
            unaListaMedicos.Add(medico3);
            unaListaMedicos.Add(medico4);
            unaListaMedicos.Add(medico5);

            return unaListaMedicos;
        }
    }
}
