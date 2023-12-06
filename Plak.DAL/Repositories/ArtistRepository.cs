using Plak.DAL.Context;
using Plak.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak.DAL.Repositories
{
    public class ArtistRepository
    {
        public ArtistRepository()
        {
            dbContext = new AppDbContext();
        }
        AppDbContext dbContext;

        public Artist GetById(int id)
        {
            return dbContext.Artists.FirstOrDefault(x => x.Id == id && x.Status != Domain.Enums.Status.Deleted);
        }

        public void Add(Artist artist)
        {
            dbContext.Artists.Add(artist);
            dbContext.SaveChanges();
        }

        public void Update(Artist artist)
        {
            artist.Status = Domain.Enums.Status.Modified;
            artist.ModifiedDate = DateTime.Now;
            dbContext.Update(artist);
            dbContext.SaveChanges();
        }

        public void Delete(Artist artist) 
        {
            artist.Status = Domain.Enums.Status.Deleted;
            artist.DeletedDate = DateTime.Now;
            dbContext.Update(artist);
            dbContext.SaveChanges();
        }
        
        public void PermaDelete(Artist artist)
        {
            dbContext.Remove(artist);
            dbContext.SaveChanges();
        }

        public List<Artist> GetAll() 
        {
            return dbContext.Artists.Where(x => x.Status != Domain.Enums.Status.Deleted).ToList();
        }
        

    }
}
