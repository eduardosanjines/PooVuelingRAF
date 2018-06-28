using Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class ReflectionMain
    {
        static void Main(string[] args)
        {

            Assembly myAssembly = typeof(ReflectionMain).Assembly;

            Type alumnoType = myAssembly.GetType("Reflection.Alumno");

            object objetoAlumno = Activator.CreateInstance(alumnoType, 1, "Pepe", "Soto", "123456E");

            Console.WriteLine(((Alumno)objetoAlumno).Nombre);

        }
    }
}
