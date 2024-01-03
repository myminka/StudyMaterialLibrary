using StudyLibrary.DataAccess.Abstractions.Providers;
using StudyLibrary.Entities;

namespace StudyLibrary.DataAccess.Providers;

public class UserProvider : IUserProvider
{
    public UserProvider()
    {

    }

    public Task<User> GetUserAsync(int id)
    {
        throw new NotImplementedException();
    }
}
