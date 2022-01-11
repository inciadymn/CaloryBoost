using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.Model.Entities
{
    public class Food
    {
        public Food()
        {
            UserMealFoods = new HashSet<UserMealFood>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Calory { get; set; }
        public string PhotoPath { get; set; }
        public string FoodTypes { get; set; }
        public string Description { get; set; }
        public decimal Portion { get; set; }
        public string PortionTypes { get; set; }

        public int FoodCategoryID { get; set; }

        public virtual FoodCategory FoodCategory { get; set; }
        public virtual ICollection<UserMealFood> UserMealFoods { get; set; }

    }
}
