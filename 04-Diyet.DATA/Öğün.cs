using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Diyet.DATA
{
    public class Öğün
    {
        public int ÖğünId { get; set; }
        public string İsmi { get; set; }

        //Navigation Property
        public List<KaloriVeri> KaloriVerileri { get; set; }

    }
}
