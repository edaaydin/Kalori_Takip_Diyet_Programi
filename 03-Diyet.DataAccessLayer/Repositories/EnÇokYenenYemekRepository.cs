using _03_Diyet.DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.Repositories
{
    public class EnÇokYenenYemekRepository
    {
        private readonly DiyetDbContext db = new DiyetDbContext();

        public List<EnÇokYenenYemekDto> EnÇokYenenYemekler(int ıd)
        {
            return db.KaloriVeriTakip.Where(k => k.ProfilId == ıd).Join(db.Besinler, k => k.BesinId, b => b.BesinId, (k, b) => new { k, b }).GroupBy(kb => kb.b.İsmi).Select(kb => new EnÇokYenenYemekDto { İsim = kb.Key, Adet = kb.Count() }).OrderByDescending(kb => kb.Adet).ToList();
        }
    }
}
