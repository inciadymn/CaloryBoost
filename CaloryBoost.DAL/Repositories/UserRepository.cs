using CaloryBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.DAL.Repositories
{
    public class UserRepository
    {
        CaloryBoostDbContext context;
        public UserRepository()
        {
            context = new CaloryBoostDbContext();
        }

        //user kayıt olacak
        public bool Insert(User user)
        {
            context.Users.Add(user);
            return context.SaveChanges() > 0;
        }

        //Email database de var mı yok mu kontrol eden metot.

        public bool IsExistEmail(string email)
        {
            return context.Users.Any(a => a.Email == email);
        }

        //user login olacak
        public User CheckLogin(string email, string password)
        {
            User user = context.Users.Where(a => a.Email == email && a.Password==password).SingleOrDefault();
            
             return user;
        }
    }
}
