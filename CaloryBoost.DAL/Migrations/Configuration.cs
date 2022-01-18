namespace CaloryBoost.DAL.Migrations
{
    using CaloryBoost.Model.Entities;
    using CaloryBoost.Model.Enums;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CaloryBoost.DAL.CaloryBoostDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CaloryBoost.DAL.CaloryBoostDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if (!context.FoodCategories.Any())
            {
                List<FoodCategory> foodCategories = new List<FoodCategory>()
                {
                   new FoodCategory()
                   {
                        Name = "Fruits",
                        Foods = new List<Food>()
                        {
                            new Food()
                            {
                                Name = "Apple",
                                Calory = 52.1,
                                Portion = 1,
                                PortionTypes = PortionType.piece.ToString(),
                                FoodTypes = FoodType.carbohydrate.ToString(),
                                Description = "100 gr (1 piece) apple 52.1 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_1.jpg"
                            },

                            new Food()
                            {
                                Name = "Strawberry",
                                Calory = 32.5,
                                Portion = 1,
                                PortionTypes = PortionType.piece.ToString(),
                                FoodTypes = FoodType.carbohydrate.ToString(),
                                Description = "100 gr (1 piece) strawberry 32.5 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_2.jpg"
                            },

                            new Food()
                            {
                                Name = "Banana",
                                Calory = 88.7,
                                Portion = 1,
                                PortionTypes = PortionType.piece.ToString(),
                                FoodTypes = FoodType.carbohydrate.ToString(),
                                Description = "100 gr (1 piece) banana 88.7 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_3.jpg"
                            }
                        }
                   },

                   new FoodCategory()
                   {
                        Name = "Vegetables",
                        Foods = new List<Food>()
                        {
                            new Food()
                            {
                                Name = "Cucumber",
                                Calory = 15.5,
                                Portion = 1,
                                PortionTypes = PortionType.piece.ToString(),
                                FoodTypes = FoodType.carbohydrate.ToString(),
                                Description = "100 gr (1 piece) cucumber 15.5 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_4.jpg"
                            },

                            new Food()
                            {
                                Name = "Lettuce",
                                Calory = 14.8,
                                Portion = 1,
                                PortionTypes = PortionType.piece.ToString(),
                                FoodTypes = FoodType.carbohydrate.ToString(),
                                Description = "100 gr (1 piece) lettuce 14.8 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_5.jpg"
                            },

                            new Food()
                            {
                                Name = "Broccoli",
                                Calory = 26,
                                Portion = 1,
                                PortionTypes = PortionType.piece.ToString(),
                                FoodTypes = FoodType.carbohydrate.ToString(),
                                Description = "100 gr (1 piece) broccoli 26 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_6.jpg"
                            }
                        }
                   },

                   new FoodCategory()
                   {
                        Name = "Beverages",
                        Foods = new List<Food>()
                        {
                            new Food()
                            {
                                Name = "Milk",
                                Calory = 128,
                                Portion = 1,
                                PortionTypes = PortionType.cup.ToString(),
                                FoodTypes = FoodType.carbohydrate.ToString(),
                                Description = "200 ml (1 cup) milk 128 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_7.jpg"
                            },

                            new Food()
                            {
                                Name = "Coke",
                                Calory = 122,
                                Portion = 1,
                                PortionTypes = PortionType.cup.ToString(),
                                FoodTypes = FoodType.carbohydrate.ToString(),
                                Description = "200 ml (1 cup) coke 122 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_8.jpg"
                            },

                            new Food()
                            {
                                Name = "Orange Juice",
                                Calory = 120,
                                Portion = 1,
                                PortionTypes = PortionType.cup.ToString(),
                                FoodTypes = FoodType.carbohydrate.ToString(),
                                Description = "200 ml (1 cup) orange juice 120 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_9.jpg"
                            }
                        }
                   },

                    new FoodCategory()
                   {
                        Name = "Main Courses",
                        Foods = new List<Food>()
                        {
                            new Food()
                            {
                                Name = "Green Beans",
                                Calory = 73,
                                Portion = 1,
                                PortionTypes = PortionType.portion.ToString(),
                                FoodTypes = FoodType.carbohydrate.ToString(),
                                Description = "150 gr (1 portion) green beans 128 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_10.jpg"
                            },

                            new Food()
                            {
                                Name = "Meatball",
                                Calory = 300,
                                Portion = 1,
                                PortionTypes = PortionType.portion.ToString(),
                                FoodTypes = FoodType.protein.ToString(),
                                Description = "150 gr (1 portion) meatball 300 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_11.jpg"
                            },

                            new Food()
                            {
                                Name = "Chicken saute",
                                Calory = 254,
                                Portion = 1,
                                PortionTypes = PortionType.portion.ToString(),
                                FoodTypes = FoodType.protein.ToString(),
                                Description =  "150 gr (1 portion) chicken saute 254 kcal",
                                PhotoPath = @"..\..\Ýmages\FoodImages\food_12.jpg"
                            },
                        }
                   }
                };

                List<Meal> meals = new List<Meal>()
                {
                   new Meal()
                   {
                        Name="Breakfast"
                   },

                   new Meal()
                   {
                        Name="Lunch"
                   },

                    new Meal()
                   {
                        Name="Dinner"
                   },

                     new Meal()
                   {
                        Name="Snack"
                   }
                };

                context.FoodCategories.AddRange(foodCategories);

                context.Meals.AddRange(meals);

                context.SaveChanges();
            }
        }
    }
}
