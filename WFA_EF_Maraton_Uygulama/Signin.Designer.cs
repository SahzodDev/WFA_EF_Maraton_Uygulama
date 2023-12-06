namespace Plak.UI
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            lblKaydol = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxKullaniciKayit = new TextBox();
            btnKaydol = new Button();
            txtBoxSifreKayit = new TextBox();
            txtBoxSifreTekrar = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtBoxIsim = new TextBox();
            txtBoxSoyisim = new TextBox();
            SuspendLayout();
            // 
            // lblKaydol
            // 
            lblKaydol.AutoSize = true;
            lblKaydol.BackColor = SystemColors.ActiveCaptionText;
            lblKaydol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKaydol.ForeColor = SystemColors.ButtonHighlight;
            lblKaydol.Location = new Point(73, 23);
            lblKaydol.Name = "lblKaydol";
            lblKaydol.Size = new Size(160, 15);
            lblKaydol.TabIndex = 3;
            lblKaydol.Text = "PLAK DÜKKANINA KAYDOL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(27, 116);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(27, 158);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(27, 202);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Şifre Tekrarı";
            // 
            // txtBoxKullaniciKayit
            // 
            txtBoxKullaniciKayit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxKullaniciKayit.Location = new Point(127, 114);
            txtBoxKullaniciKayit.Margin = new Padding(3, 2, 3, 2);
            txtBoxKullaniciKayit.Name = "txtBoxKullaniciKayit";
            txtBoxKullaniciKayit.Size = new Size(140, 23);
            txtBoxKullaniciKayit.TabIndex = 7;
            // 
            // btnKaydol
            // 
            btnKaydol.BackColor = SystemColors.ActiveCaptionText;
            btnKaydol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydol.ForeColor = SystemColors.ButtonHighlight;
            btnKaydol.Location = new Point(128, 234);
            btnKaydol.Margin = new Padding(3, 2, 3, 2);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(139, 22);
            btnKaydol.TabIndex = 8;
            btnKaydol.Text = "Kayıt Ol";
            btnKaydol.UseVisualStyleBackColor = false;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // txtBoxSifreKayit
            // 
            txtBoxSifreKayit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSifreKayit.Location = new Point(127, 158);
            txtBoxSifreKayit.Margin = new Padding(3, 2, 3, 2);
            txtBoxSifreKayit.Name = "txtBoxSifreKayit";
            txtBoxSifreKayit.PasswordChar = '*';
            txtBoxSifreKayit.Size = new Size(140, 23);
            txtBoxSifreKayit.TabIndex = 9;
            // 
            // txtBoxSifreTekrar
            // 
            txtBoxSifreTekrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSifreTekrar.Location = new Point(127, 200);
            txtBoxSifreTekrar.Margin = new Padding(3, 2, 3, 2);
            txtBoxSifreTekrar.Name = "txtBoxSifreTekrar";
            txtBoxSifreTekrar.PasswordChar = '*';
            txtBoxSifreTekrar.Size = new Size(140, 23);
            txtBoxSifreTekrar.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(27, 78);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 11;
            label4.Text = "Soyisim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(27, 47);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 12;
            label5.Text = "Isim";
            // 
            // txtBoxIsim
            // 
            txtBoxIsim.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxIsim.Location = new Point(127, 46);
            txtBoxIsim.Margin = new Padding(3, 2, 3, 2);
            txtBoxIsim.Name = "txtBoxIsim";
            txtBoxIsim.Size = new Size(140, 23);
            txtBoxIsim.TabIndex = 13;
            // 
            // txtBoxSoyisim
            // 
            txtBoxSoyisim.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSoyisim.Location = new Point(127, 78);
            txtBoxSoyisim.Margin = new Padding(3, 2, 3, 2);
            txtBoxSoyisim.Name = "txtBoxSoyisim";
            txtBoxSoyisim.Size = new Size(140, 23);
            txtBoxSoyisim.TabIndex = 14;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(350, 265);
            Controls.Add(txtBoxSoyisim);
            Controls.Add(txtBoxIsim);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBoxSifreTekrar);
            Controls.Add(txtBoxSifreKayit);
            Controls.Add(btnKaydol);
            Controls.Add(txtBoxKullaniciKayit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblKaydol);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Signin";
            Text = "Signin";
            Load += Signin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKaydol;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxKullaniciKayit;
        private Button btnKaydol;
        private TextBox txtBoxSifreKayit;
        private TextBox txtBoxSifreTekrar;
        private Label label4;
        private Label label5;
        private TextBox txtBoxIsim;
        private TextBox txtBoxSoyisim;
    }
}