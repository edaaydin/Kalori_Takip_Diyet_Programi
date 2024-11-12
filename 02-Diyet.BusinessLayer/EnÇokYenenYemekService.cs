using _03_Diyet.DataAccessLayer.DTO;
using _03_Diyet.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Diyet.BusinessLayer
{
    public class EnÇokYenenYemekService
    {
        private readonly EnÇokYenenYemekRepository enÇokYenenYemekDtoRepo = new EnÇokYenenYemekRepository();
        public List<EnÇokYenenYemekDto> EnÇokYenenYemekler(int ıd)
        {
            return enÇokYenenYemekDtoRepo.EnÇokYenenYemekler(ıd);
        }
    }
}
