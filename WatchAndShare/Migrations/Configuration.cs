namespace WatchAndShare.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WatchAndShare.DAL;
    using WatchAndShare.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WatchAndShare.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WatchAndShare.Models.ApplicationDbContext";
        }

        protected override void Seed(WatchAndShare.Models.ApplicationDbContext context)
        {
            //var dbInit = new DBIntilizer();
            var Category = new List<Category>
            {
                new Category{CatName="Action"},
                new Category{CatName="Adventure"},
                new Category{CatName="Comedy"},
                new Category{CatName="Fantasy"},
                new Category{CatName="Romance"}
            };
            Category.ForEach(cat => context.Category.Add(cat));
            context.SaveChanges();

            context.Category.Add(new Category { CatID = 4, CatName = "Ecchi" });
            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

        }
    }
}
