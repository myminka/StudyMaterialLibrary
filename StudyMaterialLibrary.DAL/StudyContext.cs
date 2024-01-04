using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudyLibrary.DataAccess.EntitiesConfigurations;
using StudyLibrary.Entities;

namespace StudyLibrary.DataAccess;

public class StudyContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
{
    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<StudyMaterial> StudyMaterials { get; set; }
    public DbSet<StudyFile> Files { get; set; }

    public StudyContext(DbContextOptions options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudyMaterialConfiguration).Assembly);
    }
}
