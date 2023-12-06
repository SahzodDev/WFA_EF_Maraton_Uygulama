using Plak.BLL.Services;
using Plak.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
                lbIndirimli.Items.Add(album3);
            }

            

            cbDurum.DataSource = Enum.GetValues(typeof(Domain.Enums.SalesState));


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

        private void dgvAlbumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void btnAlbumGuncelle_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = dgvAlbumler.SelectedRows[0].DataBoundItem as Album;
            if (selectedAlbum != null)
            {
                txtAd.Text = selectedAlbum.AlbumName;
                dtpYayinTarihi.Value = selectedAlbum.ReleaseDate;
                numUcret.Value = selectedAlbum.Price;

                if (selectedAlbum.Discount == null)
                {
                    numIndirim.Value = 0;
                }
                else
                {
                    numIndirim.Value = selectedAlbum.Discount.Value;
                }


            }

        }

        private void linklblSifreDegistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(user);

            this.Hide();
            changePassword.ShowDialog();
            this.Show();
        }

        private void btnAlbumSil_Click(object sender, EventArgs e)
        {
            Album album = albumService.GetAll().FirstOrDefault(x => x.AlbumName == txtAd.Text);

            albumService.DeleteByStatus(album.Id);
        }

        private void btnAlbumKaydet_Click(object sender, EventArgs e)
        {
            Album album = albumService.GetAll().FirstOrDefault(x => x.AlbumName == txtAd.Text);
            album.AlbumName = txtAd.Text;
            album.ReleaseDate = dtpYayinTarihi.Value;
            album.Price = numUcret.Value;
            album.Discount = numIndirim.Value;
            album.ArtistName = txtArtistGrup.Text;
            album.SalesState = (Domain.Enums.SalesState)cbDurum.SelectedItem;
            albumService.Update(album);
           
        }

        private void btnYeniAlbum_Click(object sender, EventArgs e)
        {
            Album album = new Album()
            {
                AlbumName = txtAd.Text,
                ReleaseDate = dtpYayinTarihi.Value,
                Price = numUcret.Value,
                Discount = numIndirim.Value

            };

            albumService.Add(album);
        }

        
    }
}
