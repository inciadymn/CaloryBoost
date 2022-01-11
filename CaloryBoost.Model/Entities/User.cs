using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.Model.Entities
{
    public class User
    {
        public User()
        {
            UserMealFoods = new HashSet<UserMealFood>();
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Phone { get; set; }
        public string PhotoPath { get; set; }

        public virtual ICollection<UserMealFood> UserMealFoods { get; set; }
    }
}
