using _03_Diyet.DataAccessLayer.DTO;
using _04_Diyet.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.Repositories
{
    public class GünlükKaloriRepository
    {
        private readonly DiyetDbContext db = new DiyetDbContext();
        public List<GünlükKaloriDto> GünlükVeriler(int profilId,DateTime dateTime)
        {
            return db.KaloriVeriTakip.Where(x => x.OluşturulmaTarihi == dateTime && x.ProfilId == profilId).Join(db.Öğünler, k => k.ÖğünId, ö => ö.ÖğünId, (k, ö) => new { k, ö }).Join(db.Besinler, kö => kö.k.BesinId, b => b.BesinId, (kö, b) => new { kö, b }).Select(kbö => new GünlükKaloriDto { KaloriId = kbö.kö.k.KaloriVeriId, Öğün = kbö.kö.ö.İsmi, Besin = kbö.b.İsmi,Kalori = kbö.kö.k.Kalori }).ToList();
        }
    }
}
