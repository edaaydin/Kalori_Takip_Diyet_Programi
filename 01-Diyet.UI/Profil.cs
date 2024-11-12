using _02_Diyet.BusinessLayer;
using _03_Diyet.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Diyet.UI
{
    public partial class Profil : Form
    {
        ProfilRepository profilRepository = new ProfilRepository();
        public Profil()
        {
            InitializeComponent();
        }
        private  ProfilService profilService = new ProfilService();
        private void Profil_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");
            var profil = profilService.IdProfilBulma(ProfilId.Id);
            txtAd.Text = profil.Ad;
            txtSoyad.Text = profil.Soyad;
            dtpDt.Value = profil.DoğumTarihi;
            cmbCinsiyet.SelectedItem = profil.Cinsiyet;
            nudBoy.Value = profil.Boy;
            nudKilo.Value = profil.Kilo;
            txtEposta.Text = profil.KullanıcıEposta;
            txtSifre.Text = profil.Şifre;


        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        bool SifreGuvenligi(string sifre)
        {
            if (sifre.Length < 10)
                return false;

            if (!Regex.IsMatch(sifre, @"[A-Z]"))
                return false;

            if (!Regex.IsMatch(sifre, @"[a-z]"))
                return false;

            if (!Regex.IsMatch(sifre, @"[0-9]"))
                return false;

            return true;
        }


        bool EmailFormatKontrol(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[com]+$";
            bool kontrol = Regex.IsMatch(email, pattern);
            if (kontrol)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz? Bu işlem geri alınamaz.", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                profilRepository.ProfilSilme(ProfilId.Id);

                Giriş login = new Giriş();
                login.Show();
                this.Hide();
            }
            else
            {
                return;
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            profilService = new ProfilService();

            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            DateTime dogumTarihi = dtpDt.Value;
            string cinsiyet = cmbCinsiyet.SelectedItem.ToString();
            int kilo = Convert.ToInt32(nudKilo.Value);
            int boy = Convert.ToInt32(nudBoy.Value);

            string email = txtEposta.Text;
            string sifre = txtSifre.Text;

            if(ad == profilService.IdProfilBulma(ProfilId.Id).Ad && soyad == profilService.IdProfilBulma(ProfilId.Id).Soyad && dogumTarihi == profilService.IdProfilBulma(ProfilId.Id).DoğumTarihi && cinsiyet == profilService.IdProfilBulma(ProfilId.Id).Cinsiyet && kilo == profilService.IdProfilBulma(ProfilId.Id).Kilo && boy == profilService.IdProfilBulma(ProfilId.Id).Boy && email == profilService.IdProfilBulma(ProfilId.Id).KullanıcıEposta && sifre == profilService.IdProfilBulma(ProfilId.Id).Şifre)
            {
                MessageBox.Show("Güncellemek için lütfen bir değişiklik yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(ad))
            {
                MessageBox.Show("Ad kısmı boş geçilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ad.Any(char.IsDigit))
            {
                MessageBox.Show("Adın içinde rakam olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(soyad))
            {
                MessageBox.Show("Soyad alanı boş geçilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (soyad.Any(char.IsDigit))
            {
                MessageBox.Show("Soyadın içinde rakam olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpDt.Value == DateTime.Now)
            {
                MessageBox.Show("Geçerli bir Doğum Tarihi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nudBoy.Value == 0)
            {
                MessageBox.Show("Geçerli bir Boy Değeri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nudKilo.Value == 0)
            {
                MessageBox.Show("Geçerli bir Kilo Değeri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EmailFormatKontrol(email))
            {
                MessageBox.Show("Email formatına uygun giriniz.(example@example.com)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (email != profilService.IdProfilBulma(ProfilId.Id).KullanıcıEposta)
            {
                if (profilService.EmailKontrol(email))
                {
                    MessageBox.Show("Böyle bir Email var.Başka bir Email giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!SifreGuvenligi(sifre))
            {
                MessageBox.Show("Daha güvenli bir şifre yazınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            profilRepository.ProfilGüncelleme(ProfilId.Id, email, sifre, ad, soyad, dogumTarihi, cinsiyet, boy, kilo);
            MessageBox.Show("Profiliniz Başarıyla Güncellendi.");
            return;
        }
    }
}
