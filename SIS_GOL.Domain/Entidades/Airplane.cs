
using System;

namespace SIS_GOL.Domain
{
    public class Airplane
    {
        public long IdAviao { get; set; }
        public string CodigoAviao { get; set; }
        public string ModeloAviao { get; set; }
        public int QtdPassageiros { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
