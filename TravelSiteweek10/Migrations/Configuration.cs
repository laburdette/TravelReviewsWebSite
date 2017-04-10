namespace TravelSiteweek10.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TravelSiteweek10.Models.TravelSiteweek10Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(TravelSiteweek10.Models.TravelSiteweek10Context context)
        {
          


            context.Categories.AddOrUpdate(x => x.CategoryID,
               new Models.Category() { CategoryID = 1, AccomodationType = "Hotel", LocationName = "Aruba" },
               new Models.Category() { CategoryID = 2, AccomodationType = "Hotel", LocationName = "Detroit" },
               new Models.Category() { CategoryID = 3, AccomodationType = "Bed and Breakfast", LocationName = "Pokono" },
               new Models.Category() { CategoryID = 4, AccomodationType = "Cabin", LocationName = "Denver" }
               );



            context.Users.AddOrUpdate(x => x.UserID,
              new Models.User() { UserID = 1, UserName = "Jennifer", TookChildren = true, CategoryID = 1 },
              new Models.User() { UserID = 2, UserName = "Ashley", TookChildren = false, CategoryID = 2 },
              new Models.User() { UserID = 3, UserName = "John", TookChildren = true, CategoryID = 3 },
              new Models.User() { UserID = 4, UserName = "Bill", TookChildren = true, CategoryID = 4 }
              );

        }
    }
}
