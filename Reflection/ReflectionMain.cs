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
          //  try
         //  {
                Assembly asm = typeof(ReflectionMain).Assembly;
                XmlDocument doc = new XmlDocument();
                doc.Load("ReflectionConfiguration.xml");
                XmlNodeList nodo = doc.GetElementsByTagName("Types");
                String ns = nodo[0].InnerText;

                //XML OPCION 2 LINQ
                XElement root = XElement.Load("ReflectionConfiguration.xml");
            IEnumerable<XElement> tests =
            from el in root.Elements()
            where (string)el.Element("Id") == "34534"
            select el;
            string cadena = tests.First().Value;
            Console.WriteLine(cadena);

                Assembly myAssembly = typeof(ReflectionMain).Assembly;

                Type alumnoType = myAssembly.GetType(ns);

                object alumno = Activator.CreateInstance(alumnoType, 234, "Eduardo", "Fernandez");

                Alumno myAlumno = (Alumno)alumno;
                Console.WriteLine("Tipo de alumno: " + myAlumno.GetType() +
                                "\nIdAlumno: " + myAlumno.IdAlumno +
                                "\nNombre: " + myAlumno.Nombre +
                                "\nApellido: " + myAlumno.Apellido);

            // Console.WriteLine(((Alumno)obj).);

            //  Type alumnoType = myAssembly.GetType("XML");

            // object objetoAlumno = Activator.CreateInstance(alumnoType, 1, "Pepe", "Soto", "123456E");

            //   Console.WriteLine(((Alumno)objetoAlumno).Nombre);

            /*
                    }
                    catch (XPathException pa)
                    {

                        Console.WriteLine(pa);
                    }
                    catch (XmlException xml) {
                        Console.WriteLine(xml);
                    }
             */
        }
    }
            }
