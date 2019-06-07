using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SIS_GOL.Application
{
  public  interface IAirplaneApplication
    {
        Task Create(AirplaneViewModel entity);
        Task Update(AirplaneViewModel entity);
        Task Delete(long id);

        Task<IEnumerable<AirplaneViewModel>> FindAll();
        Task<AirplaneViewModel> FindOne(long id);
    }
}
