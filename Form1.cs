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
            objAlumno.MostrarTodosEnDGV(dgvAlumnos);
        }

        private void btnTodosTB_Click(object sender, EventArgs e)
        {
            objAlumno.MostrarTodosEnTB(txtAlumnos);
        }

        private void btnMayoresTB_Click(object sender, EventArgs e)
        {
            objAlumno.MostrarMayoresEnTB(txtAlumnos);
        }

        private void btnMayoresDGV_Click(object sender, EventArgs e)
        {
            objAlumno.MostrarMayoresEnDGV(dgvAlumnos);
        }

        private void btnBuscarTB_Click(object sender, EventArgs e)
        {
            objAlumno.BuscarPorNombreTB(txtBuscarNombreTB, txtAlumnos);
        }

        private void btnBuscarDGV_Click(object sender, EventArgs e)
        {
            objAlumno.BuscarPorNombreDGV(txtBuscarNombreDGV, dgvAlumnos);
        }
    }
}
