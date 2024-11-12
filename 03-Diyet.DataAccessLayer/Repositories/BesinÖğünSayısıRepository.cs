using _03_Diyet.DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.Repositories
{
    public class BesinÖğünSayısıRepository
    {
        private readonly DiyetDbContext db = new DiyetDbContext();

        public List<BesinÖğünSayısıDto> EnÇokYenenYemeklerÖğünlereGöre(int id)
        {
            return db.KaloriVeriTakip
                .Where(k => k.ProfilId == id)
                .Join(db.Besinler, k => k.BesinId, b => b.BesinId, (k, b) => new { k, b })
                .Join(db.Öğünler, kb => kb.k.ÖğünId, ö => ö.ÖğünId, (kb, ö) => new { kb, ö })
                .GroupBy(kbö => new { Öğünİsmi = kbö.ö.İsmi, Besinİsmi = kbö.kb.b.İsmi })
                .Select(kbö => new { Öğünİsmi = kbö.Key.Öğünİsmi,Besinİsmi = kbö.Key.Besinİsmi,Sayısı = kbö.Count()})
                .GroupBy(kb => kb.Öğünİsmi)
                .Select(g => new{
                    Öğünİsmi = g.Key,
                    EnÇokEklenenBesin = g.OrderByDescending(x => x.Sayısı).FirstOrDefault()
                }).ToList()
                .Select(resultItem => new BesinÖğünSayısıDto{
                    Ogunİsmi = resultItem.Öğünİsmi,
                    Besinİsmi = resultItem.EnÇokEklenenBesin?.Besinİsmi,
                    Sayısı = resultItem.EnÇokEklenenBesin?.Sayısı ?? 0}
                ).ToList();
        }
    }
}
