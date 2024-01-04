using Microsoft.AspNetCore.Identity;
using StudyLibrary.Shared.Abstractions;

namespace StudyLibrary.Entities;

public class User : IdentityUser<int>, IAuditableEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirthday { get; set; }
    //public ICollection<UserRole> Roles { get; set; }
    public ICollection<StudyMaterial> StudyMaterials { get; set; }
    public byte[] Photo { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int UpdatedById { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CreatedById { get; set; }
}
