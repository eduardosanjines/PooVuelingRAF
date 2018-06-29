using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Cliente
    {
        private string name;

        public Cliente(string name)
        {
            this.name = name;
        }

        public string Name
        {
           get { return name; }

        }
    }
}
