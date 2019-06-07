using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_GOL.Domain
{
   public interface IAirplaneRepository :IReading<Airplane>,IRecording<Airplane>
    {

    }
}
