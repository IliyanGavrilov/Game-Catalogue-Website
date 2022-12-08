using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameCatalogue.EFCore
{
    [Table("user")]
    public class User : IdentityUser
    {
        [Key, Required]
        public override string Id { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public override string Email { get; set; } = string.Empty;
        [Required]
        private string Password { get; set; } = string.Empty;

        public ICollection<Game> LikedGames { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;

        //public User(string Name, string Email, string Password, ICollection<Game> LikedGames, ICollection<Review> Reviews)
        //{
        //    Name = Name;
        //    Email = Email;
        //    Password = Password;
        //    LikedGames = LikedGames;
        //    Reviews = Reviews
        //}
    }
}
