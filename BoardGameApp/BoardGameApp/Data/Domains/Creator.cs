namespace BoardGameApp.Data.Domains
{
    public class Creator
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<BoardGame> BoardGames { get; set; } = new List<BoardGame>();
    }
}
