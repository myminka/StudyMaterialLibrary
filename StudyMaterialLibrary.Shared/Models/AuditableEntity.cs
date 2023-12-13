using StudyMaterialLibrary.Shared.Abstractions;

namespace StudyMaterialLibrary.Shared.Models;

public class AuditableEntity : IAuditableEntity
{
    public DateTime UpdatedAt { get; set; }
    public int UpdatedById { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CreatedById { get; set; }
}
