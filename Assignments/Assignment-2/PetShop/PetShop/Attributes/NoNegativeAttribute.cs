using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetShop.Attributes
{
    public class NonNegativeAttribute : ValidationAttribute
    {
        public NonNegativeAttribute() : base("Number cannot be negative")
        {
        }
        public override bool IsValid(object value)
        {
            try
            {
                int val = Convert.ToInt32(value);
                return val >= 0;
            }
            catch
            {
                return false;
            }
        }
    }
}