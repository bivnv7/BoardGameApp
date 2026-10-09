namespace BoardGameApp.Data.Domains
{
    public class BoardGamesSeller
    {
        public int Id { get; set; }
        public int BoardGameId { get; set; }
        public virtual BoardGame BoardGame { get; set; } = null!;
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; } = null!;

    }
}
