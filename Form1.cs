using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btnTodosDG_Click(object sender, EventArgs e)
        {
            var resultados = objAlumno.MostrarTodosDGV();
            dgAlumnos.DataSource = resultados;
        }

        private void btnTodosTxtBox_Click(object sender, EventArgs e)
        {
            string resultados = objAlumno.MostrarTodosTxtBox();
            txtDatos.Text = resultados;
        }
    }
}
