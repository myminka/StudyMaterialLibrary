using StudyLibrary.Application.Abstractions;
using StudyLibrary.Application.ViewModels.User;
using StudyLibrary.DataAccess.Abstractions.Providers;

namespace StudyLibrary.Application.Services;

public class UserService : IUserService
{
    private readonly IUserProvider _userProvider;

    public UserService(IUserProvider userProvider)
    {
        _userProvider = userProvider;
    }

    public Task<int> AddUserAsync(AddUserViewModel user)
    {
        throw new NotImplementedException();
    }

    public Task<UserDetailsViewModel> GetUserByIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserViewModel>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }
}
