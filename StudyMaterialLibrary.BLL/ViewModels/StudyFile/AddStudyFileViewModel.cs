using StudyLibrary.Shared.Classifiers;

namespace StudyLibrary.Application.ViewModels.StudyFile;

public class AddStudyFileViewModel
{
    public string Name { get; set; }
    public FileType FileType { get; set; }
    public byte[] Content { get; set; }
}
