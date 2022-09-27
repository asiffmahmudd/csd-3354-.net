using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    /// <summary>
    /// New model represneting an Item with three properties, Default ID property for EF (Entity Framework)
    /// </summary>
    public class Item
    {

        public int ID { get; set; }
        public double Cost { get; set; }

        public string Name { get; set; }
    }
}