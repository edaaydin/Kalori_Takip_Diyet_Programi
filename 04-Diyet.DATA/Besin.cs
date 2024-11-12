using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Diyet.DATA
{
    public class Besin
    {
        public int BesinId { get; set; }
        public string İsmi { get; set; }
        public double KaloriMiktarı { get; set; }
        public string Resim { get; set; }
        
        //Navigation Property
        public int KategoriId { get; set; }
        public BesinKategori Kategori { get; set; }

        public List<KaloriVeri> KaloriVerileri { get; set; }

    }
}
