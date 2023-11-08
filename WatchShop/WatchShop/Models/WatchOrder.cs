using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WatchShop.Models
{
    public class WatchOrder
    {
        public WatchOrder()
        {
            Brands_Models = new List<string>()
            {
                { "aa" },
                { "bb" }
            };
        }

        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Watch")]
        public List<string> Brands_Models { get; set; }
        //public decimal Price { get; set; }

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
