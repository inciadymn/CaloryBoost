using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.Model.Entities
{
    public class UserMealFood
    {
        public DateTime CreatedDate { get; set; }
        public double Portion { get; set; }

        public int UserID { get; set; }
        public int FoodID { get; set; }
        public int MealID { get; set; }

        public virtual User User { get; set; }
        public virtual Food Food { get; set; }
        public virtual Meal Meal { get; set; }
    }
}
