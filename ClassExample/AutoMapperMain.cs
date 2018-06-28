using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class AutoMapperMain
    {
        public static void Main() {
            Mapper.Initialize(cfg => cfg.CreateMap<AutorModel, AutorDTO>());

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AutorModel, AutorDTO>();

            });

            IMapper iMapper = config.CreateMapper();

            var source = new AutorModel { Id = 1234, Nombre = "Fran", Apellido = "Perez" };

            var destination = iMapper.Map<AutorModel, AutorDTO>(source);

            Console.WriteLine(destination.GetType());
        }
    }
}
