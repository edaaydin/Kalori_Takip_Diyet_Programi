using _03_Diyet.DataAccessLayer.Repositories;
using _04_Diyet.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Diyet.BusinessLayer
{
    public class BesinService
    {
        private readonly BesinRepository besinRepo = new BesinRepository();

        public Besin İsmeGöreGetir(string besinİsmi)
        {
            return besinRepo.İsmeGöreGetir(besinİsmi);
        }
        public List<Besin> TümBesinleriGetir()
        {
            return besinRepo.TümBesinleriGetir();
        }
    }
}
