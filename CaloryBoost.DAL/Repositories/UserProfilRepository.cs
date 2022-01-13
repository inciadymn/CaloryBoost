using CaloryBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.DAL.Repositories
{
    public class UserProfilRepository
    {
        CaloryBoostDbContext context;
        public UserProfilRepository()
        {
            context = new CaloryBoostDbContext();
        }

        public List<User> GetById(int userID)
        {
            return context.Users.Where(a => a.ID == userID).ToList();
        }
    }
}
