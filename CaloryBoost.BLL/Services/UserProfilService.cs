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

        public double GetByCalory(int userID, DateTime date)
        {
            if (userID==0)
            {
                throw new Exception("Parametre değeri uygun değil");
            }

            return userProfilRepository.GetByCalory(userID, date);
        }
        
    }
}
