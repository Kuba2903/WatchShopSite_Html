using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WatchShop.Models
{
    public class WatchOrder
    {

        [HiddenInput]
        public int Id { get; set; }


        [Display(Name = "Select a watch")]
        [Required(ErrorMessage = "You didn't select your watch")]
        public Watches Watch { get; set; }


        [Display(Name = "Enter your name")]
        [Required(ErrorMessage = "You didn't enter your name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",ErrorMessage ="Wrong name")]
        public string FirstName { get; set; }


        [Display(Name = "Enter your surname")]
        [Required(ErrorMessage = "You didn't enter your surname")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",ErrorMessage = "Wrong surname")]
        public string Surname { get; set; }
        
        
        [Display(Name = "Enter your city")]
        [Required(ErrorMessage = "You didn't enter your city")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",ErrorMessage ="Wrong city")]
        public string City { get; set; }


        [Display(Name = "Enter your street address")]
        [Required(ErrorMessage = "You didn't enter your street address")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string StreetAddress { get; set; }

        
        
        [Display(Name = "Enter your zip code")]
        [Required(ErrorMessage = "You didn't enter your zip code")]
        public string ZipCode { get; set; }

        [Display(Name = "Enter your phone number")]
        [Phone]
        public string Phone { get; set; }
    }
}
