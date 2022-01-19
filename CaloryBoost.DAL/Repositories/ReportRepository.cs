using CaloryBoost.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.DAL.Repositories
{
    public class ReportRepository
    {
        CaloryBoostDbContext context;
        public ReportRepository()
        {
            context = new CaloryBoostDbContext();
        }

        public string GetFoodName(int userId, int mealId)
        {
            string foodName = context.Foods.Join(context.UserMealFoods,
                                                 food => food.ID,
                                                 x => x.FoodID,
                                                 (food, x) => new SelectedFood
                                                 {
                                                     MealId = x.MealID,
                                                     UserId = x.UserID,
                                                     FoodId = x.FoodID,
                                                     Amount=x.Portion,
                                                     FoodName = food.Name
                                                 })
                                                 .Where(a => a.MealId == mealId && a.UserId == userId)
                                                 .OrderByDescending(a => a.Amount).Take(1).Select(a=>a.FoodName).FirstOrDefault();

            return foodName;
        }

        public double GetWeeklyAverageCalory(int userId)
        {
            var dateNow = DateTime.Now.Date;
            var dateBack = DateTime.Now.Date.AddDays(-7);
            double weeklyAverageCalory = context.Foods.Join(context.UserMealFoods,
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
                                                 .Where(a => a.UserId != userId && DbFunctions.TruncateTime(a.DailyCalory) < dateNow && DbFunctions.TruncateTime(a.DailyCalory)> dateBack)
                                                 .Average(a => a.Calory);

            return weeklyAverageCalory;
        }

        public double GetMonthlyAverageCalory(int userId)
        {
            var dateNow = DateTime.Now.Date;
            var dateBack = DateTime.Now.Date.AddDays(-30);
            double monthlyAverageCalory = context.Foods.Join(context.UserMealFoods,
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
                                                 .Where(a => a.UserId != userId && DbFunctions.TruncateTime(a.DailyCalory) < dateNow && DbFunctions.TruncateTime(a.DailyCalory) > dateBack)
                                                 .Average(a => a.Calory);

            return monthlyAverageCalory;
        }

        public double GetWeeklyAverageCaloryByUser(int userId)
        {
            var dateNow = DateTime.Now.Date;
            var dateBack = DateTime.Now.Date.AddDays(-7);
            double weeklyAverageCalory = context.Foods.Join(context.UserMealFoods,
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
                                                 .Where(a => a.UserId == userId && DbFunctions.TruncateTime(a.DailyCalory) < dateNow && DbFunctions.TruncateTime(a.DailyCalory) > dateBack)
                                                 .Average(a => a.Calory);

            return weeklyAverageCalory;
        }

        public double GetMonthlyAverageCaloryByUser(int userId)
        {
            var dateNow = DateTime.Now.Date;
            var dateBack = DateTime.Now.Date.AddDays(-30);
            double monthlyAverageCalory = context.Foods.Join(context.UserMealFoods,
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
                                                 .Where(a => a.UserId == userId && DbFunctions.TruncateTime(a.DailyCalory) < dateNow && DbFunctions.TruncateTime(a.DailyCalory) > dateBack)
                                                 .Average(a => a.Calory);

            return monthlyAverageCalory;
        }

    }
}
