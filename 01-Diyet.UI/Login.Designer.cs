namespace _01_Diyet.UI
{
    partial class Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnGirisYap = new Button();
            btnUyeOl = new Button();
            chkSifreyiGoster = new CheckBox();
            label4 = new Label();
            picturBxEmail = new PictureBox();
            picturBxSifre = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picturBxEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturBxSifre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(87, 172);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Firebrick;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(87, 224);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı Şifre :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEmail.Location = new Point(262, 170);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtPassword.Location = new Point(262, 218);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(222, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.Firebrick;
            btnGirisYap.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGirisYap.ForeColor = SystemColors.ButtonFace;
            btnGirisYap.Location = new Point(262, 331);
            btnGirisYap.Margin = new Padding(2, 3, 2, 3);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(110, 50);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnUyeOl
            // 
            btnUyeOl.BackColor = Color.Firebrick;
            btnUyeOl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnUyeOl.ForeColor = SystemColors.ButtonFace;
            btnUyeOl.Location = new Point(124, 331);
            btnUyeOl.Margin = new Padding(2, 3, 2, 3);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(110, 50);
            btnUyeOl.TabIndex = 2;
            btnUyeOl.Text = "ÜYE OL";
            btnUyeOl.UseVisualStyleBackColor = false;
            btnUyeOl.Click += btnUyeOl_Click;
            // 
            // chkSifreyiGoster
            // 
            chkSifreyiGoster.AutoSize = true;
            chkSifreyiGoster.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkSifreyiGoster.Location = new Point(199, 284);
            chkSifreyiGoster.Margin = new Padding(2, 3, 2, 3);
            chkSifreyiGoster.Name = "chkSifreyiGoster";
            chkSifreyiGoster.Size = new Size(80, 18);
            chkSifreyiGoster.TabIndex = 3;
            chkSifreyiGoster.Text = "Şifreyi Göster";
            chkSifreyiGoster.UseVisualStyleBackColor = true;
            chkSifreyiGoster.CheckedChanged += chkSifreyiGoster_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Firebrick;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(124, 82);
            label4.Name = "label4";
            label4.Size = new Size(309, 26);
            label4.TabIndex = 5;
            label4.Text = "KALORİ TAKİP PROGRAMI";
            // 
            // picturBxEmail
            // 
            picturBxEmail.BackgroundImageLayout = ImageLayout.Stretch;
            picturBxEmail.Image = Properties.Resources._1077012;
            picturBxEmail.Location = new Point(33, 170);
            picturBxEmail.Name = "picturBxEmail";
            picturBxEmail.Size = new Size(37, 27);
            picturBxEmail.SizeMode = PictureBoxSizeMode.Zoom;
            picturBxEmail.TabIndex = 6;
            picturBxEmail.TabStop = false;
            // 
            // picturBxSifre
            // 
            picturBxSifre.BackgroundImage = Properties.Resources._3500716;
            picturBxSifre.BackgroundImageLayout = ImageLayout.Zoom;
            picturBxSifre.Location = new Point(33, 218);
            picturBxSifre.Name = "picturBxSifre";
            picturBxSifre.Size = new Size(37, 27);
            picturBxSifre.SizeMode = PictureBoxSizeMode.Zoom;
            picturBxSifre.TabIndex = 7;
            picturBxSifre.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1046747;
            pictureBox1.Location = new Point(-10, 516);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Giriş
            // 
            AutoScaleDimensions = new SizeF(5F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(913, 577);
            Controls.Add(pictureBox1);
            Controls.Add(picturBxSifre);
            Controls.Add(picturBxEmail);
            Controls.Add(chkSifreyiGoster);
            Controls.Add(label4);
            Controls.Add(btnGirisYap);
            Controls.Add(label1);
            Controls.Add(btnUyeOl);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Giriş";
            Text = "Giriş";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)picturBxEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturBxSifre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnGirisYap;
        private Button btnUyeOl;
        private CheckBox chkSifreyiGoster;
        private Label label4;
        private PictureBox picturBxEmail;
        private PictureBox picturBxSifre;
        private PictureBox pictureBox1;
    }
}