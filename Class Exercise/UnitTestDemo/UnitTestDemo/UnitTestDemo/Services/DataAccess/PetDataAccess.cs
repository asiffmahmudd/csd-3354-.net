using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitTestDemo.Models;
using System.Data.Entity;

namespace UnitTestDemo.Services.DataAccess
{
    public class PetDataAccess
    {
        private ApplicationDbContext context;
        public PetDataAccess() { }

        public PetDataAccess (ApplicationDbContext context)
        {
            this.context = context;
        }

        public virtual List<Pet> GetAllOwnedPets(ApplicationUser user)
        {
            var petList = context.Pets.Include(x => x.owner)
                .Where(pet => pet.owner.Id == user.Id)
                .ToList();

            return petList;
        }

        public virtual void AddPet (Pet pet)
        {
            context.Pets.Add(pet);
            context.SaveChanges();
        }
    }
}