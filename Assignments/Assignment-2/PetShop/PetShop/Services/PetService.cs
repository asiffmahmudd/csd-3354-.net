using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop.Services
{
    public class PetService
    {
        private ApplicationDbContext context;
        public PetService()
        {
            context = new ApplicationDbContext();
        }
        public PetService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool OldEnoughToAdopt(DateTime dateTime)
        {
            TimeSpan difference = DateTime.Now.Subtract(dateTime);
            if (difference.Days >= 365 * 18) return true;
            return false;
        }
    }
}