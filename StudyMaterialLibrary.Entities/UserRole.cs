using Microsoft.AspNetCore.Identity;
using StudyLibrary.Shared.Classifiers;

namespace StudyLibrary.Entities;

public class UserRole : IdentityUserRole<int>
{
    //public User User { get; set; }
    public RoleType Role { get; set; }
}
