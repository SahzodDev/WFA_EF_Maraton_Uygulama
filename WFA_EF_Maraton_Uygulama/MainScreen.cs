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
        public MainScreen(User user)
        {
            InitializeComponent();
            albumService = new AlbumService();
            artistService = new ArtistService();
            this.user = user;
        }
        AlbumService albumService;
        ArtistService artistService;
        User user;
        private void MainScreen_Load(object sender, EventArgs e)
        {

            GetAllData();

            var satisdurdurulanlar = albumService.GetAlbumsWhereSalesStopped();
            foreach (Album album in satisdurdurulanlar)
            {
                lbSatisDurduruldu.Items.Add(album);
            }
            var satisdevamedenler = albumService.GetAlbumsWhereSalesContinue();
            foreach (Album album1 in satisdevamedenler)
            {
                lbSatisDevam.Items.Add(album1);
            }
            var soneklenenler = albumService.GetLatestTenAlbum();
            foreach (Album album2 in soneklenenler)
            {
                lbEklenen10.Items.Add(album2);
            }
            var indirimliler = albumService.GetAlbumsOnDiscount();
            foreach (Album album3 in indirimliler)
            {

            }



        }

        public void GetAllData()
        {
            List<Artist> artists = new List<Artist>();


            var albumler = albumService.GetAll();
            foreach (var album in albumler)
            {
                dgvAlbumler.Rows.Add(album.AlbumName, album.ArtistName, album.ReleaseDate, album.Price, album.SalesState);
            }
        }

        private void linklblSifreDegistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(user);
            this.Hide();
            changePassword.ShowDialog();
            this.Show();

        }
    }
}
