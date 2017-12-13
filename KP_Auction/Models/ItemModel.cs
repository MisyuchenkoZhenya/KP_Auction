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
        [StringLength(50, ErrorMessage = "Length can not exceed 50 characters")]
        public string Name { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Length can not exceed 256 characters")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int Category_Id { get; set; }

        [Required]
        public decimal StartedPrice { get; set; }

        [Required]
        public decimal PriceGrowth { get; set; }

        [ForeignKey("Category_Id")]
        public IEnumerable<ItemCategoryModel> ItemCategories { get; set; }
    }
}