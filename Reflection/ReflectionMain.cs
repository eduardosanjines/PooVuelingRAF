using Newtonsoft.Json;
using Reflection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;


namespace Reflection
{
    class ReflectionMain
    {
        static void Main(string[] args)
        {

            XPathDocument doc_xml = new XPathDocument("ReflectionConfiguration.xml");
            XPathNavigator navegador = doc_xml.CreateNavigator();
            XPathNavigator textNodos = navegador.SelectSingleNode("/Types/Type[@Id='Alumno']");

            Assembly asm = typeof(ReflectionMain).Assembly;

            Type constructor = asm.GetType(navegador.ToString());

            Alumno instance = Activator.CreateInstance<Alumno>();

            Object alumno = Activator.CreateInstance(constructor, "1234", "Ferran", "Vallalta", "345678C");

            Alumno objetoAlumno = (Alumno)alumno;
            Console.WriteLine("Objeto: "+objetoAlumno.GetType(), objetoAlumno.IdAlumno);

            /*
            //XML OPCION 2 LINQ
            XElement root = XElement.Load("ReflectionConfiguration.xml");
            IEnumerable<XElement> tests =
            from el in root.Elements()
            where (string)el.Element("Id") == "34534"
            select el;
            string cadena = tests.First().Value;
            Console.WriteLine(cadena);
            */
        }
    }
            }
