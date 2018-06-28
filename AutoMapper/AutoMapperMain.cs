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

            // Mapper.Initialize(cfg => cfg.CreateMap<AutorA, AutorB>());
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AutorA, AutorB>());

            IMapper iMapper = config.CreateMapper();

            var origen = new AutorA { Id = 1234, Nombre = "Fran", Apellido = "Perez"};

            var destino = iMapper.Map<AutorA, AutorB>(origen);

            Console.WriteLine(destino.GetType());
            Console.WriteLine("Nombre de autor: "+destino.Nombre+" "+destino.Apellido);
            Console.ReadLine();

        }
    }
}
