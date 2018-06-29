using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Prestamo
    {

        public bool NoTieneMalosPrestamos(Cliente c)
        {
            Console.WriteLine("Comprobar prestamos: " + c.Name);
            return true;
        }


    }
}
