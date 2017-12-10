using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KP_Auction.Models
{
    public class ItemModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(256, ErrorMessage = "Length can not exceed 256 characters")]
        public string Description { get; set; }

        [Display(Name = "Category")]
        public int Category_Id { get; set; }

        [Required]
        public decimal StartedPrice { get; set; }

        [Required]
        public decimal PriceGrowth { get; set; }
    }
}