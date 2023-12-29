using StudyLibrary.Entities;

namespace StudyLibrary.DAL.Abstractions.Providers;

public interface IUserProvider
{
    public Task<User> GetUserAsync(int id);
}
