using ECommerceMessaging.Domain.Enums;

namespace ECommerceMessaging.Domain.Entities2
{
    public class User
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public UserRole Role { get; set; }
        public bool IsOnline { get; set; }
        public DateTime? LastSeen { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}