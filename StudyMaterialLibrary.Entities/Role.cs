using Microsoft.AspNetCore.Identity;

namespace StudyLibrary.Entities;

public class Role : IdentityRole<int>
{
    public Role()
    {
        UserRoles = new List<UserRole>();
    }

    public ICollection<UserRole> UserRoles { get; set; }
}