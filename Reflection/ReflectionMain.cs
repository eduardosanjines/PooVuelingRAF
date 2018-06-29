using Reflection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Reflection
{
    class ReflectionMain
    {
        static void Main(string[] args)
        {

            Assembly myAssembly = typeof(ReflectionMain).Assembly;
/*
            XmlTextReader reader = new XmlTextReader("Alumno.xml");

            while (reader.Read()) {
                Console.WriteLine(reader.Name);    

            }
            */
            Type alumnoType = myAssembly.GetType("Reflection.Alumno");

            object objetoAlumno = Activator.CreateInstance(alumnoType, 1, "Pepe", "Soto", "123456E");

            Console.WriteLine(((Alumno)objetoAlumno).Nombre);

            

        }
    }
}
