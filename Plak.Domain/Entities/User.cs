using Plak.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Plak.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Salt = (string?)GenerateSalt();
        }

        private object GenerateSalt()
        {
            byte[] randomBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes);
        }

        private string _salt;

        public string? Salt
        {
            get { return _salt; }
            set { _salt = value; }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public UserType UserType { get; set; }
        private string _hashedPassword;

        public string Password
        {
            private get { return _hashedPassword; }
            set 
            {
                if (value.Length < 8)
                {
                    throw new ArgumentException("Şifre uzunluğu en az 8 karakter olmalı.");
                }

                int upperCaseCount = value.Count(char.IsUpper);
                if (upperCaseCount < 2 ) 
                {
                    throw new ArgumentException("Şifre en az 2 büyük harf içermeli.");
                }

                int lowerCaseCount = value.Count(char.IsLower);
                if (lowerCaseCount < 3 ) 
                {
                    throw new ArgumentException("Şifre en az 3 küçük harf içermelidir.");
                }

                int specialCharCount = value.Count(c => c == '!' || c == '+' || c == '*');
                if (specialCharCount < 2 )
                {
                    throw new ArgumentException("Şifre en az iki özel karakter (!, +, *) içermelidir.");
                }


                
                _hashedPassword = HashPassword(value); 
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var combinedPassword = string.Concat(password, _salt);
                // Computes the SHA256 hash of the password bytes.
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(combinedPassword));
                // Converts the byte array to a hexadecimal string.
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public bool VerifyPassword(string password)
        {
            return HashPassword(password) == _hashedPassword;
        }

        public void ChangePassword(string password)
        {
            Salt = (string?)GenerateSalt();
            Password = password;
        }
    }
}
