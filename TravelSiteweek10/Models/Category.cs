using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelSiteweek10.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Display (Name= "Accomodation Type")]
        public string AccomodationType { get; set; }

        [Display(Name = "Location name")]
        public string LocationName { get; set; }
        
        public virtual ICollection<User> Users { get; set; }
    }
}