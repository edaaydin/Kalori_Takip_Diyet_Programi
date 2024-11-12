using _02_Diyet.BusinessLayer;
using _03_Diyet.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Diyet.UI
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }
        private readonly GünlükKaloriService günlükKaloriService = new GünlükKaloriService();
        private readonly EnÇokYenenYemekService enÇokYenenYemekService = new EnÇokYenenYemekService();
        private readonly BesinÖğünSayısıService besinÖğünSayısıService = new BesinÖğünSayısıService();
        private readonly ÖğünKaloriService öğünKaloriService = new ÖğünKaloriService();
        private readonly ProfilBesinKategoriAdetService profilBesinKategoriAdetService = new ProfilBesinKategoriAdetService();
        private readonly KaloriVeriRepository kaloriVeriRepository = new KaloriVeriRepository();
        private readonly TumProfilOgunKaloriRepository tumProfilOgunKaloriRepository = new TumProfilOgunKaloriRepository();
        private void Raporlar_Load(object sender, EventArgs e)
        {
            dgvGünlükVeri.DataSource = günlükKaloriService.GünlükVeriler(ProfilId.Id, dateTimePicker1.Value);
            dgvGünlükVeri.Columns["KaloriId"].Visible = false;

            dgvEnYemek.DataSource = enÇokYenenYemekService.EnÇokYenenYemekler(ProfilId.Id);

            dgvEnYemekÖğün.DataSource = besinÖğünSayısıService.EnÇokYenenYemeklerÖğünlereGöre(ProfilId.Id);

            dgvÖğünKalori.DataSource = öğünKaloriService.ÖğünlereTablodaKaloriToplamlarınaGöreGöster(ProfilId.Id);

            dgvKıyas.DataSource = profilBesinKategoriAdetService.BesinKategoriAdetlerineGöreKıyas();


            lblKalori.Text = "Günlük Tükettiğiniz Toplam Kalori Miktarı " + kaloriVeriRepository.ToplamKalori(ProfilId.Id).ToString();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            dgvGünlükVeri.DataSource = günlükKaloriService.GünlükVeriler(ProfilId.Id, dateTimePicker1.Value);
            dgvGünlükVeri.Columns["KaloriId"].Visible = false;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void btnTumKisilerOgun_Click(object sender, EventArgs e)
        {
            dgvKıyas.DataSource = tumProfilOgunKaloriRepository.TumProfilOgunKaloriGetir(DateTime.Now, DateTime.Now.AddDays(-7));
        }

        

        private void btnTumKisilerKategori_Click_1(object sender, EventArgs e)
        {
            dgvKıyas.DataSource = profilBesinKategoriAdetService.BesinKategoriAdetlerineGöreKıyas();
        }
    }
}
