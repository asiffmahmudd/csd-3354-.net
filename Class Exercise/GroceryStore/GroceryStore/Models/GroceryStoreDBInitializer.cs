using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStore.Models
{
    public class GroceryStoreDBInitializer : System.Data.Entity.DropCreateDatabaseAlways<GroceryStoreDB>
    {
        protected override void Seed(GroceryStoreDB context)
        {
            // add a new farmer to the db
            context.Farmers.Add(new Farmer { Name = "Dickenson farms" });
            
            // add a new department to the db
            context.Departments.Add(new Department { Name = "Butcher" });

            //add eggs + dept + supplier to the db
            context.Foods.Add(new Food
            {
                Name = "Large Eggs",
                Price = 3.75m,
                Farmer = new Farmer { Name = "Noppend Poultry"},
                Department = new Department { Name = "Dairy"}
            });

            base.Seed(context);
        }
    }
}