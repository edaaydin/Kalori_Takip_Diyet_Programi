using _03_Diyet.DataAccessLayer.DTO;
using _03_Diyet.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Diyet.BusinessLayer
{
    public class GünlükKaloriService
    {
        private readonly GünlükKaloriRepository günlükKaloriRepository = new GünlükKaloriRepository();
        public List<GünlükKaloriDto> GünlükVeriler(int profilId,DateTime dateTime)
        {
            return günlükKaloriRepository.GünlükVeriler(profilId, dateTime);
        }
    }
}
