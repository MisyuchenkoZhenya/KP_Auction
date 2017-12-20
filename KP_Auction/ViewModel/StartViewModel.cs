using System.Collections.Generic;
using KP_Auction.Models;

namespace KP_Auction.ViewModel
{
    public class StartViewModel
    {
        public int currentByuer { get; set; }
        public IEnumerable<DealModel> deals { get; set; }
        public IEnumerable<ParticipantModel> participants { get; set; }
    }
}