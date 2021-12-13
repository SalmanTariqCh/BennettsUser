using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserAPP.Models
{
    public class User
    {

        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [StringLength(maximumLength: 20, ErrorMessage = "First name cannot be greater than 20 characters")]
        [RegularExpression("^[%)(_&?/|, @.A-Za-z0-9]*$", ErrorMessage = "The characters '-', '[', ']', '*', '!' are not allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        [StringLength(maximumLength: 20, ErrorMessage = "Last name cannot be greater than 20 characters")]
        [RegularExpression("^[%)(_&?/|, @.A-Za-z0-9]*$", ErrorMessage = "The characters '-', '[', ']', '*', '!' are not allowed")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DOBDateValidation]
        [Display(Name = "Date of Birth")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-mm-dd}")]
        public DateTime DOB { get; set; }
    }
}