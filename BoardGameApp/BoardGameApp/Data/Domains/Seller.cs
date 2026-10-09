using System.ComponentModel.DataAnnotations;

namespace BoardGameApp.Data.Domains
{
    public class Seller
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; } = null!;
       
        [Required]
        public string Address { get; set; } = null!;
        public string Country { get; set; } = null!;
        [Required]
        
        public string Website { get; set; } = null!;
        public ICollection<BoardGamesSeller> BoardGamesSellers { get; set; } = new List<BoardGamesSeller>();
    }
}
