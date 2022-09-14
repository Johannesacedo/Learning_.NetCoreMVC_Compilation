 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ValidationsDemo.Validations;

namespace ValidationsDemo.Models
{
    //model level validation
    [CityPostalCode]
    public class UserDetails
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(15,ErrorMessage ="Username cannot be more than 15 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Password required")]
        [StringLength(11,MinimumLength =5,ErrorMessage ="Minimum Length of password is 5 letters or Max length is of 11 letters")]
        [DataType("password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm new password")]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword",ErrorMessage ="The new password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Date of Birth is required")]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode =true)]
        public DateTime DateOfBirth { get; set; }
        
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Please enter valid email id")]
        public string  Email { get; set; }

        [Required(ErrorMessage ="Postal code is required")]
        [Range(100,1000,ErrorMessage ="Must be between 100 and 1000")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage ="Phone number is required")]
        [DisplayName("Phone Number")]
        public int PhoneNo { get; set; }

        [Required(ErrorMessage ="Profile is required")]
        [DataType(DataType.MultilineText)]
        public string Profile { get; set; }

        [FileExtensions(Extensions ="png,jpg,jpeg,gif")]
        public string Photo { get; set; }

        [Display(Name ="Additional Comments")]
        public string AdditionalComments { get; set; }

        [City]
        public string City { get; set; }
    }
}
