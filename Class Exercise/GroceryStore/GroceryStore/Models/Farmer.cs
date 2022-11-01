using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStore.Models
{
    public class Farmer
    {
        public virtual int FarmerId { get; set; }   //foreign key
        public virtual String Name { get; set; }
    }
}