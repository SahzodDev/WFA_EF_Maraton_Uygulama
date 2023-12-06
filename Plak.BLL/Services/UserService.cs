using Plak.DAL.Repositories;
using Plak.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak.BLL.Services
{
    public class UserService
    {
        public UserService()
        {
            repository = new UserRepository();
        }
        UserRepository repository;

        public User GetUserByUsername(string username)
        {
            return repository.GetUserByUsername(username);
        }

        public User GetUserById(int userId)
        {
            return repository.GetUserById(userId);
        }

        public void AddStandardUser(User user) 
        {
            user.UserType = Domain.Enums.UserType.Standard;
            repository.Add(user);
        }

        public void UpdateUser(User user)
        {
            repository.Update(user);
        }

        public void DeleteUser(User user) 
        {
            repository.Delete(user);
        }

        public bool CheckUsernameExists(string username) 
        {
            User user = repository.GetUserByUsername(username);
            if (user != null) 
            {
                return true;
            }
            else 
            { 
                return false; 
            }  
        }

        public bool CheckPassword(string password, User user)
        {
            if (!user.VerifyPassword(password)) 
            {
                return false;
            }
            else
            { 
                return true; 
            }
        }

        public void PasswordChange(string password, User user)
        {
            user.ChangePassword(password);
            repository.Update(user);
        }

        public void SignUp(User user) 
        {
            if (!CheckUsernameExists(user.Username)) 
            {
                throw new Exception("Kullanıcı adı mevcut.");
            }

            repository.Add(user);
        }

        public User UserLogin(string username, string password)
        {
            User user = repository.GetUserByUsername(username);
            if (user == null) 
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }

            if (!user.VerifyPassword(password))
            {
                throw new Exception("Şifre yanlış.");
            }

            return user;
        }
    }


}
