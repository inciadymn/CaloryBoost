using CaloryBoost.Model;
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

        public List<SelectedFood> GetFood(int mealID, int userId)
        {
            var selecedFood = context.Foods.Join(context.UserMealFoods,
                                                 food => food.ID,
                                                 x => x.FoodID,
                                                 (food, x) => new SelectedFood
                                                 {
                                                     MealId = x.MealID,
                                                     UserId = x.UserID,
                                                     FoodName = food.Name,
                                                     FoodId = x.FoodID,
                                                     Amount = x.Portion,
                                                     Calory = x.Portion * food.Calory,
                                                     DailyCalory = x.CreatedDate

                                                 })
                                                 .Where(a => a.MealId == mealID && a.UserId == userId && a.DailyCalory.Date == DateTime.Now.Date)
                                                 .ToList();

            return selecedFood;
        }

        
        public string GetMealName(int mealID)
        {
            return context.Meals.Where(a => a.ID == mealID).Select(a => a.Name).SingleOrDefault();
        }

        public bool Update(UserMealFood food)
        {
            UserMealFood updatedPortion = context.UserMealFoods.SingleOrDefault(a => a.MealID == food.MealID);
            updatedPortion.Portion = food.Portion;
            return context.SaveChanges() > 0;
        }


        public bool Delete(int foodId)
        {
            UserMealFood deletedFood = context.UserMealFoods.SingleOrDefault(a => a.FoodID == foodId);
            context.UserMealFoods.Remove(deletedFood);
            return context.SaveChanges() > 0;
        }

        public List<Food> FoodsList()
        {
            List<Food> foodsList = context.Foods.ToList();

            return foodsList;
        }

        public bool Insert(UserMealFood userMealFood)
        {
            context.UserMealFoods.Add(userMealFood);
            return context.SaveChanges() > 0;
        }
    }
}

