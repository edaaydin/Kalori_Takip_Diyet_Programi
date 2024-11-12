using _04_Diyet.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.Repositories
{
    public class ÖğünRepository
    {
        private readonly DiyetDbContext db = new DiyetDbContext();
        public Öğün İsmeGöreGetir(string öğünİsmi)
        {
            return db.Öğünler.FirstOrDefault(o => o.İsmi == öğünİsmi);
        }
    }
}
