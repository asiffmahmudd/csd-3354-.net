using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetShopWk4Validation.Models
{
    public class Pet: IValidatableObject
    {
        public int ID { get; set; }
        [Required]
        [Display(Description = "is male:", Order = 2)]
        public bool isMale { get; set; }
        [Required]
        [Remote("CheckName", "Pets")]
        [Display(Order = 1)]
        public string Name { get; set; }
        [Required]

        [Display(Description = "is neutered:")]
        public bool isFixed { get; set; }
        [Required]
        //[IsPositive]
        public int Age { get; set; }

        public Pet() {}
        public Pet(bool isMale, string name, bool isFixed)
        {
            this.isMale = isMale;
            Name = name;
            this.isFixed = isFixed;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            if(this.Age < 0)
            {
                results.Add(new ValidationResult("Age is invalid", new List<String> {"Age"}));
            }
            if(!this.isMale && this.isFixed)
            {
                results.Add(new ValidationResult("Cjavasah ,h,an't have a fixed female", new List<String> { "isFixed", "isMale" }));
            }
            return results;
        }
    }
}