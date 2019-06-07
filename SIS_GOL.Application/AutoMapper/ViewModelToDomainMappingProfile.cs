using AutoMapper;
using SIS_GOL.Domain;

namespace SIS_GOL.Application
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }
        protected override void Configure()
        {
            CreateMap<AirplaneViewModel, Airplane>();
        }
    }
}
