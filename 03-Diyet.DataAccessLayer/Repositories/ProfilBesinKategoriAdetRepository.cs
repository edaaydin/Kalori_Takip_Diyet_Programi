using _03_Diyet.DataAccessLayer.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.Repositories
{
    public class ProfilBesinKategoriAdetRepository
    {
        private readonly DiyetDbContext db = new DiyetDbContext();

        public List<ProfilBesinKategoriAdetDto> BesinKategoriAdetlerineGöreKıyas()
        {
            
            return db.KaloriVeriTakip
                .Join(db.Profiller, k => k.ProfilId, p => p.ProfilId, (k, p) => new { k, p })
                .Join(db.Besinler, kp => kp.k.BesinId, b => b.BesinId, (kp, b) => new { kp, b })
                .Join(db.BesinKategorileri, kpb => kpb.b.KategoriId, a => a.BesinKategoriId, (kpb, a) => new { kpb, a })
                .GroupBy(kpba => new { Ad = kpba.kpb.kp.p.Ad, BesinKategori = kpba.a.İsmi }).Select(kpba => new ProfilBesinKategoriAdetDto { İsim = kpba.Key.Ad, BesinKategori = kpba.Key.BesinKategori, Adet = kpba.Count() }).ToList();
        }
    }
}
