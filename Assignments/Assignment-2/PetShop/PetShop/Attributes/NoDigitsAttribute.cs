using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetShop.Attributes
{
    public class NoDigitsAttribute : ValidationAttribute
    {
        public NoDigitsAttribute() : base("No numbers allowed!")
        {

        }
        public override bool IsValid(object value)
        {
            string str = Convert.ToString(value);
            foreach (char ch in str.ToCharArray())
            {
                if (ch >= '0' && ch <= '9') return false;
            }
            return true;
        }
    }
}