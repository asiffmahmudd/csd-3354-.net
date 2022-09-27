using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Our manual inputs
using System.Data.Entity;
using PetStore.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PetStore.Data
{
    public class DataInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        /// <summary>
        /// Create a new role and user object and add them to the database
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(ApplicationDbContext context)
        {

            RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>(context);
            RoleManager<IdentityRole> roleMgr = new RoleManager<IdentityRole>(roleStore);
            IdentityRole role = new IdentityRole { Name = "Admin" };

            roleMgr.Create(role);

            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userMgr = new UserManager<ApplicationUser>(userStore);

            ApplicationUser user = new ApplicationUser { UserName = "test", Email = "test@test.com" };

            userMgr.Create(user, "test1234");
            userMgr.AddToRole(user.Id, "Admin");

            base.Seed(context);
        }
    }
}