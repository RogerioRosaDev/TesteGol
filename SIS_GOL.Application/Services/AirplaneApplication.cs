using AutoMapper;
using SIS_GOL.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SIS_GOL.Application
{
    public class AirplaneApplication : IAirplaneApplication
    {
        private readonly IAirplaneRepository _repo;
        public AirplaneApplication(IAirplaneRepository repo)
        {
            _repo =  repo;
        }
        public async Task Create(AirplaneViewModel entity)
        {
           await _repo.Create(Mapper.Map<AirplaneViewModel ,Airplane>(entity));
        }

        public async Task Delete(long id)
        {
            await _repo.Delete(id);
        }

        public async Task<IEnumerable<AirplaneViewModel>> FindAll()
        {

            return Mapper.Map<IEnumerable<Airplane>, IEnumerable<AirplaneViewModel>>( await _repo.FindAll());
             
        }

        public async Task<AirplaneViewModel> FindOne(long id)
        {
            return Mapper.Map<Airplane, AirplaneViewModel>(await _repo.FindOne(id));
        }

        public async Task Update(AirplaneViewModel entity)
        {
            await _repo.Update(Mapper.Map<AirplaneViewModel, Airplane>(entity));
        }
    }
}
