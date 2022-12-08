using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameCatalogue.EFCore
{
    [Table("tag")]
    public class Tag
    {
        [Key, Required]
        public string Id { get; set; } = string.Empty;
        [Required]
        public string Text { get; set; } = string.Empty;

        public ICollection<Game> Games { get; set; } = null!;

        //public Tag(string Text, ICollection<Game> Games)
        //{
        //    Text = Text;
        //    Games = Games;
        //}
    }
}
