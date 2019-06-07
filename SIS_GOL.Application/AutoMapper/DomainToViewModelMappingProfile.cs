using AutoMapper;
using SIS_GOL.Domain;

namespace SIS_GOL.Application
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected override void Configure()
        {
            CreateMap<Airplane, AirplaneViewModel>();
        }
    }
}
