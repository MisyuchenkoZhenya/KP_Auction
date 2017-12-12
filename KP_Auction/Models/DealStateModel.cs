﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KP_Auction.Models
{
    public class DealStateModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Length can not exceed 20 characters")]
        public string State { get; set; }
    }
}