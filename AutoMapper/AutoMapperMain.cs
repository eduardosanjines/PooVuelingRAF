using ClassExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper
{
    class AutoMapperMain
    {
        static void Main(string[] args)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AutorA, AutorB>());
            

            IMapper iMapper = config.CreateMapper();

            var origen = new AutorA { Id = 1234, Nombre = "Fran", Apellido = "Perez"};
            var destino = iMapper.Map<AutorA, AutorB>(origen);

            Console.WriteLine(destino.GetType());
            Console.WriteLine("\n---Origen--- "+"\nNombre de autor: "+origen.Nombre+"\nApellido: "+origen.Apellido);
            Console.WriteLine("\n---Destino--- "+"\nNombre de autor: " + destino.Nombre + "\nApellido: " + destino.Apellido);
            Console.ReadLine();

        }
    }
}
