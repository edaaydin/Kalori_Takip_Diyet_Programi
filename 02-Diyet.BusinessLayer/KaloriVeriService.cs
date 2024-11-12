using _03_Diyet.DataAccessLayer.Repositories;
using _04_Diyet.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Diyet.BusinessLayer
{
    public class KaloriVeriService
    {
        private readonly KaloriVeriRepository kaloriVeriRepo = new KaloriVeriRepository();

        public void KaloriVeriEkleme(string ogunIsmi, int profilId, string besinIsmi, int porsiyon)
        {
            kaloriVeriRepo.KaloriVeriEkleme(ogunIsmi, profilId, besinIsmi, porsiyon);
        }

        public void KaloriVeriSilme(int id)
        {
            kaloriVeriRepo.KaloriVeriSilme(id);
        }
        public void KaloriVeriGüncelleme(int id, string ogunIsmi, string besinIsmi, int porsiyon)
        {
            kaloriVeriRepo.KaloriVeriGüncelleme(id, ogunIsmi, besinIsmi, porsiyon);
        }
       
        public int ToplamKalori(int profilId)
        {
            return kaloriVeriRepo.ToplamKalori(profilId);
        }
        public int ÖgünlereGöreToplam(string ogunIsmi, int profilId)
        {
            return kaloriVeriRepo.ÖgünlereGöreToplam(ogunIsmi, profilId);
        }
    }
}
