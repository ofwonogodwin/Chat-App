namespace ECommerceMessaging.Domain.Entities2
{
    public class ChatRoom
    {
        public string Id { get; set; } = string.Empty;
        public string RetailerId { get; set; } = string.Empty;
        public string ManufacturerId { get; set; } = string.Empty;
        public int UnreadCount { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public User? Retailer { get; set; }
        public User? Manufacturer { get; set; }
        public List<Message> Messages { get; set; } = new();
        public Message? LastMessage { get; set; }
    }
}