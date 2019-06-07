using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SIS_GOL.Domain
{
   public interface IRecording<TEntidade> where TEntidade : class
    {
        Task Create(TEntidade entity);
        Task Update(TEntidade entity);

        Task Delete(long id);
    }
}
