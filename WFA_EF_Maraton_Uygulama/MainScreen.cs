﻿using Plak.BLL.Services;
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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            albumService=new AlbumService();

        }
        AlbumService albumService;
        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
