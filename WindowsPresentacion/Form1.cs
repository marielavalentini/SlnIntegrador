using Entidades;
using Entidades.Clase_derivada;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        List<Medico> listaMedicos;
        List<Paciente> listaPacientes;
        List<Habitacion> listaHabitaciones;

        public Form1()
        {
            InitializeComponent();
        }
        //Mostrar la lista de médicos y pacientes en controles DataGridView

        private void btnMostrarMedicos_Click(object sender, EventArgs e)
        {
            listaMedicos = new List<Medico>();
            AdmMedico admMedico = new AdmMedico();
            listaMedicos = admMedico.Listar();

            listaPacientes = new List<Paciente>();
            AdmPaciente admPaciente = new AdmPaciente();
            listaPacientes = admPaciente.Listar();

            GridMedicos.DataSource = listaMedicos;
            GridPacientes.DataSource = listaPacientes;

            foreach (Medico medico in listaMedicos)
            {
                listMedicos.Items.Add("Nombre: " + medico.Nombre + "\nApellido: " + medico.Apellido + "\nEspecialidad: " + medico.Especialidad);
            }

            foreach (Paciente paciente in listaPacientes)
            {
                lstPacientes.Items.Add("Nombre: " + paciente.Nombre + " Apellido: " + paciente.Apellido);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Contar los médicos que son clínicos y mostrar sus nombre en un listBox

        private void btnClinicos_Click(object sender, EventArgs e)
        {
            listaMedicos = new List<Medico>();
            AdmMedico admMedico = new AdmMedico();
            listaMedicos = admMedico.Listar("clinico");

          

            foreach (Medico medico in listaMedicos)
            {
                lstClinicos.Items.Add("Nombre: " + medico.Nombre + "" + "Apellido: " + medico.Apellido + "Especialidad: " + medico.Especialidad);
            }
        }

        private void btnMostrarHabitaciones_Click(object sender, EventArgs e)
        {
            listaHabitaciones = new List<Habitacion>();
            AdmHabitacion admHabitacion = new AdmHabitacion();
            listaHabitaciones = admHabitacion.Listar();

            foreach (Habitacion habitacion in listaHabitaciones)
            {
                lstMostrarListaHabitaciones.Items.Add("Numero de habitacion: " + "" + habitacion.Numero + "" + "Estado: " + "" + habitacion.Estado);
            }
        }

        //Mostrar una lista con el número y estado de las habitaciones en un listBox 

    }
}
