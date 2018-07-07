using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Alumno
    {
     
        public string IdAlumno { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }

        public Alumno() { }

        public Alumno(string IdAlumno, string Nombre, string Apellido, string Dni) {
            this.IdAlumno = IdAlumno;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Dni = Dni;
        }

        public string GetAlumnName()
        {
            return this.Nombre;
        }

    }
}
