namespace _01_Diyet.UI
{
    partial class Profil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            btnGuncelle = new Button();
            txtSoyad = new TextBox();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            txtAd = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            btnSil = new Button();
            dtpDt = new DateTimePicker();
            cmbCinsiyet = new ComboBox();
            nudKilo = new NumericUpDown();
            nudBoy = new NumericUpDown();
            btnAnasayfa = new Button();
            btnProfil = new Button();
            btnRaporlar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudKilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBoy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Firebrick;
            btnGuncelle.Font = new Font("Times New Roman", 10.2F);
            btnGuncelle.ForeColor = SystemColors.ButtonHighlight;
            btnGuncelle.Location = new Point(930, 304);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(142, 54);
            btnGuncelle.TabIndex = 21;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Times New Roman", 10.2F);
            txtSoyad.Location = new Point(620, 208);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(247, 23);
            txtSoyad.TabIndex = 16;
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Times New Roman", 10.2F);
            txtEposta.Location = new Point(1064, 156);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(248, 23);
            txtEposta.TabIndex = 14;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Times New Roman", 10.2F);
            txtSifre.Location = new Point(1064, 211);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(248, 23);
            txtSifre.TabIndex = 20;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Times New Roman", 10.2F);
            txtAd.Location = new Point(620, 156);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(247, 23);
            txtAd.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Firebrick;
            label4.Font = new Font("Times New Roman", 10.2F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(472, 272);
            label4.Name = "label4";
            label4.Size = new Size(92, 16);
            label4.TabIndex = 10;
            label4.Text = "Doğum Tarihi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Firebrick;
            label6.Font = new Font("Times New Roman", 10.2F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(472, 442);
            label6.Name = "label6";
            label6.Size = new Size(36, 16);
            label6.TabIndex = 9;
            label6.Text = "Boy :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Firebrick;
            label5.Font = new Font("Times New Roman", 10.2F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(472, 390);
            label5.Name = "label5";
            label5.Size = new Size(36, 16);
            label5.TabIndex = 8;
            label5.Text = "Kilo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Firebrick;
            label3.Font = new Font("Times New Roman", 10.2F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(472, 334);
            label3.Name = "label3";
            label3.Size = new Size(59, 16);
            label3.TabIndex = 7;
            label3.Text = "Cinsiyet :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Firebrick;
            label8.Font = new Font("Times New Roman", 10.2F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(913, 159);
            label8.Name = "label8";
            label8.Size = new Size(97, 16);
            label8.TabIndex = 6;
            label8.Text = "Kullanıcı Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Firebrick;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(472, 164);
            label2.Name = "label2";
            label2.Size = new Size(39, 16);
            label2.TabIndex = 4;
            label2.Text = "İsim :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Firebrick;
            label7.Font = new Font("Times New Roman", 10.2F);
            label7.ForeColor = SystemColors.InactiveBorder;
            label7.Location = new Point(913, 216);
            label7.Name = "label7";
            label7.Size = new Size(93, 16);
            label7.TabIndex = 11;
            label7.Text = "Kullanıcı Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(472, 211);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 3;
            label1.Text = "Soyisim :";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Firebrick;
            btnSil.Font = new Font("Times New Roman", 10.2F);
            btnSil.ForeColor = SystemColors.ControlLightLight;
            btnSil.Location = new Point(1119, 304);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(142, 54);
            btnSil.TabIndex = 22;
            btnSil.Text = "Profil Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // dtpDt
            // 
            dtpDt.Font = new Font("Times New Roman", 10.2F);
            dtpDt.Location = new Point(620, 272);
            dtpDt.Margin = new Padding(3, 4, 3, 4);
            dtpDt.Name = "dtpDt";
            dtpDt.Size = new Size(247, 23);
            dtpDt.TabIndex = 23;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.Font = new Font("Times New Roman", 10.2F);
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(619, 331);
            cmbCinsiyet.Margin = new Padding(3, 4, 3, 4);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(248, 24);
            cmbCinsiyet.TabIndex = 24;
            // 
            // nudKilo
            // 
            nudKilo.Font = new Font("Times New Roman", 10.2F);
            nudKilo.Location = new Point(618, 388);
            nudKilo.Margin = new Padding(3, 4, 3, 4);
            nudKilo.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudKilo.Name = "nudKilo";
            nudKilo.Size = new Size(249, 23);
            nudKilo.TabIndex = 0;
            // 
            // nudBoy
            // 
            nudBoy.Font = new Font("Times New Roman", 10.2F);
            nudBoy.Location = new Point(618, 440);
            nudBoy.Margin = new Padding(3, 4, 3, 4);
            nudBoy.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudBoy.Name = "nudBoy";
            nudBoy.Size = new Size(249, 23);
            nudBoy.TabIndex = 26;
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.BackColor = Color.Firebrick;
            btnAnasayfa.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAnasayfa.ForeColor = SystemColors.ControlLightLight;
            btnAnasayfa.Location = new Point(526, 30);
            btnAnasayfa.Margin = new Padding(3, 4, 3, 4);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.Size = new Size(160, 50);
            btnAnasayfa.TabIndex = 27;
            btnAnasayfa.Text = "ANASAYFA";
            btnAnasayfa.UseVisualStyleBackColor = false;
            btnAnasayfa.Click += btnAnasayfa_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Firebrick;
            btnProfil.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnProfil.ForeColor = SystemColors.ControlLightLight;
            btnProfil.Location = new Point(795, 30);
            btnProfil.Margin = new Padding(3, 4, 3, 4);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(160, 50);
            btnProfil.TabIndex = 28;
            btnProfil.Text = "PROFİL";
            btnProfil.UseVisualStyleBackColor = false;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.Firebrick;
            btnRaporlar.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnRaporlar.ForeColor = SystemColors.ControlLightLight;
            btnRaporlar.Location = new Point(1055, 30);
            btnRaporlar.Margin = new Padding(3, 4, 3, 4);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(160, 50);
            btnRaporlar.TabIndex = 29;
            btnRaporlar.Text = "RAPORLAR";
            btnRaporlar.UseVisualStyleBackColor = false;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pizza;
            pictureBox1.Location = new Point(0, 540);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1326, 631);
            Controls.Add(pictureBox1);
            Controls.Add(btnRaporlar);
            Controls.Add(btnProfil);
            Controls.Add(btnAnasayfa);
            Controls.Add(nudBoy);
            Controls.Add(nudKilo);
            Controls.Add(cmbCinsiyet);
            Controls.Add(dtpDt);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(txtSoyad);
            Controls.Add(txtEposta);
            Controls.Add(txtSifre);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "Profil";
            Text = "Profil";
            Load += Profil_Load;
            ((System.ComponentModel.ISupportInitialize)nudKilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBoy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private TextBox txtSoyad;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private TextBox txtAd;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label8;
        private Label label2;
        private Label label7;
        private Label label1;
        private Button btnSil;
        private DateTimePicker dtpDt;
        private ComboBox cmbCinsiyet;
        private NumericUpDown nudKilo;
        private NumericUpDown nudBoy;
        private Button btnAnasayfa;
        private Button btnProfil;
        private Button btnRaporlar;
        private PictureBox pictureBox1;
    }
}