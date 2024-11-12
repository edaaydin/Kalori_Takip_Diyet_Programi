using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.DTO
{
    public class GünlükKaloriDto
    {
        public int KaloriId { get; set; }
        public string Öğün { get; set; }
        public string Besin { get; set; }
        public int Kalori { get; set; }
    }
}
