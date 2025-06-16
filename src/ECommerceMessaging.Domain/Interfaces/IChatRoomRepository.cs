using ECommerceMessaging.Domain.Entities2;

namespace ECommerceMessaging.Domain.Interfaces
{
    public interface IChatRoomRepository
    {
        Task<ChatRoom> CreateChatRoomAsync(ChatRoom chatRoom);
        Task<ChatRoom?> GetChatRoomByIdAsync(string chatRoomId);
        Task<ChatRoom?> GetChatRoomByUsersAsync(string retailerId, string manufacturerId);
        Task<IEnumerable<ChatRoom>> GetChatRoomsByUserIdAsync(string userId);
        Task UpdateLastMessageAsync(string chatRoomId, string messageId);
        Task UpdateUnreadCountAsync(string chatRoomId, int count);
    }
}