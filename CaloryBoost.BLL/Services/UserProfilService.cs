using CaloryBoost.DAL.Repositories;
using CaloryBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.BLL.Services
{
    public class UserProfilService
    {
        UserProfilRepository userProfilRepository;
        public UserProfilService()
        {
            userProfilRepository = new UserProfilRepository();   
        }

        //public User GetById(int userID)
        //{
        //    User user = new User();
        //    if (userID > 0)
        //    {
        //        user = userProfilRepository.GetById(userID);
        //    }
        //    if (user==null)
        //    {
        //        throw new Exception("Kullanıcı bulunamadı.");
        //    }
        //    return user;
        //}

        public double GetByCalory(int userID)
        {
            if (userID==0)
            {
                throw new Exception("Parametre değeri uygun değil");
            }

            return userProfilRepository.GetByCalory(userID);
        }
        
    }
}
