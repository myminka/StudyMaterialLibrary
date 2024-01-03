using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyLibrary.Entities;

namespace StudyLibrary.DataAccess.EntitiesConfigurations;

internal class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        throw new NotImplementedException();
    }
}
