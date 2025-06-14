using OF.Core.Shared.ModelViews.User;

namespace OF.Manager.Interfaces.Manager;

public interface IUserManager
{
    Task<IEnumerable<UserDTO>> GetUsersAsync();
}
