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
            txtSifre.Location = new Point(147, 110);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(202, 27);
            txtSifre.TabIndex = 19;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(147, 36);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(202, 27);
            txtKullaniciAdi.TabIndex = 18;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(38, 190);
            btnGirisYap.Margin = new Padding(3, 4, 3, 4);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(311, 39);
            btnGirisYap.TabIndex = 17;
            btnGirisYap.Text = "Giris Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            // 
            // linklblKayitOl
            // 
            linklblKayitOl.AutoSize = true;
            linklblKayitOl.Location = new Point(281, 254);
            linklblKayitOl.Name = "linklblKayitOl";
            linklblKayitOl.Size = new Size(61, 20);
            linklblKayitOl.TabIndex = 16;
            linklblKayitOl.TabStop = true;
            linklblKayitOl.Text = "Kayıt Ol";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(38, 114);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(42, 20);
            lblSifre.TabIndex = 15;
            lblSifre.Text = "Şifre:";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(38, 40);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(99, 20);
            lblKullaniciAdi.TabIndex = 14;
            lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 344);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnGirisYap);
            Controls.Add(linklblKayitOl);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Name = "LoginScreen";
            Text = "LoginScreen";
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