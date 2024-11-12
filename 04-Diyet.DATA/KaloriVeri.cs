using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Diyet.DATA
{
    public class KaloriVeri
    {
        public int KaloriVeriId { get; set; }
        public int Kalori { get; set; }
        public DateTime OluşturulmaTarihi { get; set; }

        //Navigation Property
        public int BesinId { get; set; }
        public Besin Besin { get; set; }

        public int ÖğünId { get; set; }
        public Öğün Öğün { get; set; }
        public int ProfilId { get; set; }
        public Profil Profil { get; set; }

    }
}
