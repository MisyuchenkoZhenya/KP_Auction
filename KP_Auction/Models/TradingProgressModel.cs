using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KP_Auction.Models
{
    public class TradingProgressModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Deal_Id { get; set; }

        [Required]
        public int Byer_Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]
        public DateTime StepTime { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please inter valid step rate")]
        public decimal StepRate { get; set; }

        [ForeignKey("Deal_Id")]
        public IEnumerable<DealModel> Deals { get; set; }
        [ForeignKey("Byer_Id")]
        public IEnumerable<ParticipantModel> Buyers { get; set; }
    }
}