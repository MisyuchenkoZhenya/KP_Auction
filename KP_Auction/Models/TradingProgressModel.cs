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
        [Display(Name = "Deal")]
        public int Deal_Id { get; set; }

        [Required]
        [Display(Name = "Byer")]
        public int Byer_Id { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH.mm}", ApplyFormatInEditMode = true)]
        public DateTime StepTime { get; set; }

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "Please inter valid step rate")]
        public int StepRate { get; set; }

        [ForeignKey("Deal_Id")]
        public IEnumerable<DealModel> Deals { get; set; }
        [ForeignKey("Byer_Id")]
        public IEnumerable<ParticipantModel> Buyers { get; set; }
    }
}