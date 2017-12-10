using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KP_Auction.Models
{
    public class ItemCategoryModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(32, ErrorMessage = "Length can not exceed 32 characters")]
        public string Category { get; set; }
    }
}