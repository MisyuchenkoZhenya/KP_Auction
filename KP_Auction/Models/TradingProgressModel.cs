using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KP_Auction.Models
{
    public class TradingProgressModel
    {
        public int Id { get; set; }

        public int Deal_Id { get; set; }

        public int Byer_Id { get; set; }

        public DateTime StepTime { get; set; }

        public decimal StepRate { get; set; }
    }
}