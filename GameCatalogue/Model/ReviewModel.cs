using GameCatalogue.EFCore;
using System.ComponentModel.DataAnnotations;

namespace GameCatalogue.Model
{
    public class ReviewModel
    {
        public string Id { get; set; } = string.Empty;
        [Required]
        public User User { get; set; } = null!;
        // public virtual User User { get; set; }
        [Required]
        public string Text { get; set; } = string.Empty;
        [Required]
        public int RatingScore { get; set; }
        [Required]
        public Game Game { get; set; } = null!;
    }
}
