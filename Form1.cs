using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_TO_SQL
{
    public partial class Form1 : Form
    {
        Alumno objAlumno = new Alumno();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTodosDGV_Click(object sender, EventArgs e)
        {
            var resultados = objAlumno.MostrarTodosDGV();
            dgvAlumnos.DataSource = resultados;
        }

        private void btnTodosTB_Click(object sender, EventArgs e)
        {
            string resultados = objAlumno.MostrarTodosTB();
            txtDatos.Text = resultados;
        }

        private void btnMayoresTB_Click(object sender, EventArgs e)
        {
            string resultados = objAlumno.MostrarMayoresTB();
            txtDatos.Text = resultados;
        }

        private void btnMayoresDGV_Click(object sender, EventArgs e)
        {
            var resultados = objAlumno.MostrarMayoresDGV();
            dgvAlumnos.DataSource = resultados;
        }

        private void btnBuscarTB_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarTB.Text;

            string buscar = objAlumno.BuscarTB(nombre);
            txtDatos.Text = buscar;
        }

        private void btnBuscarDGV_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarDGV.Text;

            var buscar = objAlumno.BuscarDGV(nombre);
            dgvAlumnos.DataSource = buscar;
        }
    }
}
