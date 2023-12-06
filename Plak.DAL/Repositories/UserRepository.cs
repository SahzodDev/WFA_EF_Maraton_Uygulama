using Plak.DAL.Context;
using Plak.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak.DAL.Repositories
{
    public class UserRepository
    {
        public UserRepository()
        {
            dbContext = new AppDbContext();
        }
        AppDbContext dbContext;

        public User GetUserByUsername(string username)
        {
            return dbContext.Users.FirstOrDefault(u => u.Username == username);
        }

        public User GetUserById(int id) 
        {
            return dbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Add(User user) 
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public void Update(User user) 
        {
            user.Status = Domain.Enums.Status.Modified;
            user.ModifiedDate = DateTime.Now;
            dbContext.Update(user);
            dbContext.SaveChanges();
        }

        public void Delete(User user) 
        {
            user.Status = Domain.Enums.Status.Deleted;
            user.DeletedDate = DateTime.Now;
            dbContext.Update(user) ;
            dbContext.SaveChanges();
        }

        public void PermaDelete(User user)
        {
            dbContext.Remove(user);
            dbContext.SaveChanges();
        }

        public List<User> GetAllUsers() 
        {
            return dbContext.Users.ToList();
        }
    }
}
