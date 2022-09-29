using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStore.Models
{
    public class Department
    {
        public virtual int DepartmentId { get; set; }   //foreign key
        public virtual String Name { get; set; }
        public virtual int FarmerId { get; set; }
        public virtual List<Food> Foods { get; set; }

    }
}