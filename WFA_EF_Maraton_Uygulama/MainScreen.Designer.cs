namespace Plak.UI
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            cbDurum = new ComboBox();
            numUcret = new NumericUpDown();
            numIndirim = new NumericUpDown();
            dtpYayinTarihi = new DateTimePicker();
            lblArtistGrup = new Label();
            lblDurum = new Label();
            lblIndirim = new Label();
            txtArtistGrup = new TextBox();
            lblUcret = new Label();
            lblYayinTarihi = new Label();
            lblAd = new Label();
            txtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbIndirimli = new ListBox();
            lbEklenen10 = new ListBox();
            lbSatisDevam = new ListBox();
            lbSatisDurduruldu = new ListBox();
            btnAlbumGuncelle = new Button();
            btnAlbumKaydet = new Button();
            btnAlbumSil = new Button();
            btnYeniAlbum = new Button();
            lblDetay = new Label();
            linklblSifreDegistir = new LinkLabel();
            dgvAlbumler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            İndirim = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numUcret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndirim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).BeginInit();
            SuspendLayout();
            // 
            // cbDurum
            // 
            cbDurum.FormattingEnabled = true;
            cbDurum.Location = new Point(405, 404);
            cbDurum.Name = "cbDurum";
            cbDurum.Size = new Size(151, 23);
            cbDurum.TabIndex = 75;
            // 
            // numUcret
            // 
            numUcret.Location = new Point(102, 430);
            numUcret.Name = "numUcret";
            numUcret.Size = new Size(151, 23);
            numUcret.TabIndex = 74;
            // 
            // numIndirim
            // 
            numIndirim.Location = new Point(405, 375);
            numIndirim.Name = "numIndirim";
            numIndirim.Size = new Size(151, 23);
            numIndirim.TabIndex = 73;
            // 
            // dtpYayinTarihi
            // 
            dtpYayinTarihi.Location = new Point(102, 404);
            dtpYayinTarihi.Name = "dtpYayinTarihi";
            dtpYayinTarihi.Size = new Size(151, 23);
            dtpYayinTarihi.TabIndex = 72;
            // 
            // lblArtistGrup
            // 
            lblArtistGrup.AutoSize = true;
            lblArtistGrup.BackColor = SystemColors.ActiveCaptionText;
            lblArtistGrup.ForeColor = SystemColors.ButtonHighlight;
            lblArtistGrup.Location = new Point(332, 434);
            lblArtistGrup.Name = "lblArtistGrup";
            lblArtistGrup.Size = new Size(66, 15);
            lblArtistGrup.TabIndex = 71;
            lblArtistGrup.Text = "Artist/Grup";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.BackColor = SystemColors.ActiveCaptionText;
            lblDurum.ForeColor = SystemColors.ButtonHighlight;
            lblDurum.Location = new Point(332, 404);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(44, 15);
            lblDurum.TabIndex = 70;
            lblDurum.Text = "Durum";
            // 
            // lblIndirim
            // 
            lblIndirim.AutoSize = true;
            lblIndirim.BackColor = SystemColors.ActiveCaptionText;
            lblIndirim.ForeColor = SystemColors.ButtonHighlight;
            lblIndirim.Location = new Point(331, 377);
            lblIndirim.Name = "lblIndirim";
            lblIndirim.Size = new Size(45, 15);
            lblIndirim.TabIndex = 69;
            lblIndirim.Text = "İndirim";
            // 
            // txtArtistGrup
            // 
            txtArtistGrup.Location = new Point(405, 432);
            txtArtistGrup.Name = "txtArtistGrup";
            txtArtistGrup.Size = new Size(151, 23);
            txtArtistGrup.TabIndex = 68;
            // 
            // lblUcret
            // 
            lblUcret.AutoSize = true;
            lblUcret.BackColor = SystemColors.ActiveCaptionText;
            lblUcret.ForeColor = SystemColors.ButtonHighlight;
            lblUcret.Location = new Point(23, 434);
            lblUcret.Name = "lblUcret";
            lblUcret.Size = new Size(35, 15);
            lblUcret.TabIndex = 67;
            lblUcret.Text = "Ücret";
            // 
            // lblYayinTarihi
            // 
            lblYayinTarihi.AutoSize = true;
            lblYayinTarihi.BackColor = SystemColors.ActiveCaptionText;
            lblYayinTarihi.ForeColor = SystemColors.ButtonHighlight;
            lblYayinTarihi.Location = new Point(23, 409);
            lblYayinTarihi.Name = "lblYayinTarihi";
            lblYayinTarihi.Size = new Size(66, 15);
            lblYayinTarihi.TabIndex = 66;
            lblYayinTarihi.Text = "Yayın Tarihi";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.BackColor = SystemColors.ActiveCaptionText;
            lblAd.ForeColor = SystemColors.ButtonHighlight;
            lblAd.Location = new Point(23, 381);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 65;
            lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(102, 376);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(151, 23);
            txtAd.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(578, 216);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 63;
            label5.Text = "İndirimli";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(391, 216);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 62;
            label4.Text = "Son Eklenen 10 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(195, 217);
            label3.Name = "label3";
            label3.Size = new Size(154, 15);
            label3.TabIndex = 61;
            label3.Text = "Satış Durumu Devam Ediyor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 217);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 60;
            label2.Text = "Satış Durumu Durduruldu";
            // 
            // lbIndirimli
            // 
            lbIndirimli.FormattingEnabled = true;
            lbIndirimli.ItemHeight = 15;
            lbIndirimli.Location = new Point(578, 234);
            lbIndirimli.Name = "lbIndirimli";
            lbIndirimli.Size = new Size(167, 109);
            lbIndirimli.TabIndex = 59;
            // 
            // lbEklenen10
            // 
            lbEklenen10.FormattingEnabled = true;
            lbEklenen10.ItemHeight = 15;
            lbEklenen10.Location = new Point(391, 234);
            lbEklenen10.Name = "lbEklenen10";
            lbEklenen10.Size = new Size(166, 109);
            lbEklenen10.TabIndex = 58;
            // 
            // lbSatisDevam
            // 
            lbSatisDevam.FormattingEnabled = true;
            lbSatisDevam.ItemHeight = 15;
            lbSatisDevam.Location = new Point(195, 235);
            lbSatisDevam.Name = "lbSatisDevam";
            lbSatisDevam.Size = new Size(176, 109);
            lbSatisDevam.TabIndex = 57;
            // 
            // lbSatisDurduruldu
            // 
            lbSatisDurduruldu.FormattingEnabled = true;
            lbSatisDurduruldu.ItemHeight = 15;
            lbSatisDurduruldu.Location = new Point(17, 235);
            lbSatisDurduruldu.Name = "lbSatisDurduruldu";
            lbSatisDurduruldu.Size = new Size(162, 109);
            lbSatisDurduruldu.TabIndex = 56;
            // 
            // btnAlbumGuncelle
            // 
            btnAlbumGuncelle.BackColor = SystemColors.ActiveCaptionText;
            btnAlbumGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlbumGuncelle.ForeColor = SystemColors.ButtonHighlight;
            btnAlbumGuncelle.Location = new Point(616, 448);
            btnAlbumGuncelle.Name = "btnAlbumGuncelle";
            btnAlbumGuncelle.Size = new Size(129, 22);
            btnAlbumGuncelle.TabIndex = 54;
            btnAlbumGuncelle.Text = "Albüm Güncelle";
            btnAlbumGuncelle.UseVisualStyleBackColor = false;
            btnAlbumGuncelle.Click += btnAlbumGuncelle_Click;
            // 
            // btnAlbumKaydet
            // 
            btnAlbumKaydet.BackColor = SystemColors.ActiveCaptionText;
            btnAlbumKaydet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlbumKaydet.ForeColor = SystemColors.ButtonHighlight;
            btnAlbumKaydet.Location = new Point(616, 420);
            btnAlbumKaydet.Name = "btnAlbumKaydet";
            btnAlbumKaydet.Size = new Size(129, 22);
            btnAlbumKaydet.TabIndex = 53;
            btnAlbumKaydet.Text = "Albüm Kaydet";
            btnAlbumKaydet.UseVisualStyleBackColor = false;
            btnAlbumKaydet.Click += btnAlbumKaydet_Click;
            // 
            // btnAlbumSil
            // 
            btnAlbumSil.BackColor = SystemColors.ActiveCaptionText;
            btnAlbumSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlbumSil.ForeColor = SystemColors.ButtonHighlight;
            btnAlbumSil.Location = new Point(616, 392);
            btnAlbumSil.Name = "btnAlbumSil";
            btnAlbumSil.Size = new Size(129, 22);
            btnAlbumSil.TabIndex = 52;
            btnAlbumSil.Text = "Albüm Sil";
            btnAlbumSil.UseVisualStyleBackColor = false;
            btnAlbumSil.Click += btnAlbumSil_Click;
            // 
            // btnYeniAlbum
            // 
            btnYeniAlbum.BackColor = SystemColors.ActiveCaptionText;
            btnYeniAlbum.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniAlbum.ForeColor = SystemColors.ButtonHighlight;
            btnYeniAlbum.Location = new Point(616, 363);
            btnYeniAlbum.Name = "btnYeniAlbum";
            btnYeniAlbum.Size = new Size(129, 22);
            btnYeniAlbum.TabIndex = 51;
            btnYeniAlbum.Text = "Yeni Albüm";
            btnYeniAlbum.UseVisualStyleBackColor = false;
            btnYeniAlbum.Click += btnYeniAlbum_Click;
            // 
            // lblDetay
            // 
            lblDetay.AutoSize = true;
            lblDetay.BackColor = SystemColors.ActiveCaptionText;
            lblDetay.ForeColor = SystemColors.ButtonHighlight;
            lblDetay.Location = new Point(17, 5);
            lblDetay.Name = "lblDetay";
            lblDetay.Size = new Size(37, 15);
            lblDetay.TabIndex = 50;
            lblDetay.Text = "Detay";
            // 
            // linklblSifreDegistir
            // 
            linklblSifreDegistir.AutoSize = true;
            linklblSifreDegistir.BackColor = SystemColors.ActiveCaptionText;
            linklblSifreDegistir.LinkColor = Color.Red;
            linklblSifreDegistir.Location = new Point(650, 486);
            linklblSifreDegistir.Name = "linklblSifreDegistir";
            linklblSifreDegistir.Size = new Size(73, 15);
            linklblSifreDegistir.TabIndex = 49;
            linklblSifreDegistir.TabStop = true;
            linklblSifreDegistir.Text = "Şifre Değiştir";
            linklblSifreDegistir.LinkClicked += linklblSifreDegistir_LinkClicked;
            // 
            // dgvAlbumler
            // 
            dgvAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbumler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, İndirim, Column5 });
            dgvAlbumler.Location = new Point(5, 22);
            dgvAlbumler.Margin = new Padding(3, 2, 3, 2);
            dgvAlbumler.Name = "dgvAlbumler";
            dgvAlbumler.RowHeadersWidth = 51;
            dgvAlbumler.RowTemplate.Height = 29;
            dgvAlbumler.Size = new Size(739, 196);
            dgvAlbumler.TabIndex = 76;
            dgvAlbumler.CellClick += dgvAlbumler_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Albüm Adı";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Albüm Sanatçısı/ Grubu";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Çıkış Tarihi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Fiyat";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // İndirim
            // 
            İndirim.HeaderText = "İndirim Oranı";
            İndirim.MinimumWidth = 6;
            İndirim.Name = "İndirim";
            İndirim.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Satış Durumu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(772, 510);
            Controls.Add(dgvAlbumler);
            Controls.Add(cbDurum);
            Controls.Add(numUcret);
            Controls.Add(numIndirim);
            Controls.Add(dtpYayinTarihi);
            Controls.Add(lblArtistGrup);
            Controls.Add(lblDurum);
            Controls.Add(lblIndirim);
            Controls.Add(txtArtistGrup);
            Controls.Add(lblUcret);
            Controls.Add(lblYayinTarihi);
            Controls.Add(lblAd);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbIndirimli);
            Controls.Add(lbEklenen10);
            Controls.Add(lbSatisDevam);
            Controls.Add(lbSatisDurduruldu);
            Controls.Add(btnAlbumGuncelle);
            Controls.Add(btnAlbumKaydet);
            Controls.Add(btnAlbumSil);
            Controls.Add(btnYeniAlbum);
            Controls.Add(lblDetay);
            Controls.Add(linklblSifreDegistir);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainScreen";
            Text = "MainScreen";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)numUcret).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndirim).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDurum;
        private NumericUpDown numUcret;
        private NumericUpDown numIndirim;
        private DateTimePicker dtpYayinTarihi;
        private Label lblArtistGrup;
        private Label lblDurum;
        private Label lblIndirim;
        private TextBox txtArtistGrup;
        private Label lblUcret;
        private Label lblYayinTarihi;
        private Label lblAd;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox lbIndirimli;
        private ListBox lbEklenen10;
        private ListBox lbSatisDevam;
        private ListBox lbSatisDurduruldu;
        private Button btnAlbumGuncelle;
        private Button btnAlbumKaydet;
        private Button btnAlbumSil;
        private Button btnYeniAlbum;
        private Label lblDetay;
        private LinkLabel linklblSifreDegistir;
        private DataGridView dgvAlbumler;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn İndirim;
        private DataGridViewTextBoxColumn Column5;
    }
}