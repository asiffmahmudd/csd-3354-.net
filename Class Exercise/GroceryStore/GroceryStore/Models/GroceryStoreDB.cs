using System.Data.Entity;

namespace GroceryStore.Models
{
    public class GroceryStoreDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public GroceryStoreDB() : base("name=GroceryStoreDB")
        {
        }

        public System.Data.Entity.DbSet<GroceryStore.Models.Food> Foods { get; set; }

        public System.Data.Entity.DbSet<GroceryStore.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<GroceryStore.Models.Farmer> Farmers { get; set; }
    }
}
