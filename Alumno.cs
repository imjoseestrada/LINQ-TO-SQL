using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_TO_SQL
{
    class Alumno
    {
        conectorEscuelaDataContext bdEscuela = new conectorEscuelaDataContext();

        public void MostrarTodosEnDGV(DataGridView dgvAlumnos)
        {
            var registros = from valor in bdEscuela.Estudiantes
                            select valor;
            dgvAlumnos.DataSource = registros;
        }

        public void MostrarMayoresEnDGV(DataGridView dgvAlumnos)
        {
            var registros = from valor in bdEscuela.Estudiantes
                            where valor.Edad >= 18
                            select valor;
            if (registros.Any())
            {
                dgvAlumnos.DataSource = registros;
            }
            else
            {
                dgvAlumnos.DataSource = null;
                MessageBox.Show("Ninguno de tus estudiantes es mayor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BuscarPorNombreDGV(TextBox txtNombre, DataGridView dgvAlumnos)
        {
            if (txtNombre.Text != "")
            {
                var registros = from valor in bdEscuela.Estudiantes
                                where valor.Nombre.Contains(txtNombre.Text)
                                select valor;
                if (registros.Any())
                {
                    dgvAlumnos.DataSource = registros;
                } else
                {
                    dgvAlumnos.DataSource = null;
                    MessageBox.Show("Ninguno de tus estudiantes se llama: " + txtNombre.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Text = null;
                }
            }
            else
            {
                dgvAlumnos.DataSource = null;
                MessageBox.Show("No ingresaste ningún valor de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MostrarTodosEnTB(TextBox txtAlumnos)
        {
            txtAlumnos.Text = "";
            var registros = from valor in bdEscuela.Estudiantes
                            select valor;
            foreach (var alumno in registros) { 
            txtAlumnos.Text = txtAlumnos.Text +
                    alumno.Id + " " +
                    alumno.Nombre + " " +
                    alumno.Edad + Environment.NewLine;
            }
        }

        public void MostrarMayoresEnTB(TextBox txtAlumnos)
        {
            txtAlumnos.Text = "";
            var registros = from valor in bdEscuela.Estudiantes
                            where valor.Edad >= 18
                            select valor;
            if (registros.Any())
            {
                foreach (var alumno in registros)
                {
                    txtAlumnos.Text = txtAlumnos.Text +
                        alumno.Id + " " +
                        alumno.Nombre + " " +
                        alumno.Edad + Environment.NewLine;
                }
            }
            else
            {
                txtAlumnos.Text = null;
                MessageBox.Show("Ninguno de tus estudiantes es mayor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BuscarPorNombreTB(TextBox txtNombre, TextBox txtAlumnos)
        {
            txtAlumnos.Text = "";
            if (txtNombre.Text != "")
            {
                var registros = from valor in bdEscuela.Estudiantes
                                where valor.Nombre.Contains(txtNombre.Text)
                                select valor;
                if (registros.Any())
                {
                    foreach (var alumno in registros)
                    {
                        txtAlumnos.Text = txtAlumnos.Text +
                            alumno.Id + " " +
                            alumno.Nombre + " " +
                            alumno.Edad + Environment.NewLine;
                    }
                }
                else
                {
                    txtAlumnos.Text = "Ninguno de tus estudiantes se llama: " + txtNombre.Text;
                    txtNombre.Text = null;
                }
            }
            else
            {
                txtAlumnos.Text = "";
                MessageBox.Show("No ingresaste ningún valor de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
