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

        public IQueryable MostrarTodosDGV()
        {
            var registros = from valor in bdEscuela.Estudiantes
                            select valor;
            return registros;
        }

        public IQueryable MostrarMayoresDGV()
        {
            var registros = from valor in bdEscuela.Estudiantes
                            where valor.Edad >= 18
                            select valor;
            return registros;
        }

        public IQueryable BuscarDGV(string nombre)
        {
            if (nombre != "")
            {
                var registros = from valor in bdEscuela.Estudiantes
                                where valor.Nombre.Contains(nombre)
                                select valor;

                if (registros.Count() == 0)
                {
                    MessageBox.Show("No hay registros disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                return registros;
            } else
            {
                MessageBox.Show("No ingresaste ningún valor de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public string MostrarTodosTB()
        {
            string alumnos = "";
            var registros = from valor in bdEscuela.Estudiantes
                            select valor;

            foreach (var res in registros) { 
            alumnos = alumnos +
                    res.Id + " " +
                    res.Nombre + " " +
                    res.Edad + "\r\n";
            }
            return alumnos;
        }

        public string MostrarMayoresTB()
        {
            string alumnos = "";
            var registros = from valor in bdEscuela.Estudiantes
                            where valor.Edad >= 18
                            select valor;

            foreach (var res in registros)
            {
                alumnos = alumnos +
                    res.Id + " " +
                    res.Nombre + " " +
                    res.Edad + "\r\n";
            }
            return alumnos;
        }

        public string BuscarTB(string nombre)
        {
            if (nombre != "")
            {
                string alumnos = "";
                var registros = from valor in bdEscuela.Estudiantes
                                where valor.Nombre.Contains(nombre)
                                select valor;

                if (registros.Count() != 0)
                {
                    foreach (var res in registros)
                    {
                        alumnos = alumnos +
                            res.Id + " " +
                            res.Nombre + " " +
                            res.Edad + "\r\n";
                    }
                }
                else
                {
                    alumnos = "No hay registros disponibles";
                }
                return alumnos;
            }
            else
            {
                MessageBox.Show("No ingresaste ningún valor de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
