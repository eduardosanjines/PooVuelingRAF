using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class AutoMapper
    {
       
        public AutoMapper()
        {

            Mapper.Initialize(cfg => cfg.CreateMap<AutorModel, AutorDTO>());

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AutorModel, AutorDTO>();
             
            });

            IMapper iMapper = config.CreateMapper();

            var source = new AutorModel();

            var destination = iMapper.Map<AutorModel, AutorDTO>(source);

 

        }

        

    }
      
        

  

   
}
