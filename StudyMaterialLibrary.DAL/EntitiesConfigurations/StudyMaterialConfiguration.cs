using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyLibrary.Entities;

namespace StudyLibrary.DataAccess.EntitiesConfigurations;

internal class StudyMaterialConfiguration : IEntityTypeConfiguration<StudyMaterial>
{
    public void Configure(EntityTypeBuilder<StudyMaterial> builder)
    {
        throw new NotImplementedException();
    }
}
