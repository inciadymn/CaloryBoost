using CaloryBoost.DAL.Repositories;
using CaloryBoost.Model.Entities;
using System;
using System.Text.RegularExpressions;

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

            //email validasyonu yapıldı
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.Match(user.Email).Success) //match metodu yukarıdaki regex ile eşleşiyor mu diye bakar ve success bunu bool sonuç olarak döner
            {
                throw new Exception("Bu email geçersizdir.");
            }

            if (user.Phone.Length!=11)
            {
                throw new Exception("Numarayı düzgün gir ulan.");
            }

            foreach (char item in user.Phone)
            {
                if (!char.IsDigit(item))
                {
                    throw new Exception("Buraya sadece rakamlar giriniz.");
                }
            }

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
