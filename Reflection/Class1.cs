using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Class1
    {
        private int Documento;
        private String Dni;
        private String Apellido;



        DateTime dateTime = (DateTime)Activator.CreateInstance(typeof(DateTime));


    }
}
