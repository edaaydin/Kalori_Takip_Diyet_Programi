using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Diyet.DATA
{
    public class Profil
    {
        public int ProfilId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DoğumTarihi { get; set; }

        public int Boy { get; set; }
        public int Kilo { get; set; }
        public string Cinsiyet { get; set; }
        public string KullanıcıEposta { get; set; }
        public string Şifre { get; set; }

        public DateTime ProfilOluşturmaTarihi { get; set; }

        //Navigation Property
        public List<KaloriVeri> KaloriVerileri { get; set; }


    }
}
