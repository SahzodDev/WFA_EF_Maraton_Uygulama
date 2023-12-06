namespace Plak.UI
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            lblGiris = new Label();
            txtBoxKullaniciAdi = new TextBox();
            txtBoxSifre = new TextBox();
            btnGiris = new Button();
            lnkLblKayitOl = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 81);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 142);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // lblGiris
            // 
            lblGiris.AutoSize = true;
            lblGiris.Font = new Font("Garamond", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblGiris.Location = new Point(96, 25);
            lblGiris.Name = "lblGiris";
            lblGiris.Size = new Size(217, 19);
            lblGiris.TabIndex = 2;
            lblGiris.Text = "PLAK DÜKKANINA GİRİŞ";
            // 
            // txtBoxKullaniciAdi
            // 
            txtBoxKullaniciAdi.Font = new Font("Garamond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxKullaniciAdi.Location = new Point(136, 81);
            txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            txtBoxKullaniciAdi.Size = new Size(170, 27);
            txtBoxKullaniciAdi.TabIndex = 3;
            // 
            // txtBoxSifre
            // 
            txtBoxSifre.Font = new Font("Garamond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSifre.Location = new Point(136, 139);
            txtBoxSifre.Name = "txtBoxSifre";
            txtBoxSifre.Size = new Size(170, 27);
            txtBoxSifre.TabIndex = 4;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Garamond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(197, 209);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(109, 35);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            // 
            // lnkLblKayitOl
            // 
            lnkLblKayitOl.AutoSize = true;
            lnkLblKayitOl.Font = new Font("Garamond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lnkLblKayitOl.Location = new Point(230, 259);
            lnkLblKayitOl.Name = "lnkLblKayitOl";
            lnkLblKayitOl.Size = new Size(66, 19);
            lnkLblKayitOl.TabIndex = 6;
            lnkLblKayitOl.TabStop = true;
            lnkLblKayitOl.Text = "Kayıt Ol";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 309);
            Controls.Add(lnkLblKayitOl);
            Controls.Add(btnGiris);
            Controls.Add(txtBoxSifre);
            Controls.Add(txtBoxKullaniciAdi);
            Controls.Add(lblGiris);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblGiris;
        private TextBox txtBoxKullaniciAdi;
        private TextBox txtBoxSifre;
        private Button btnGiris;
        private LinkLabel lnkLblKayitOl;
    }
}