using StudyLibrary.Application.ViewModels.StudyFile;

namespace StudyLibrary.Application.Abstractions;

public interface IStudyFileService
{
    public Task AddFile(AddStudyFileViewModel studyFile);
    public Task DeleteFile(Guid fileId);
    public Task UpdateFile(Guid fileId, AddStudyFileViewModel studyFile);
}
