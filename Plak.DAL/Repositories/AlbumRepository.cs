using Plak.DAL.Context;
using Plak.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak.DAL.Repositories
{
    public class AlbumRepository
    {
        public AlbumRepository() 
        {
           dbContext =new AppDbContext();
        }
        AppDbContext dbContext;

        public void Add(Album album)
        {
            dbContext.Albums.Add(album);
            dbContext.SaveChanges();

        }
        public void Update(Album album)
        {
            album.Status = Domain.Enums.Status.Modified;
            album.ModifiedDate = DateTime.Now;
            dbContext.Albums.Update(album);
            dbContext.SaveChanges();
            

        }
        public void DeleteByStatus(int albumID)
        {
            Album album = dbContext.Albums.Find(albumID);
            album.Status=Domain.Enums.Status.Deleted;
            album.DeletedDate = DateTime.Now;
            dbContext.Albums.Update(album);
            dbContext.SaveChanges();

        }
        public void PermaDelete(int albumID)
        {
            Album album = dbContext.Albums.Find(albumID);
            dbContext.Remove(album);
            dbContext.SaveChanges();
        }

        public List <Album> GetAllAlbums()
        {
            return dbContext.Albums.Where(x=>x.Status!=Domain.Enums.Status.Deleted).ToList();
        }


        
    }

}
