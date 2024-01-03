using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudyLibrary.DataAccess.EntitiesConfigurations;
using StudyLibrary.Entities;
using System.Data;
namespace StudyLibrary.DataAccess;

public class StudyContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
{
    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<StudyMaterial> StudyMaterials { get; set; }
    public DbSet<StydyFile> Files { get; set; }

    public StudyContext(DbContextOptions options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudyMaterialConfiguration).Assembly);
    }
}
