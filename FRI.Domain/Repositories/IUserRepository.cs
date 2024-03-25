using RFI.FRI.Api.Domain.Modal;
namespace RFI.FRI.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> AddUser(User user);
        Task<User> UpdateUser(User user);
        Task DeleteUser(int id);
    }
}
