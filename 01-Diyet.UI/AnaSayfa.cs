using _02_Diyet.BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _01_Diyet.UI
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        private readonly ProfilService profilService = new ProfilService();
        private readonly BesinService besinService = new BesinService();
        private readonly KaloriVeriService kaloriVeriService = new KaloriVeriService();
        private readonly GünlükKaloriService günlükKaloriService = new GünlükKaloriService();
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            int ıd = ProfilId.Id;

            string tavsiyeKalori = profilService.TavsiyeEdilenKaloriMiktarı(ıd).ToString();
            lblGunlukKalori.Text = "Tavsiye Edilen Kalori Miktarı : " + tavsiyeKalori + " Kcal";

            cmbOgun.Items.Add("Kahvaltı");
            cmbOgun.Items.Add("Öğle Yemeği");
            cmbOgun.Items.Add("Akşam Yemeği");
            cmbOgun.Items.Add("Aperatifler");


            cmbYemek.Items.AddRange(besinService.TümBesinleriGetir().Select(item => item.İsmi).OrderBy(isim => isim).ToArray());

            TabloyuDoldur();

        }
        private void cmbBesin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYemek.SelectedIndex != -1)
            {
                string dosyaIsmi = besinService.İsmeGöreGetir(cmbYemek.SelectedItem.ToString()).Resim;

                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string dosyaYolu = Path.Combine(Path.GetFullPath(Path.Combine(projectDirectory, @"..\..\..\")), "Images", dosyaIsmi);
                try
                {
                    using (var resim = new Bitmap(dosyaYolu))
                    {
                        pictureBox1.Image?.Dispose();
                        pictureBox1.Image = new Bitmap(resim);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Invalid image: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }
              
        private int ıd;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var satır = dataGridView1.SelectedRows[0];
                ıd = Convert.ToInt32(satır.Cells[0].Value);
                if (cmbOgun.Items.Contains(satır.Cells[1].Value.ToString()))
                {
                    cmbOgun.SelectedItem = satır.Cells[1].Value.ToString();
                }
                if (cmbYemek.Items.Contains(satır.Cells[2].Value.ToString()))
                {
                    cmbYemek.SelectedItem = satır.Cells[2].Value.ToString();
                }

                numPorsiyon.Value = 1;
                numAdet.Value = 1;
            }
        }
      
        private void Temizle()
        {
            pictureBox1.Image = null;
            cmbOgun.SelectedIndex = -1;
            cmbYemek.SelectedIndex = -1;
            numPorsiyon.Value = 1;
            numAdet.Value = 1;
        }

        private void TabloyuDoldur()
        {
            dataGridView1.DataSource = günlükKaloriService.GünlükVeriler(ProfilId.Id, DateTime.Today);
            dataGridView1.Columns["KaloriId"].Visible = false;
        }


        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbYemek.SelectedIndex == -1)
            {
                MessageBox.Show("Besin Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbOgun.SelectedIndex == -1)
            {
                MessageBox.Show("Öğün Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numPorsiyon.Value == 0)
            {
                MessageBox.Show("Porsiyon Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numAdet.Value == 0)
            {
                MessageBox.Show("Adet Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int porsiyonMiktar = (int)(numPorsiyon.Value * numAdet.Value);

            kaloriVeriService.KaloriVeriEkleme(cmbOgun.SelectedItem.ToString(), ProfilId.Id, cmbYemek.SelectedItem.ToString(), porsiyonMiktar);

            TabloyuDoldur();
            Temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbYemek.SelectedIndex == -1)
            {
                MessageBox.Show("Besin Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbOgun.SelectedIndex == -1)
            {
                MessageBox.Show("Öğün Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int porsiyon = (int)(numPorsiyon.Value * numAdet.Value);

                kaloriVeriService.KaloriVeriGüncelleme(ıd, cmbOgun.SelectedItem.ToString(), cmbYemek.SelectedItem.ToString(), porsiyon);

                TabloyuDoldur();
                Temizle();

            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (cmbYemek.SelectedIndex == -1)
            {
                MessageBox.Show("Besin Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbOgun.SelectedIndex == -1)
            {
                MessageBox.Show("Öğün Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                kaloriVeriService.KaloriVeriSilme(ıd);
                TabloyuDoldur();
                Temizle();

            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
