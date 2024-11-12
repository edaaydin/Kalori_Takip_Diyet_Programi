using _02_Diyet.BusinessLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _01_Diyet.UI
{
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");
            cmbCinsiyet.SelectedIndex = 0;

            txtSifre.PasswordChar = '*';

        }
        private readonly ProfilService profilService = new ProfilService();


        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            DateTime dogumTarihi = dtpDt.Value;
            string cinsiyet = cmbCinsiyet.SelectedItem.ToString();
            int kilo = Convert.ToInt32(nudKilo.Value);
            int boy = Convert.ToInt32(nudBoy.Value);

            string email = txtEposta.Text;
            string sifre = txtSifre.Text;

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
            if (dtpDt.Value > DateTime.Now.AddYears(-3))
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
            if (profilService.EmailKontrol(email))
            {
                MessageBox.Show("Böyle bir Email var.Başka bir Email giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!SifreGuvenligi(sifre))
            {
                MessageBox.Show("Daha güvenli bir şifre yazınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sifre != txtSifre2.Text)
            {
                MessageBox.Show("Girilen şifreler aynı değildir. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            profilService.KullanıcıProfiliOluşturma(email, sifre, ad, soyad, dogumTarihi, cinsiyet, boy, kilo, DateTime.Today);

            Giriş login = new Giriş();
            login.Show();
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

    }
}



