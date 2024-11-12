using _03_Diyet.DataAccessLayer.Repositories;
using _04_Diyet.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Diyet.BusinessLayer
{
    public class ProfilService
    {
        private readonly ProfilRepository profilRepo = new ProfilRepository();

        public bool EmailKontrol(string kullanıcıEposta)
        {
            return profilRepo.EmailKontrol(kullanıcıEposta);
        }
        public bool EmailSifrekontrol(string kullanıcıEposta, string sifre)
        {
            return profilRepo.EmailSifrekontrol(kullanıcıEposta, sifre);

        }
        public void KullanıcıProfiliOluşturma(string kullanıcıEposta, string sifre, string ad, string soyad, DateTime dogumTarihi, string cinsiyet, int boy, int kilo, DateTime profilTarih)
        {
            profilRepo.KullanıcıProfiliOluşturma(kullanıcıEposta, sifre, ad, soyad, dogumTarihi, cinsiyet, boy, kilo, profilTarih);
        }

        public Profil EmailProfilBulma(string email)
        {
            return profilRepo.EmailProfilBulma(email);
        }

        public int TavsiyeEdilenKaloriMiktarı(int Id)
        {
            return profilRepo.TavsiyeEdilenKaloriMiktarı(Id);
        }
        public Profil IdProfilBulma(int ıd)
        {
            return profilRepo.IdProfilBulma(ıd);
        }
        public void ProfilSilme(int ıd)
        {
             profilRepo.ProfilSilme(ıd);
        }

        public void ProfilGüncelleme(int ıd, string kullanıcıEposta, string sifre, string ad, string soyad, DateTime dogumTarihi, string cinsiyet, int boy, int kilo)
        {
            profilRepo.ProfilGüncelleme(ıd, kullanıcıEposta, sifre, ad, soyad, dogumTarihi, cinsiyet, boy, kilo);
        }
    }
}
