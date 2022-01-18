using CaloryBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        //public User GetById(int userID)
        //{
        //    return context.Users.Where(a => a.ID == userID).SingleOrDefault();
        //}

        public double GetByCalory(int userID)
        {
            var userInformations = context.Foods.Join(context.UserMealFoods,
                                               food => food.ID,
                                               x => x.FoodID,
                                               (food, x) => new UserTotalCalory
                                               {
                                                   Id = x.UserID,
                                                   TotalCalory = (x.Portion / food.Portion) * food.Calory,
                                                   DailyCalory = x.CreatedDate

                                               }).Where(a => a.Id == userID && DbFunctions.TruncateTime(a.DailyCalory) == DateTime.Now).ToList();
            //burada linq da hata aldık sum tarafını çekemedik. nullable tarzında bir hata oluştu. bizde list oalrak programa çektik hata almadık ve return olarak listlerde linq kullanarak sum metodunu bu şekilde kullandık. arz ederim.
           
            return userInformations.Sum(a=>a.TotalCalory);
        }

        
    }
}

public class UserTotalCalory
{
    public double TotalCalory { get; set; }
    public int Id { get; set; }
    public DateTime DailyCalory { get; set; }
}


