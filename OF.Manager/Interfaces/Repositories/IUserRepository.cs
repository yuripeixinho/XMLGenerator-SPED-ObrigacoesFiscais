using OF.Core.Domain;

namespace OF.Manager.Interfaces.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
}
