using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KP_Auction.Models;

namespace KP_Auction.ViewModel
{
    public class StartViewModel
    {
        public IEnumerable<DealModel> deals { get; set; }
        public IEnumerable<ParticipantModel> participants { get; set; }
    }
}