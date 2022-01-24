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

        //listview a seçilen food ları listelemek için kullanılan metot

        public List<SelectedFood> GetFood(int mealID, int userId, DateTime date)
        {
            //var date = DateTime.Now.Date;
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

        //Groupbox a o öğünün adını basmak için metot

        public string GetMealName(int mealID)
        {
            return context.Meals.Where(a => a.ID == mealID).Select(a => a.Name).SingleOrDefault(); 
        }

        public bool Update(UserMealFood food, DateTime date)
        {
            //var date = DateTime.Now.Date;

            UserMealFood updatedPortion = context.UserMealFoods.Where(x => x.UserID == food.UserID &&
                                                                     x.MealID == food.MealID &&
                                                                     x.FoodID == food.FoodID &&
                                                                     DbFunctions.TruncateTime(x.CreatedDate) == date)
                                                          .FirstOrDefault();
                                                          
            updatedPortion.Portion = food.Portion;
            return context.SaveChanges() > 0;
        }


        public bool Delete(UserMealFood food,DateTime date)
        {
            //var date = DateTime.Now.Date;
            UserMealFood deletedFood = context.UserMealFoods.Where(x => x.UserID == food.UserID &&
                                                                     x.MealID == food.MealID &&
                                                                     x.FoodID == food.FoodID &&
                                                                     DbFunctions.TruncateTime(x.CreatedDate) == date)
                                                          .FirstOrDefault();
            context.UserMealFoods.Remove(deletedFood);
            return context.SaveChanges() > 0;
        }
        //flow panel e basılan database de bulunan tüm food lar
        public List<Food> FoodsList()
        {
            List<Food> foodsList = context.Foods.ToList();

            return foodsList;
        }
        //flow panel e basılan database de bulunan filtrelenen(txtSearch) food lar
        public List<Food> FoodsList(string filteredFood)
        {
            List<Food> foodsList = context.Foods.Where(f => f.Name.Contains(filteredFood)).ToList();

            return foodsList;
        }
        //Kullanıcının eklediği ürünleri database deki ara tabloya gönderen metot
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

