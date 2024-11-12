using _03_Diyet.DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.Repositories
{
    public class ÖğünKaloriRepository
    {
        private readonly DiyetDbContext db = new DiyetDbContext();

        public List<ÖğünKaloriDto> ÖğünlereTablodaKaloriToplamlarınaGöreGöster(int ıd)
        {
            return db.KaloriVeriTakip.Where(x => x.ProfilId == ıd).Join(db.Öğünler, k => k.ÖğünId, ö => ö.ÖğünId, (k, ö) => new { k, ö }).GroupBy(kö => kö.ö.İsmi).Select(kö => new ÖğünKaloriDto { İsim = kö.Key, ToplamKalori = kö.Sum(kö => kö.k.Kalori) }).ToList();
        }
    }
}
