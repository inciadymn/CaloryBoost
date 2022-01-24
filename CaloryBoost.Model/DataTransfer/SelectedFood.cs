using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.Model
{
    public class SelectedFood
    {
        //Bu sınıfa form tarafında ihtiyaç duyuldu. DAL katmanı UI tarafına(Meal.cs) referans verilemediğinden, datayı transfer etmek için model katmanında class oluşturuldu.

        public string FoodName { get; set; }
        public double Amount { get; set; }
        public double Calory { get; set; }
        public int MealId { get; set; }
        public int UserId { get; set; }
        public DateTime DailyCalory { get; set; }
        public int FoodId { get; set; }
        
    }
}
