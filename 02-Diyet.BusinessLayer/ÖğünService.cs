using _03_Diyet.DataAccessLayer.Repositories;
using _04_Diyet.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Diyet.BusinessLayer
{
    public class ÖğünService
    {
        private readonly ÖğünRepository öğünRepo = new ÖğünRepository();
        public Öğün İsmeGöreGetir(string öğünİsmi)
        {
            return öğünRepo.İsmeGöreGetir(öğünİsmi);
        }
    }
}
