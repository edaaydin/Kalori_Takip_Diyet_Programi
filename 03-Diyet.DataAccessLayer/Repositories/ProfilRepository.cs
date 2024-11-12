using _04_Diyet.DATA;
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.Repositories
{
    public class ProfilRepository
    {
        private readonly DiyetDbContext db = new DiyetDbContext();
        public bool EmailKontrol(string kullanıcıEposta)
        {
            return db.Profiller.Any(x => x.KullanıcıEposta == kullanıcıEposta );
        }
        public bool EmailSifrekontrol(string kullanıcıEposta,string sifre)
        {
            return db.Profiller.Any(x => x.KullanıcıEposta == kullanıcıEposta && x.Şifre == sifre);

        }
        public void KullanıcıProfiliOluşturma(string kullanıcıEposta, string sifre, string ad, string soyad, DateTime dogumTarihi, string cinsiyet, int boy, int kilo, DateTime profilTarih)
        {

            Profil profil = new Profil()
            {
                KullanıcıEposta = kullanıcıEposta,
                Şifre = sifre,
                Ad = ad,
                Soyad = soyad,
                DoğumTarihi = dogumTarihi,
                Cinsiyet = cinsiyet,
                Boy = boy,
                Kilo = kilo,
                ProfilOluşturmaTarihi = profilTarih
            };
            db.Profiller.Add(profil);
            db.SaveChanges();
        }

        public void ProfilGüncelleme(int ıd,string kullanıcıEposta, string sifre, string ad, string soyad, DateTime dogumTarihi, string cinsiyet, int boy, int kilo)
        {
            Profil profil = db.Profiller.FirstOrDefault(p => p.ProfilId == ıd);
            profil.KullanıcıEposta = kullanıcıEposta;
            profil.Şifre = sifre;
            profil.Ad = ad;
            profil.Soyad = soyad;
            profil.DoğumTarihi= dogumTarihi;
            profil.Cinsiyet = cinsiyet;
            profil.Boy = boy;
            profil.Kilo = kilo;
            db.SaveChanges();
        }

        public Profil EmailProfilBulma(string email)
        {
            return db.Profiller.FirstOrDefault(p => p.KullanıcıEposta == email);
        }

        public Profil IdProfilBulma(int ıd)
        {
            return db.Profiller.FirstOrDefault(p => p.ProfilId == ıd);
        }
        public int TavsiyeEdilenKaloriMiktarı(int Id)
        {
            Profil profil = db.Profiller.FirstOrDefault(p => p.ProfilId == Id); ;

            if(profil.Cinsiyet == "Erkek")
            {
                return 10 * profil.Kilo + (int)(6.25 * ((double)profil.Boy)) - 5 * (DateTime.Now.Year - profil.DoğumTarihi.Year) + 5;
            }
            else
            {
                return 10 * profil.Kilo + (int)(6.25 * ((double)profil.Boy)) - 5 * (DateTime.Now.Year - profil.DoğumTarihi.Year) - 161; 
            }
            
        }

        public void ProfilSilme(int ıd)
        { 
            db.Profiller.Remove(db.Profiller.FirstOrDefault(p => p.ProfilId == ıd));
            db.SaveChanges();
        }
    }
}
