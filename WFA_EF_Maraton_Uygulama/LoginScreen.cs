﻿using Plak.BLL.Services;
using Plak.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plak.UI
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void linklblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signin signin = new Signin();
            this.Hide();
            signin.ShowDialog();
            this.Show();
        }
        UserService userService;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtKullaniciAdi.Text == null || txtKullaniciAdi.Text == string.Empty) && (txtSifre.Text == null || txtSifre.Text == string.Empty))
                {
                    throw new Exception("Alanlar boş bırakılamaz.");
                }
                User user = userService.UserLogin(txtKullaniciAdi.Text, txtSifre.Text);
                if (user != null)
                {
                    MessageBox.Show("Giriş başarılı.");

                    MainScreen mainScreen = new MainScreen(user);
                    this.Hide();
                    mainScreen.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            userService = new UserService();
        }
    }
}
