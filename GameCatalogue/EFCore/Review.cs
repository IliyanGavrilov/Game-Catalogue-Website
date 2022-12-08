using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameCatalogue.EFCore
{
    [Table("review")]
    public class Review
    {
        [Key, Required]
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

        //public Review(string Text, User User, int RatingScore, Game Game)
        //{
        //    Text = Text;
        //    User = User;
        //    RatingScore = RatingScore;
        //    Game = Game;
        //}
    }
}
