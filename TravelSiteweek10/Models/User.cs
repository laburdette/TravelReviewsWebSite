using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelSiteweek10.Models
{
    public class User
    {
        [Key]

        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }
        
        [Display(Name ="Took children")]
        public bool TookChildren { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}