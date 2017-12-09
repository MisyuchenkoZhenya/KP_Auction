using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KP_Auction.Models
{
    public class ItemCategoryModel
    {
        public int Id { get; set; }

        [Required]
        public string Category { get; set; }
    }
}