using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using UnitTestDemo.Models;
using UnitTestDemo.Services.DataAccess;

namespace UnitTestDemo.Services
{
    public class FixingService
    {
        public PetDataAccess petDA { get; set; }

        public FixingService () { }

        public FixingService(PetDataAccess newPetDA)
        {
            this.petDA = petDA;
        }

        public List<Pet> GetAllFixablePetsByUser(ApplicationUser user)
        {
            var petlist = petDA.GetAllOwnedPets(user);
            return petlist.Where(pet => pet.ifFixed == false).ToList();
        }

        public bool NeuterPet(Pet pet)
        {
            if (pet.isMale)
               pet.ifFixed = true;
            return pet.ifFixed;
        }
    }
}