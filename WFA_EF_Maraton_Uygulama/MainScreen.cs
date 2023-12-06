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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            albumService=new AlbumService();
            artistService=new ArtistService();
        }
        AlbumService albumService;
        ArtistService artistService;
        private void MainScreen_Load(object sender, EventArgs e)
        {
           

        }

        public void GetAllData()
        {
            List <Artist> artists= new List <Artist>();

            
            var albumler=albumService.GetAll();
            foreach (var album in albumler)
            {
                dgvAlbumler.Rows.Add(album.AlbumName, album.ArtistID, album.ReleaseDate,album.Price,album.SalesState);
            }
        }
    }
}
