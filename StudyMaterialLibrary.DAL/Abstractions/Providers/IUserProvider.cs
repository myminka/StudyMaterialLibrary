using StudyLibrary.Entities;

namespace StudyLibrary.DataAccess.Abstractions.Providers;

public interface IUserProvider
{
    public Task<User> GetUserAsync(int id);
}
