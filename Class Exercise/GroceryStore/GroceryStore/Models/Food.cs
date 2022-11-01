using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStore.Models
{
    public class Food
    {
        public virtual int FoodId { get; set; }
        public virtual int DepartmentId { get; set; }
        public virtual int FarmerId { get; set; }
        public virtual String Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual String FoodImageURl { get; set; }
        public virtual Department Department { get; set; }
        public virtual Farmer Farmer { get; set; }

    }
}