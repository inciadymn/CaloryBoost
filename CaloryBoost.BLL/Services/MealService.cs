using CaloryBoost.DAL.Repositories;
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

        public List<SelecedFood> GetFood(int mealID)
        {
            List<SelecedFood> selecedFoods = new List<SelecedFood>();
            if (mealID > 0)
            {
                selecedFoods = mealRepository.GetFood(mealID);
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

        public bool Delete(UserMealFood food)
        {
            if (food.UserID == 0 || food.MealID == 0)
            {
                throw new Exception("Parametre değeri uygun değil");
            }

            return mealRepository.Delete(food);
        }
    }
}

