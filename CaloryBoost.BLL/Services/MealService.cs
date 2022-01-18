using CaloryBoost.DAL.Repositories;
using CaloryBoost.Model;
using CaloryBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.BLL.Services
{
    public class MealService
    {
        MealRepository mealRepository;
        public MealService()
        {
            mealRepository = new MealRepository();
        }

        public List<SelectedFood> GetFood(int mealID,int userID)
        {
            List<SelectedFood> selecedFoods = new List<SelectedFood>();
            if (mealID > 0)
            {
                selecedFoods = mealRepository.GetFood(mealID,userID);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
            return selecedFoods;
        }

        public bool Update(UserMealFood food)
        {
            if (food.UserID == 0 || food.MealID == 0)
            {
                throw new Exception("Food güncellenirken ID bilgisi mutlaka atanmalıdır");
            }
            return mealRepository.Update(food);
        }

        public bool Delete(int foodId)
        {
            if (foodId<1)
            {
                throw new Exception("Parametre değeri uygun değil");
            }

            return mealRepository.Delete(foodId);
        }

        public List<Food> FoodsList()
        {
            return mealRepository.FoodsList();
        }

        public List<Food> FoodsList(string filteredFood)
        {
            return mealRepository.FoodsList(filteredFood);
        }

        public bool Insert(UserMealFood userMealFood)
        {
            userMealFood.CreatedDate = DateTime.Now.Date;
            return mealRepository.Insert(userMealFood);
        }
        public string GetMealName(int mealID)
        {
            if (mealID< 1)
            {
                throw new Exception("Parametre değeri uygun değil");
            }
            return mealRepository.GetMealName(mealID);
        }


    }
}

