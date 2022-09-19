using Exercise1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exercise1.Data
{
    public class PetShopInitializer : DropCreateDatabaseAlways<PetShopContext>
    {
        protected override void Seed(PetShopContext context)
        {
            Animal dog = new Animal { Name = "Dog"};
            Animal cat = new Animal { Name = "Cat"};

            context.Animals.Add(dog);
            context.Animals.Add(cat);

            base.Seed(context);
        }
    }
}