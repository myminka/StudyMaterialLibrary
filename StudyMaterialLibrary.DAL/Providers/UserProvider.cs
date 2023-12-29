using StudyLibrary.DAL.Abstractions.Providers;
using StudyLibrary.Entities;

namespace StudyLibrary.DAL.Providers;

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
