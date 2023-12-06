using Plak.DAL.Repositories;
using Plak.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak.BLL.Services
{
    public class ArtistService
    {
        public ArtistService()
        {
            repository = new ArtistRepository();
        }
        ArtistRepository repository;

        public void Add(Artist artist)
        {
            repository.Add(artist);
        }

        public void Update(Artist artist)
        {
            repository.Update(artist);
        }

        public void Delete(Artist artist)
        {
            repository.Delete(artist);
        }

        public List<Artist> GetAll()
        {
            return repository.GetAll();
        }

        public Artist Get(int id)
        {
            return repository.GetById(id);
        }

    }
}
