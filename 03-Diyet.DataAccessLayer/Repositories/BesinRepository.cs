using _04_Diyet.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.Repositories
{
    public class BesinRepository
    {
        private readonly DiyetDbContext db = new DiyetDbContext();
        public Besin İsmeGöreGetir(string besinİsmi)
        {
            return db.Besinler.FirstOrDefault(b => b.İsmi == besinİsmi);
        }

        public List<Besin> TümBesinleriGetir()
        {
            return db.Besinler.ToList();
        }
    }
}
