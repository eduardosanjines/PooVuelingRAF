using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Banco
    {

        public bool TieneSuficientesAhorros(Cliente c, int amount){

            Console.WriteLine("Comprobando a: " + c.Name);
            return true;
        }
        



    }
}
