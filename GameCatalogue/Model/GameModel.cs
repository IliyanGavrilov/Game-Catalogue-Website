using GameCatalogue.EFCore;
using System.ComponentModel.DataAnnotations;

namespace GameCatalogue.Model
{
    public class GameModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public ICollection<Tag> Tags { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
        public ICollection<User> LikedBy { get; set; } = null!;

        public float AvgRating { get; set; }
    }
}
