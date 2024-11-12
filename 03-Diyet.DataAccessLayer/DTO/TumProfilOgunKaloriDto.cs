using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.DTO
{
    public class TumProfilOgunKaloriDto
    {
        public string Profil { get; set; }
        public string Öğün { get; set; }
        public int ToplamKalori { get; set; }
    }
}
