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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            service = new UserService();
        }

        UserService service;

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            try
            {
                CheckBoxes();
                if (service.CheckUsernameExists(txtBoxKullaniciKayit.Text))
                {
                    throw new Exception("Kullanıcı zaten mevcut.");
                }

                if (txtBoxSifreKayit.Text != txtBoxSifreTekrar.Text)
                {
                    throw new Exception("Şifreler uyuşmuyor.");
                }
                User user = new User();
                user.Username = txtBoxKullaniciKayit.Text;
                user.FirstName = txtBoxIsim.Text;
                user.LastName = txtBoxSoyisim.Text;
                user.Password = txtBoxSifreKayit.Text;
                user.UserType = Domain.Enums.UserType.Standard;
                service.AddStandardUser(user);

                MessageBox.Show("Kayıt başarılı.");

                this.Close();

            }
            catch (Exception ex)
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
