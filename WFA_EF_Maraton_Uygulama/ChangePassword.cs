using Plak.BLL.Services;
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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        UserService userService;
        User user;
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            userService = new UserService();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                CheckBoxes();
                if (!userService.CheckPassword(txtBoxEskiSifre.Text, user))
                {
                    throw new Exception("Eski şifre yanlış.");
                }
                if (txtBoxYeniSifre.Text != txtBoxYeniSifreTekrar.Text)
                {
                    throw new Exception("Yeni şifreler uyuşmuyor.");
                }
                

                userService.PasswordChange(txtBoxYeniSifre.Text, user);
                MessageBox.Show("Şifre başarıyla değişti.");
                this.Close();

            }
            catch(Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CheckBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == null || c.Text == string.Empty)
                    {
                        throw new Exception("Alanlar boş bırakılamaz.");
                    }
                }
            }
        }
    }
}
