using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStore.Data
{
    public class DataInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>(context);
            RoleManager<IdentityRole> roleMngr = new RoleManager<IdentityRole>(roleStore);
            IdentityRole role = new IdentityRole { Name = "Admin" };

            roleMngr.Create(role);

            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userMngr = new UserManager<ApplicationUser>(userStore);

            ApplicationUser user = new ApplicationUser { UserName = "test@test.com", Email = "test@test.com", DateofBirth = new DateTime(2000, 01, 01) };

            Pet pet1 = new Pet { Name = "Fenris", IsMale = true, Breed = "Asgardian", Owner = user };
            Pet pet2 = new Pet { Name = "Cerberus", IsMale = true, Breed = "Hellsing" };

            userMngr.Create(user, "1234");
            userMngr.AddToRole(user.Id, "Admin");

            //context.Users.Add(user);
            context.Pets.Add(pet1);
            context.Pets.Add(pet2);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}