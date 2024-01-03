using StudyLibrary.Shared.Classifiers;
using StudyLibrary.Shared.Models;

namespace StudyLibrary.Entities;

public class StydyFile : AuditableEntity
{
    public Guid FileId { get; set; }
    public string Name { get; set; }
    public FileType FileType { get; set; }
    public long Size { get; set; }
    public byte[] Content { get; set; }
}
