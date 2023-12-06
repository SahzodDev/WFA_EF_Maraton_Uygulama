namespace Plak.UI
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            btnGirisYap = new Button();
            linklblKayitOl = new LinkLabel();
            lblSifre = new Label();
            lblKullaniciAdi = new Label();
            SuspendLayout();
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(129, 82);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(177, 23);
            txtSifre.TabIndex = 19;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(129, 27);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(177, 23);
            txtKullaniciAdi.TabIndex = 18;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = SystemColors.ActiveCaptionText;
            btnGirisYap.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.ForeColor = SystemColors.ButtonHighlight;
            btnGirisYap.Location = new Point(188, 142);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(117, 29);
            btnGirisYap.TabIndex = 17;
            btnGirisYap.Text = "Giris Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // linklblKayitOl
            // 
            linklblKayitOl.AutoSize = true;
            linklblKayitOl.BackColor = SystemColors.ActiveCaptionText;
            linklblKayitOl.LinkColor = Color.Red;
            linklblKayitOl.Location = new Point(246, 190);
            linklblKayitOl.Name = "linklblKayitOl";
            linklblKayitOl.Size = new Size(48, 15);
            linklblKayitOl.TabIndex = 16;
            linklblKayitOl.TabStop = true;
            linklblKayitOl.Text = "Kayıt Ol";
            linklblKayitOl.LinkClicked += linklblKayitOl_LinkClicked;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = SystemColors.ActiveCaptionText;
            lblSifre.ForeColor = SystemColors.ButtonHighlight;
            lblSifre.Location = new Point(33, 86);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 15;
            lblSifre.Text = "Şifre:";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.BackColor = SystemColors.ActiveCaptionText;
            lblKullaniciAdi.ForeColor = SystemColors.ButtonHighlight;
            lblKullaniciAdi.Location = new Point(33, 30);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(79, 15);
            lblKullaniciAdi.TabIndex = 14;
            lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(344, 258);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnGirisYap);
            Controls.Add(linklblKayitOl);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginScreen";
            Text = "LoginScreen";
            Load += LoginScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Button btnGirisYap;
        private LinkLabel linklblKayitOl;
        private Label lblSifre;
        private Label lblKullaniciAdi;
    }
}