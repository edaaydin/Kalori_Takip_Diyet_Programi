using _03_Diyet.DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.Repositories
{
    public class TumProfilOgunKaloriRepository
    {
        private readonly DiyetDbContext db = new DiyetDbContext();

        public List<TumProfilOgunKaloriDto> TumProfilOgunKaloriGetir(DateTime başlangıçTarihi,DateTime bitişTarihi)
        {
            return db.KaloriVeriTakip
                .Join(db.Profiller, k => k.ProfilId, p => p.ProfilId, (k, p) => new { k, p })
                .Join(db.Öğünler, kp => kp.k.ÖğünId, o => o.ÖğünId, (kp, o) => new { kp, o })
                .Where(kpo => kpo.kp.k.OluşturulmaTarihi >= bitişTarihi && kpo.kp.k.OluşturulmaTarihi <= başlangıçTarihi)
                .GroupBy(kpo => new { kpo.kp.p.Ad, kpo.o.İsmi })
                .Select(kpo => new TumProfilOgunKaloriDto
                {
                    Profil = kpo.Key.Ad,
                    Öğün = kpo.Key.İsmi,
                    ToplamKalori = kpo.Sum(kpo => kpo.kp.k.Kalori)
                }).OrderBy(x => x.Profil)
                .ToList();

        }

    }
}
