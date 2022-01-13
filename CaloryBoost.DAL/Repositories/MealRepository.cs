using CaloryBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.DAL.Repositories
{
    public class MealRepository
    {
        CaloryBoostDbContext context;
        public MealRepository()
        {
            context = new CaloryBoostDbContext();
        }

        public List<SelecedFood> GetFood(int mealID)
        {
            var selecedFood = context.Foods.Join(context.UserMealFoods,
                                                 food => food.ID,
                                                 x => x.FoodID,
                                                 (food, x) => new SelecedFood
                                                 {
                                                     Id = x.MealID,
                                                     FoodName=food.Name,
                                                     Amount=x.Portion,
                                                     Calory = x.Portion * food.Calory,
                                                     DailyCalory = x.CreatedDate
                                               
                                                 })
                                                 .Where(a => a.Id == mealID && a.DailyCalory.Date == DateTime.Now.Date)
                                                 .ToList();

            return selecedFood;
        }

        //TODO:update metodu için servis yazılmadı.
        public bool Update(UserMealFood food)
        {
            UserMealFood updatedPortion = context.UserMealFoods.SingleOrDefault(a => a.MealID == food.MealID);
            updatedPortion.Portion = food.Portion;
            return context.SaveChanges() > 0;
        }


        public bool Delete(UserMealFood food)
        {
            UserMealFood deletedFood = context.UserMealFoods.SingleOrDefault(a => a.MealID == food.MealID);
            context.UserMealFoods.Remove(deletedFood);
            return context.SaveChanges() > 0;
        }
    }
}

public class SelecedFood
{
    public string FoodName { get; set; }
    public double Amount { get; set; }
    public double Calory { get; set; }
    public int Id { get; set; }
    public DateTime DailyCalory { get; set; }
}
