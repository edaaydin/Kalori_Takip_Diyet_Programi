using _03_Diyet.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _01_Diyet.UI
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private readonly ProfilRepository profilRepository = new ProfilRepository();
       

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void chkSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreyiGoster.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            UyeOl uyeOl = new UyeOl();
            uyeOl.Show();
            this.Hide();

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Kullanıcı Email kısmı boş geçilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Kullanıcı Şifre kısmı boş geçilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (profilRepository.EmailSifrekontrol(txtEmail.Text, txtPassword.Text))
            {
                ProfilId.Id = profilRepository.EmailProfilBulma(txtEmail.Text).ProfilId;

                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Böyle bir Profil kayıtlı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
