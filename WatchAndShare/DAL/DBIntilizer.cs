using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WatchAndShare.Models;

namespace WatchAndShare.DAL
{
    public class DBIntilizer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        public DBIntilizer()
        {

        }
        public void Seed(ApplicationDbContext context)
        {
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

            context.Category.Add(new Category { CatID=4, CatName="Ecchi"});
            base.Seed(context);
        }
    }
}