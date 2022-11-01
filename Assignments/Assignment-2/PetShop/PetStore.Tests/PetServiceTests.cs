using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Services;
using PetShop.Models;

namespace PetStore.Tests
{
    [TestClass]
    public class PetServiceTests
    {
        public void OldEnoughToAdopt_Positive()
        {
            PetService petService = new PetService(new ApplicationDbContext());
            DateTime oldEnough = DateTime.Now.AddYears(-18);
            bool expected = true;
            bool actual = petService.OldEnoughToAdopt(oldEnough);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OldEnoughToAdopt_Negative()
        {
            PetService petService = new PetService(new ApplicationDbContext());
            DateTime notOld = DateTime.Now.AddYears(-4);
            bool expected = false;
            bool actual = petService.OldEnoughToAdopt(notOld);
            Assert.AreEqual(expected, actual);
        }
    }
}
