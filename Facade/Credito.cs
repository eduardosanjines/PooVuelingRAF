using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Credito
    {
        public bool TieneBuenCretido(Cliente c)
        {
            Console.WriteLine("Comprobar credido para: " + c.Name);
            return true;
        }



    }
}
