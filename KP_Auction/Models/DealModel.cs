using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KP_Auction.Models
{
    public class DealModel
    {
        [Key]
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
        [Range(0, double.MaxValue, ErrorMessage = "Please inter price from 0")]
        public decimal Price { get; set; }

        [ForeignKey("Buyer_Id")]
        public IEnumerable<ParticipantModel> Buyers { get; set; }
        [ForeignKey("Seller_Id")]
        public IEnumerable<ParticipantModel> Sellers { get; set; }
        [ForeignKey("Item_Id")]
        public IEnumerable<ItemModel> Items { get; set; }
        [ForeignKey("Auction_Id")]
        public IEnumerable<AuctionModel> Auctions { get; set; }
        [ForeignKey("DealState_Id")]
        public IEnumerable<DealStateModel> DealStates { get; set; }

    }
}