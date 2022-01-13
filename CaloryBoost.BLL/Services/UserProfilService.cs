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

        public List<User> GetById(int userID)
        {
            List<User> users = new List<User>();
            if (userID > 0)
            {
                users = userProfilRepository.GetById(userID);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
            return users;
        }

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
