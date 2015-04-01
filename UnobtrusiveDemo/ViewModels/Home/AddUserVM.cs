using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnobtrusiveDemo.ViewModels.Home
{
    public class AddUserVM
    {
        [DisplayName("First Name:")]
        [Required(ErrorMessage = "Please enter the first name.")]
        public string FirstName { get; set; }

        [DisplayName("Last Name:")]
        [Required(ErrorMessage = "Please enter the last name.")]
        public string LastName { get; set; }

        [DisplayName("Age:")]
        [Range(12,120, ErrorMessage = "You must be between 12 and 120 years of age.")]
        public int Age { get; set; }

        [DisplayName("Email:")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string EmailAddress { get; set; }
    }
}