using StudyLibrary.Shared.Models;

namespace StudyLibrary.Entities;

public class Subject : AuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<StudyMaterial> StudyMaterials { get; set; } = new List<StudyMaterial>();
}
