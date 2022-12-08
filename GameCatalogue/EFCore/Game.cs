using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameCatalogue.EFCore
{
    [Table("game")]
    public class Game
    {
        [Key, Required]
        public string Id { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public ICollection<Tag> Tags { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
        public ICollection<User> LikedBy { get; set; } = null!;

        public float AvgRating { get; set; }

        //public Game(string Name, string Description, List<Tag> Tags, List<Review> Reviews, List<User> LikedBy)
        //{
        //    Name = Name;
        //    Description = Description;
        //    AvgRating = db.Reviews // ??????????????
        //                  .Where(r => r.GameId == Id)
        //                  .Average(r => r.RatingScore);
        //
        //    Tags = Tags;
        //    Reviews = Reviews;
        //    LikedBy = LikedBy;
        //}
    }
}
