using StudyLibrary.Shared.Models;

namespace StudyLibrary.Entities;

public class StudyMaterial : AuditableEntity
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public bool IsReviewed { get; set; }
    public ICollection<User> Authors { get; set; }
    public Subject Subject { get; set; }
    public int SubjectId { get; set; }
    public StydyFile File { get; set; }
}
