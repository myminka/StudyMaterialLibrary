namespace StudyLibrary.Shared.Abstractions;

public interface IPortalEntity
{
    public DateTime CreatedAt { get; set; }
    public int CreatedById { get; set; }
}
