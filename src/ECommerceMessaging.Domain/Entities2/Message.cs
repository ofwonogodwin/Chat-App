using ECommerceMessaging.Domain.Enums;

namespace ECommerceMessaging.Domain.Entities2
{
    public class Message
    {
        public string Id { get; set; } = string.Empty;
        public string SenderId { get; set; } = string.Empty;
        public string SenderName { get; set; } = string.Empty;
        public UserRole SenderRole { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public bool IsRead { get; set; } = false;
        public string ChatRoomId { get; set; } = string.Empty;
        
        // Navigation properties
        public User? Sender { get; set; }
        public ChatRoom? ChatRoom { get; set; }
    }
}