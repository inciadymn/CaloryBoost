using CaloryBoost.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.Model.Entities
{
    public class Meal
    {
        public Meal()
        {
            UserMealFoods = new HashSet<UserMealFood>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserMealFood> UserMealFoods { get; set; }
    }
}
