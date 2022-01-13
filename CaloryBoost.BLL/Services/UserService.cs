using CaloryBoost.DAL.Repositories;
using CaloryBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.BLL.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }

        public bool Insert(User user)
        {
            if (string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.BirthDate.ToString()))
            {
                throw new Exception("Bilgiler boş geçilemez");
            };

            if (userRepository.IsExistEmail(user.Email))
            {
                throw new Exception("Bu kullanıcı daha önceden kayıt olmuştur.");
            }

            if (!CheckPassword(user))
            {
                throw new Exception("Password içersinde büyük-küçük harf ve sayı bulunmalıdır.");
            }

            user.CreatedDate = DateTime.Now;

            return userRepository.Insert(user);
        }

        public bool CheckPassword(User user)
        {
            bool isCharUpper = false;
            bool isCharLower = false;
            bool isNumber = false;

            foreach (char item in user.Password)
            {
                if (char.IsUpper(item))
                {
                    isCharUpper = true;
                }
                else if (char.IsLower(item))
                {
                    isCharLower = true;
                }
                else if (char.IsDigit(item))
                {
                    isNumber = true;
                }
            }

            if (!isCharUpper || !isCharLower || !isNumber)
            {
                return false;
            }

            return true;
        }

        public User CheckLogin(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Login bilgileri boş geçilemez ve yanlış girilmemelidir.");
            }

            User user = userRepository.CheckLogin(email, password);

            if (user == null)
            {
                throw new Exception("Böyle bir kullanıcı bulunamadı.");
            }

            return user;
        }
    }
}
