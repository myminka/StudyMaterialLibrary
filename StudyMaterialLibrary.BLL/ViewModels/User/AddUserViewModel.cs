namespace StudyLibrary.Application.ViewModels.User;

public class AddUserViewModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte[] Photo { get; set; }
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
}
