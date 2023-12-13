namespace StudyMaterialLibrary.Shared.Abstractions;

public interface IAuditableEntity : IPortalEntity
{
    public DateTime UpdatedAt { get; set; }
    public int UpdatedById { get; set; }
}
