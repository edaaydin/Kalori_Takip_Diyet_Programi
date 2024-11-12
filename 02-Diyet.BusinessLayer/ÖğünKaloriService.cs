using _03_Diyet.DataAccessLayer.DTO;
using _03_Diyet.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Diyet.BusinessLayer
{
    public class ÖğünKaloriService
    {
        private readonly ÖğünKaloriRepository öğünKaloriDtoRepo = new ÖğünKaloriRepository();

        public List<ÖğünKaloriDto> ÖğünlereTablodaKaloriToplamlarınaGöreGöster(int ıd)
        {
            return öğünKaloriDtoRepo.ÖğünlereTablodaKaloriToplamlarınaGöreGöster(ıd);
        }
    }
}
