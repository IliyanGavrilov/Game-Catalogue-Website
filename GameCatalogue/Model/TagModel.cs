using GameCatalogue.EFCore;
using System.ComponentModel.DataAnnotations;

namespace GameCatalogue.Model
{
    public class TagModel
    {
        public string Id { get; set; } = string.Empty;
        [Required]
        public string Text { get; set; } = string.Empty;

        public ICollection<Game> Games { get; set; } = null!;
    }
}
