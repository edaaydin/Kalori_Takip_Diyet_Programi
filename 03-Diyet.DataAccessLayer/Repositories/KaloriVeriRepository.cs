using _03_Diyet.DataAccessLayer.DTO;
using _04_Diyet.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.Repositories
{
    public class KaloriVeriRepository
    {
        private readonly DiyetDbContext db = new DiyetDbContext();
        private readonly ÖğünRepository ogunRepo = new ÖğünRepository();
        private readonly BesinRepository besinRepo = new BesinRepository();
        public void KaloriVeriEkleme(string ogunIsmi, int profilId, string besinIsmi, int porsiyon)
        {
            Öğün ogun = ogunRepo.İsmeGöreGetir(ogunIsmi);

            Besin besin = besinRepo.İsmeGöreGetir(besinIsmi);

            KaloriVeri kaloriVeri = new KaloriVeri()
            {
                OluşturulmaTarihi = DateTime.Today,
                ProfilId = profilId,
                ÖğünId = ogun.ÖğünId,
                BesinId = besin.BesinId,
                Kalori = (int)(besin.KaloriMiktarı * (double)porsiyon)

            };
            db.KaloriVeriTakip.Add(kaloriVeri);
            db.SaveChanges();
        }
        public void KaloriVeriSilme(int id)
        {
            KaloriVeri kaloriVeri = db.KaloriVeriTakip.FirstOrDefault(k => k.KaloriVeriId == id);
            db.KaloriVeriTakip.Remove(kaloriVeri);
            db.SaveChanges();
        }
        public void KaloriVeriGüncelleme(int id, string ogunIsmi, string besinIsmi, int porsiyon)
        {
            Öğün ogun = ogunRepo.İsmeGöreGetir(ogunIsmi);

            Besin besin = besinRepo.İsmeGöreGetir(besinIsmi);

            KaloriVeri kalori = db.KaloriVeriTakip.FirstOrDefault(k => k.KaloriVeriId == id);
            kalori.BesinId = besin.BesinId;
            kalori.ÖğünId = ogun.ÖğünId;
            kalori.Kalori = (int)(besin.KaloriMiktarı * (double)porsiyon);
            db.SaveChanges();
        }
      
        public int ToplamKalori(int profilId)
        {
            return db.KaloriVeriTakip.Where(x => x.OluşturulmaTarihi == DateTime.Today && x.ProfilId == profilId).Sum(x => x.Kalori);
        }
        public int ÖgünlereGöreToplam(string ogunIsmi, int profilId)
        {
            Öğün ogun = ogunRepo.İsmeGöreGetir(ogunIsmi);

            return db.KaloriVeriTakip.Where(x => x.OluşturulmaTarihi == DateTime.Today && x.ProfilId == profilId && x.ÖğünId == ogun.ÖğünId).Sum(x => x.Kalori);
        }
    }
}
