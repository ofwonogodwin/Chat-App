using ECommerceMessaging.Domain.Entities2;

namespace ECommerceMessaging.Domain.Interfaces
{
    public interface IMessageRepository
    {
        Task<Message> CreateMessageAsync(Message message);
        Task<IEnumerable<Message>> GetMessagesByChatRoomAsync(string chatRoomId, string? cursor = null, int limit = 20);
        Task<Message?> GetMessageByIdAsync(string messageId);
        Task MarkMessageAsReadAsync(string messageId);
        Task<int> GetUnreadCountAsync(string chatRoomId, string userId);
    }
}