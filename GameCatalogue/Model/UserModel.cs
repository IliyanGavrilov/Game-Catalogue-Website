using GameCatalogue.EFCore;
using System.ComponentModel.DataAnnotations;

namespace GameCatalogue.Model
{
    public class UserModel
    {
        public string Id { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        private string Password { get; set; } = string.Empty;

        public ICollection<Game> LikedGames { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
    }
}
