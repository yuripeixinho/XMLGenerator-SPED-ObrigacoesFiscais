using Microsoft.EntityFrameworkCore;
using OF.Core.Domain;
using OF.Data.Context;
using OF.Manager.Interfaces.Repositories;

namespace OF.Data.Repository;

public class UserRepository : IUserRepository
{
    private readonly OFContext _context;    

    public UserRepository(OFContext context)
    {
        _context = context; 
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        var users = await _context.Users.ToListAsync();

        return users;
    }
}
