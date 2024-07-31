namespace AuctionService.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
        public int Price { get; set; } = 0;

        public int AuctionId { get; set; }
        public string Seller { get; set; }
        public string Buyer { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int CurrentPrice { get; set; } = 0;

        public

    }
}
