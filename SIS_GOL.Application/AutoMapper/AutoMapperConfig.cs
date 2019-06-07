using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_GOL.Application
{
   public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(r =>
            {
                r.AddProfile<DomainToViewModelMappingProfile>();
                r.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}
