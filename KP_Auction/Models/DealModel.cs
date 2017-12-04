using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KP_Auction.Models
{
    public class DealModel
    {
        public int Id { get; set; }

        [Required]
        public int Buyer_Id { get; set; }

        [Required]
        public int Seller_Id { get; set; }

        [Required]
        public int Item_Id { get; set; }

        [Required]
        public int Auction_Id { get; set; }

        [Required]
        public int DealState_Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]
        public DateTime Time { get; set; }

        [Required]
        public int Price { get; set; }
    }
}