namespace _01_Diyet.UI
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btnRaporlar = new Button();
            btnProfil = new Button();
            lblGunlukKalori = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbOgun = new ComboBox();
            numPorsiyon = new NumericUpDown();
            label4 = new Label();
            numAdet = new NumericUpDown();
            cmbYemek = new ComboBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPorsiyon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Firebrick;
            btnEkle.ForeColor = SystemColors.ControlLightLight;
            btnEkle.Location = new Point(501, 315);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(154, 59);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "ÖĞÜN EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Firebrick;
            btnGuncelle.ForeColor = SystemColors.ControlLightLight;
            btnGuncelle.Location = new Point(299, 273);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(154, 59);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "ÖĞÜN GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Firebrick;
            btnSil.ForeColor = SystemColors.ControlLightLight;
            btnSil.Location = new Point(299, 363);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(154, 59);
            btnSil.TabIndex = 0;
            btnSil.Text = "ÖĞÜN SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.WindowFrame;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(818, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(414, 564);
            dataGridView1.TabIndex = 1;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(33, 25);
            button1.Name = "button1";
            button1.Size = new Size(135, 60);
            button1.TabIndex = 2;
            button1.Text = "ANASAYFA";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.Firebrick;
            btnRaporlar.ForeColor = SystemColors.ControlLightLight;
            btnRaporlar.Location = new Point(405, 25);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(135, 60);
            btnRaporlar.TabIndex = 2;
            btnRaporlar.Text = "RAPORLAR";
            btnRaporlar.UseVisualStyleBackColor = false;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Firebrick;
            btnProfil.ForeColor = SystemColors.ControlLightLight;
            btnProfil.Location = new Point(220, 25);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(135, 60);
            btnProfil.TabIndex = 2;
            btnProfil.Text = "PROFİL";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // lblGunlukKalori
            // 
            lblGunlukKalori.AutoSize = true;
            lblGunlukKalori.BackColor = Color.Firebrick;
            lblGunlukKalori.ForeColor = SystemColors.ControlLightLight;
            lblGunlukKalori.Location = new Point(299, 223);
            lblGunlukKalori.Name = "lblGunlukKalori";
            lblGunlukKalori.Size = new Size(177, 16);
            lblGunlukKalori.TabIndex = 3;
            lblGunlukKalori.Text = "Günlük Tavsiye Edilen Kalori :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Firebrick;
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 44);
            label2.Name = "label2";
            label2.Size = new Size(45, 16);
            label2.TabIndex = 4;
            label2.Text = "Öğün :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Firebrick;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(330, 44);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 4;
            label3.Text = "Porsiyon/(gr) :";
            // 
            // cmbOgun
            // 
            cmbOgun.FormattingEnabled = true;
            cmbOgun.Location = new Point(101, 40);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(161, 24);
            cmbOgun.TabIndex = 5;
            // 
            // numPorsiyon
            // 
            numPorsiyon.Location = new Point(476, 37);
            numPorsiyon.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPorsiyon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPorsiyon.Name = "numPorsiyon";
            numPorsiyon.Size = new Size(150, 23);
            numPorsiyon.TabIndex = 6;
            numPorsiyon.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Firebrick;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(330, 140);
            label4.Name = "label4";
            label4.Size = new Size(40, 16);
            label4.TabIndex = 4;
            label4.Text = "Adet :";
            // 
            // numAdet
            // 
            numAdet.Location = new Point(476, 140);
            numAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAdet.Name = "numAdet";
            numAdet.Size = new Size(150, 23);
            numAdet.TabIndex = 6;
            numAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbYemek
            // 
            cmbYemek.FormattingEnabled = true;
            cmbYemek.Location = new Point(101, 140);
            cmbYemek.Name = "cmbYemek";
            cmbYemek.Size = new Size(159, 24);
            cmbYemek.TabIndex = 7;
            cmbYemek.SelectedIndexChanged += cmbBesin_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(18, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 199);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Firebrick;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(18, 144);
            label5.Name = "label5";
            label5.Size = new Size(52, 16);
            label5.TabIndex = 9;
            label5.Text = "Yemek :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(cmbYemek);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(numAdet);
            groupBox1.Controls.Add(lblGunlukKalori);
            groupBox1.Controls.Add(numPorsiyon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbOgun);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(33, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(744, 452);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1276, 639);
            Controls.Add(groupBox1);
            Controls.Add(btnProfil);
            Controls.Add(btnRaporlar);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "AnaSayfa";
            Text = "Ana Sayfa";
            Load += AnaSayfa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPorsiyon).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnRaporlar;
        private Button btnProfil;
        private Label lblGunlukKalori;
        private Label label2;
        private Label label3;
        private ComboBox cmbOgun;
        private NumericUpDown numPorsiyon;
        private Label label4;
        private NumericUpDown numAdet;
        private ComboBox cmbYemek;
        private PictureBox pictureBox1;
        private Label label5;
        private GroupBox groupBox1;
    }
}