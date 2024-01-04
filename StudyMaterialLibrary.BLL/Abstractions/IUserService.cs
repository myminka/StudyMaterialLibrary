using StudyLibrary.Application.ViewModels.User;

namespace StudyLibrary.Application.Abstractions;

public interface IUserService
{
    /// <summary>
    /// Create a new user
    /// </summary>
    /// <param name="user">New user view model.</param>
    /// <returns>New user Id.</returns>
    public Task<int> AddUserAsync(AddUserViewModel user);

    /// <summary>
    /// Getting user by id.
    /// </summary>
    /// <param name="id">User id</param>
    /// <returns>User view model.</returns>
    public Task<UserDetailsViewModel> GetUserByIdAsync(int userId);

    /// <summary>
    /// Get users.
    /// </summary>
    /// <returns>Users.</returns>
    public Task<IEnumerable<UserViewModel>> GetUsersAsync();
}
