﻿namespace Plak.UI
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            btnSifreDegistir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxEskiSifre = new TextBox();
            txtBoxYeniSifre = new TextBox();
            txtBoxYeniSifreTekrar = new TextBox();
            SuspendLayout();
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.BackColor = SystemColors.ActiveCaptionText;
            btnSifreDegistir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifreDegistir.ForeColor = SystemColors.ButtonHighlight;
            btnSifreDegistir.Location = new Point(108, 260);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(148, 38);
            btnSifreDegistir.TabIndex = 0;
            btnSifreDegistir.Text = "Şifre Değiştir";
            btnSifreDegistir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 74);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "Eski Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(40, 137);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Yeni Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(40, 194);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 3;
            label3.Text = "Yeni Şifre Tekrar";
            // 
            // txtBoxEskiSifre
            // 
            txtBoxEskiSifre.Location = new Point(160, 74);
            txtBoxEskiSifre.Name = "txtBoxEskiSifre";
            txtBoxEskiSifre.Size = new Size(173, 27);
            txtBoxEskiSifre.TabIndex = 4;
            // 
            // txtBoxYeniSifre
            // 
            txtBoxYeniSifre.Location = new Point(160, 134);
            txtBoxYeniSifre.Name = "txtBoxYeniSifre";
            txtBoxYeniSifre.Size = new Size(173, 27);
            txtBoxYeniSifre.TabIndex = 5;
            // 
            // txtBoxYeniSifreTekrar
            // 
            txtBoxYeniSifreTekrar.Location = new Point(160, 191);
            txtBoxYeniSifreTekrar.Name = "txtBoxYeniSifreTekrar";
            txtBoxYeniSifreTekrar.Size = new Size(173, 27);
            txtBoxYeniSifreTekrar.TabIndex = 6;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(366, 353);
            Controls.Add(txtBoxYeniSifreTekrar);
            Controls.Add(txtBoxYeniSifre);
            Controls.Add(txtBoxEskiSifre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSifreDegistir);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSifreDegistir;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxEskiSifre;
        private TextBox txtBoxYeniSifre;
        private TextBox txtBoxYeniSifreTekrar;
    }
}