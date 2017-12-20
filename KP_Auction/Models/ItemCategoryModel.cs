using System.ComponentModel.DataAnnotations;

namespace KP_Auction.Models
{
    public class ItemCategoryModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Length can not exceed 50 characters")]
        public string Category { get; set; }
    }
}