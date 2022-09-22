using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestDemo.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool isMale { get; set; }

        public bool ifFixed { get; set; }

        public ApplicationUser owner { get; set; }
    }
}