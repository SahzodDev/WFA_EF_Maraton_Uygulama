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
            lblKaydol.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblKaydol.Location = new Point(83, 31);
            lblKaydol.Name = "lblKaydol";
            lblKaydol.Size = new Size(197, 16);
            lblKaydol.TabIndex = 3;
            lblKaydol.Text = "PLAK DÜKKANINA KAYDOL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 155);
            label1.Name = "label1";
            label1.Size = new Size(79, 16);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 210);
            label2.Name = "label2";
            label2.Size = new Size(34, 16);
            label2.TabIndex = 5;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 269);
            label3.Name = "label3";
            label3.Size = new Size(80, 16);
            label3.TabIndex = 6;
            label3.Text = "Şifre Tekrarı";
            // 
            // txtBoxKullaniciKayit
            // 
            txtBoxKullaniciKayit.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxKullaniciKayit.Location = new Point(145, 152);
            txtBoxKullaniciKayit.Name = "txtBoxKullaniciKayit";
            txtBoxKullaniciKayit.Size = new Size(159, 22);
            txtBoxKullaniciKayit.TabIndex = 7;
            // 
            // btnKaydol
            // 
            btnKaydol.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydol.Location = new Point(146, 312);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(159, 29);
            btnKaydol.TabIndex = 8;
            btnKaydol.Text = "Kayıt Ol";
            btnKaydol.UseVisualStyleBackColor = true;
            // 
            // txtBoxSifreKayit
            // 
            txtBoxSifreKayit.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSifreKayit.Location = new Point(145, 210);
            txtBoxSifreKayit.Name = "txtBoxSifreKayit";
            txtBoxSifreKayit.Size = new Size(159, 22);
            txtBoxSifreKayit.TabIndex = 9;
            // 
            // txtBoxSifreTekrar
            // 
            txtBoxSifreTekrar.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSifreTekrar.Location = new Point(145, 266);
            txtBoxSifreTekrar.Name = "txtBoxSifreTekrar";
            txtBoxSifreTekrar.Size = new Size(159, 22);
            txtBoxSifreTekrar.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 104);
            label4.Name = "label4";
            label4.Size = new Size(55, 16);
            label4.TabIndex = 11;
            label4.Text = "Soyisim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 63);
            label5.Name = "label5";
            label5.Size = new Size(31, 16);
            label5.TabIndex = 12;
            label5.Text = "Isim";
            // 
            // txtBoxIsim
            // 
            txtBoxIsim.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxIsim.Location = new Point(145, 62);
            txtBoxIsim.Name = "txtBoxIsim";
            txtBoxIsim.Size = new Size(159, 22);
            txtBoxIsim.TabIndex = 13;
            // 
            // txtBoxSoyisim
            // 
            txtBoxSoyisim.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSoyisim.Location = new Point(145, 104);
            txtBoxSoyisim.Name = "txtBoxSoyisim";
            txtBoxSoyisim.Size = new Size(159, 22);
            txtBoxSoyisim.TabIndex = 14;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 353);
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
            Name = "Signin";
            Text = "Signin";
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