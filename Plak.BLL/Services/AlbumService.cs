using Plak.DAL.Repositories;
using Plak.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak.BLL.Services
{
    public class AlbumService
    {
        public AlbumService() 
        {
            albumRepo = new AlbumRepository();
        }
        AlbumRepository albumRepo;

        public void Add(Album album)
        {
            albumRepo.Add(album);
        }
        public void Update(Album album)
        {
            albumRepo.Update(album);
        }
        public void PermaDelete(int albumID)
        {
            albumRepo.PermaDelete(albumID);
        }

        public void DeleteByStatus(int albumID)
        { 
            albumRepo.DeleteByStatus(albumID);
        }
        public List<Album> GetAll()
        {
            return albumRepo.GetAllAlbums();
        }
        //satış devam eden albümleri getiren metod
        public List <Album> GetAlbumsWhereSalesContinue()
        {
            return albumRepo.GetAllAlbums().Where(x=>x.SalesState==Domain.Enums.SalesState.Ongoing).ToList();
        }
        //satışı durmuş albümleri getiren metod
        public List <Album>GetAlbumsWhereSalesStopped()
        {
            return albumRepo.GetAllAlbums().Where(x=>x.SalesState==Domain.Enums.SalesState.Stopped).ToList();
        }
        //indirimdeki albümleri getiren metod

        public List <Album>GetAlbumsOnDiscount()
        {
            return albumRepo.GetAllAlbums().Where(x=>x.Discount != null).OrderByDescending(x=>x.Discount).ToList();
        }
        //en son sisteme eklenen 10 album
        public List <Album> GetLatestTenAlbum()
        {
            return albumRepo.GetAllAlbums().OrderByDescending(x=>x.CreatedDate).Take(10).ToList();
        }
    }
}
