using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class FacadeClienteMain
    {
        static void Main(string[] args)
        {
            // Facade

            Hipoteca hipoteca = new Hipoteca();

            // Evaluate mortgage eligibility for customer

            Cliente cliente = new Cliente("Ann McKinsey");
            bool eligible = hipoteca.IsEligible(cliente, 125000);

            Console.WriteLine("\n" + cliente.Name +
                " Ha sido: " + (eligible ? "Aprobado" : "Rechazado"));

            // Wait for user

            Console.ReadKey();


        }
    }
}
