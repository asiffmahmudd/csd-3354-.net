using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetShop.Models
{
    public class DataInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            //initialize Role Store and Role manager for creating a new "Admin" Role
            RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>(context);
            RoleManager<IdentityRole> roleMgr = new RoleManager<IdentityRole>(roleStore);

            var role = new IdentityRole { Name = "Admin" };
            roleMgr.Create(role);

            //initialize userStore and userManager for creating a new user and assigning to the "Admin
            //Role
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userMgr = new UserManager<ApplicationUser>(userStore);

            //creating a new user
            ApplicationUser user = new ApplicationUser{UserName = "test@test.com", Email = "test@test.com", DateofBirth = new DateTime(2000, 01, 01)};

            //creating a pet which is the pet of the "user"
            Pet pet1 = new Pet { Name = "Fenris", IsMale = true, Breed = "Asgardian", Owner = user };
            //creating a pet without owner
            Pet pet2 = new Pet { Name = "Cerberus", IsMale = true, Breed = "Hellsing" };

            //adding user to the role manager
            userMgr.Create(user, "test1234");
            //adding user as an admin
            userMgr.AddToRole(user.Id, "Admin");

            //adding pet1 and pet2 to the context
            context.Pets.Add(pet1);
            context.Pets.Add(pet2);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}