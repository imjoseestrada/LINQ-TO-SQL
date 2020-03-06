using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TO_SQL
{
    class Alumno
    {
        conectorEscuelaDataContext bdEscuela = new conectorEscuelaDataContext();

        public IQueryable MostrarTodosDGV()
        {
            var Registros = from valor in bdEscuela.Estudiantes
                            select valor;
            return Registros;
        }

        public string MostrarTodosTxtBox()
        {
            string alumnos = "";
            var registros = from valor in bdEscuela.Estudiantes
                            select valor;

            foreach (var res in registros) { 
            alumnos = alumnos + res.Id + " " +
                     res.Nombre + " " +
                     res.Edad + "\r\n";
            
            }
            return alumnos;
        }
    }
}
