using CaloryBoost.Model;
using CaloryBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
            var date = DateTime.Now.Date;
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
                                                 .Where(a => a.MealId == mealID && a.UserId == userId && DbFunctions.TruncateTime(a.DailyCalory) == date)
                                                 .ToList();

            return selecedFood;
        }


        public string GetMealName(int mealID)
        {
            return context.Meals.Where(a => a.ID == mealID).Select(a => a.Name).SingleOrDefault();
        }

        public bool Update(UserMealFood food)
        {
            UserMealFood updatedPortion = context.UserMealFoods.SingleOrDefault(a => a.MealID == food.MealID && a.FoodID == food.FoodID);
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

        public List<Food> FoodsList(string filteredFood)
        {
            List<Food> foodsList = context.Foods.Where(f => f.Name.Contains(filteredFood)).ToList();

            return foodsList;
        }

        public bool Insert(UserMealFood userMealFood)
        {
            var date = userMealFood.CreatedDate.Date;
            var isExist = context.UserMealFoods
                              .Any(x => x.UserID == userMealFood.UserID &&
                                        x.FoodID == userMealFood.FoodID &&
                                        x.MealID == userMealFood.MealID &&
                                        DbFunctions.TruncateTime(x.CreatedDate) == date);

            if (isExist)
            {
                throw new Exception("Bu ürün daha önceden eklenmiştir. Miktarını değiştirmek isterseniz güncelleyiniz.");
            }

            context.UserMealFoods.Add(userMealFood);
            return context.SaveChanges() > 0;
        }


    }
}

