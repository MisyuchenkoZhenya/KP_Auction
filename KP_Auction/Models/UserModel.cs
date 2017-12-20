using System.ComponentModel.DataAnnotations;

namespace KP_Auction.Models
{
    public class UserModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }
    }
}