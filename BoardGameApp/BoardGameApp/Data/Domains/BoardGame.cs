using System.ComponentModel.DataAnnotations;

namespace BoardGameApp.Data.Domains
{
    public class BoardGame
    {
        public int Id { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(20)]
        public string Name { get; set; } = null!;
        [Required]
        [Range(1, 10)]
        public double Rating { get; set; }
        [Required]
        public int YearPublished { get; set; }
        [Required]
        public string CategoryType { get; set; } = null!;
        public string Mechanics { get; set; } = null!;
        [Required]
        public int CreatorId { get; set; }
        public virtual Creator Creator { get; set; } = null!;
        public ICollection<BoardGamesSeller> BoardGamesSellers { get; set; } = new List<BoardGamesSeller>();

    }
}
