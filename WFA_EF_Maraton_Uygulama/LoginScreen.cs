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
    }
}
