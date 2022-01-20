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
              
        public double GetByCalory(int userID)
        {
            var date = DateTime.Now.Date; // where içerisinde Datetime.date.now yapınca hata veriyor. biz de bunu değişkene atadık

            var userInformations = context.Foods.Join(context.UserMealFoods,
                                               food => food.ID,
                                               x => x.FoodID,
                                               (food, x) => new UserTotalCalory //anonim olmaması için
                                               {
                                                   Id = x.UserID,
                                                   TotalCalory = (x.Portion / food.Portion) * food.Calory,
                                                   DailyCalory = x.CreatedDate

                                               }).Where(a => a.Id == userID && DbFunctions.TruncateTime(a.DailyCalory) == date).ToList(); 
           

            return userInformations.Sum(a=>a.TotalCalory); //burada linq da hata aldık sum metodunu çekemedik. nullable tarzında bir hata oluştu. bizde list olarak veriyi çektik hata almadık ve return olarak listlerde linq kullanarak sum metodunu bu şekilde kullandık.
        }

        
    }
}

public class UserTotalCalory
{
    public double TotalCalory { get; set; }
    public int Id { get; set; }
    public DateTime DailyCalory { get; set; }
}


