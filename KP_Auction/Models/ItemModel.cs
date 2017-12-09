using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KP_Auction.Models
{
    public class ItemModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Category_Id { get; set; }

        [Required]
        public decimal StartedPrice { get; set; }

        [Required]
        public decimal PriceGrowth { get; set; }
    }
}