namespace _01_Diyet.UI
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            dgvGünlükVeri = new DataGridView();
            lblKalori = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvÖğünKalori = new DataGridView();
            dgvEnYemekÖğün = new DataGridView();
            dgvEnYemek = new DataGridView();
            dgvKıyas = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            btnAnasayfa = new Button();
            btnProfil = new Button();
            button3 = new Button();
            btnTumKisilerOgun = new Button();
            btnTumKisilerKategori = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGünlükVeri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvÖğünKalori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnYemekÖğün).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnYemek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKıyas).BeginInit();
            SuspendLayout();
            // 
            // dgvGünlükVeri
            // 
            dgvGünlükVeri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGünlükVeri.Location = new Point(16, 324);
            dgvGünlükVeri.Name = "dgvGünlükVeri";
            dgvGünlükVeri.RowHeadersWidth = 51;
            dgvGünlükVeri.Size = new Size(452, 620);
            dgvGünlükVeri.TabIndex = 0;
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.BackColor = Color.Firebrick;
            lblKalori.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKalori.ForeColor = SystemColors.ButtonHighlight;
            lblKalori.Location = new Point(16, 179);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(185, 21);
            lblKalori.TabIndex = 1;
            lblKalori.Text = "Toplam Kalori Miktarı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Firebrick;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(667, 537);
            label2.Name = "label2";
            label2.Size = new Size(153, 19);
            label2.TabIndex = 1;
            label2.Text = "En Çok Yenen Yemekler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Firebrick;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(667, 82);
            label3.Name = "label3";
            label3.Size = new Size(204, 17);
            label3.TabIndex = 1;
            label3.Text = "Öğünlere Göre Kalori Toplamları \r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Firebrick;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(1196, 82);
            label4.Name = "label4";
            label4.Size = new Size(242, 17);
            label4.TabIndex = 2;
            label4.Text = "Öğünlere Göre En Çok Yenen Yemekler\r\n";
            // 
            // dgvÖğünKalori
            // 
            dgvÖğünKalori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvÖğünKalori.Location = new Point(667, 120);
            dgvÖğünKalori.Name = "dgvÖğünKalori";
            dgvÖğünKalori.RowHeadersWidth = 51;
            dgvÖğünKalori.Size = new Size(389, 342);
            dgvÖğünKalori.TabIndex = 4;
            // 
            // dgvEnYemekÖğün
            // 
            dgvEnYemekÖğün.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnYemekÖğün.Location = new Point(1196, 120);
            dgvEnYemekÖğün.Name = "dgvEnYemekÖğün";
            dgvEnYemekÖğün.RowHeadersWidth = 51;
            dgvEnYemekÖğün.Size = new Size(389, 342);
            dgvEnYemekÖğün.TabIndex = 5;
            // 
            // dgvEnYemek
            // 
            dgvEnYemek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnYemek.Location = new Point(667, 580);
            dgvEnYemek.Name = "dgvEnYemek";
            dgvEnYemek.RowHeadersWidth = 51;
            dgvEnYemek.Size = new Size(389, 342);
            dgvEnYemek.TabIndex = 6;
            // 
            // dgvKıyas
            // 
            dgvKıyas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKıyas.Location = new Point(1198, 580);
            dgvKıyas.Name = "dgvKıyas";
            dgvKıyas.RowHeadersWidth = 51;
            dgvKıyas.Size = new Size(389, 342);
            dgvKıyas.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(212, 277);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 23);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Firebrick;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(16, 282);
            label6.Name = "label6";
            label6.Size = new Size(153, 17);
            label6.TabIndex = 9;
            label6.Text = "Bir Tarih Seçiniz      ==>";
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.BackColor = Color.Brown;
            btnAnasayfa.ForeColor = SystemColors.ButtonHighlight;
            btnAnasayfa.Location = new Point(16, 15);
            btnAnasayfa.Margin = new Padding(3, 4, 3, 4);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.Size = new Size(161, 65);
            btnAnasayfa.TabIndex = 10;
            btnAnasayfa.Text = "ANA SAYFA";
            btnAnasayfa.UseVisualStyleBackColor = false;
            btnAnasayfa.Click += btnAnasayfa_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Brown;
            btnProfil.ForeColor = SystemColors.ButtonFace;
            btnProfil.Location = new Point(235, 15);
            btnProfil.Margin = new Padding(3, 4, 3, 4);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(161, 65);
            btnProfil.TabIndex = 11;
            btnProfil.Text = "PROFİL";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(456, 15);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(161, 65);
            button3.TabIndex = 12;
            button3.Text = "RAPORLAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnTumKisilerOgun
            // 
            btnTumKisilerOgun.BackColor = Color.Firebrick;
            btnTumKisilerOgun.ForeColor = Color.White;
            btnTumKisilerOgun.Location = new Point(1424, 492);
            btnTumKisilerOgun.Name = "btnTumKisilerOgun";
            btnTumKisilerOgun.Size = new Size(161, 68);
            btnTumKisilerOgun.TabIndex = 14;
            btnTumKisilerOgun.Text = "Tüm kişiler için,haftalık ve öğün bazında alınan toplam kalori miktarları";
            btnTumKisilerOgun.UseVisualStyleBackColor = false;
            btnTumKisilerOgun.Click += btnTumKisilerOgun_Click;
            // 
            // btnTumKisilerKategori
            // 
            btnTumKisilerKategori.BackColor = Color.Firebrick;
            btnTumKisilerKategori.ForeColor = Color.White;
            btnTumKisilerKategori.Location = new Point(1196, 496);
            btnTumKisilerKategori.Name = "btnTumKisilerKategori";
            btnTumKisilerKategori.Size = new Size(163, 64);
            btnTumKisilerKategori.TabIndex = 15;
            btnTumKisilerKategori.Text = "Tüm kişiler için besin kategorilerine göre kaç adet besin tüketildiği\r\n";
            btnTumKisilerKategori.UseVisualStyleBackColor = false;
            btnTumKisilerKategori.Click += btnTumKisilerKategori_Click_1;
            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1612, 956);
            Controls.Add(btnTumKisilerKategori);
            Controls.Add(btnTumKisilerOgun);
            Controls.Add(button3);
            Controls.Add(btnProfil);
            Controls.Add(btnAnasayfa);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvKıyas);
            Controls.Add(dgvEnYemek);
            Controls.Add(dgvEnYemekÖğün);
            Controls.Add(dgvÖğünKalori);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblKalori);
            Controls.Add(dgvGünlükVeri);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "Raporlar";
            Text = "Raporlar";
            Load += Raporlar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGünlükVeri).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvÖğünKalori).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnYemekÖğün).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnYemek).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKıyas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblKalori;
        private Label label2;
        private Label label3;
        private DataGridView dgvGünlükVeri;
        private Label label4;
        private Label label5;
        private DataGridView dgvÖğünKalori;
        private DataGridView dgvEnYemekÖğün;
        private DataGridView dgvEnYemek;
        private DataGridView dgvKıyas;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Button btnAnasayfa;
        private Button btnProfil;
        private Button button3;
        private DataGridView dataGridView2;
        private Button button1;
        private Button btnTumKisilerOgun;
        private Button btnTumKisilerKategori;
    }
}