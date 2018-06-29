using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Hipoteca
    {
        private Banco banco = new Banco();
        private Prestamo prestamo = new Prestamo();
        private Credito credito = new Credito();

        public bool IsEligible(Cliente cliente, int monto)
        {
            Console.WriteLine("{0} necesita {1:C} de prestamo\n",
              cliente.Name, monto);

            bool eligible = true;

            // Check creditworthyness of applicant

            if (!banco.TieneSuficientesAhorros(cliente, monto))
            {
                eligible = false;
            }
            else if (!prestamo.NoTieneMalosPrestamos(cliente))
            {
                eligible = false;
            }
            else if (!credito.TieneBuenCretido(cliente))
            {
                eligible = false;
            }

            return eligible;
        }


    }
}
