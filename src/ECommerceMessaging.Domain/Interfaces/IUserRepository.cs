using ECommerceMessaging.Domain.Entities2;

namespace ECommerceMessaging.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> CreateUserAsync(User user);
        Task<User?> GetUserByIdAsync(string userId);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task UpdateUserOnlineStatusAsync(string userId, bool isOnline);
        Task UpdateLastSeenAsync(string userId, DateTime lastSeen);
    }
}