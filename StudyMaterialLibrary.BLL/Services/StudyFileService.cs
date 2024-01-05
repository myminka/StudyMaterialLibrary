using StudyLibrary.Application.Abstractions;
using StudyLibrary.Application.ViewModels.StudyFile;

namespace StudyLibrary.Application.Services;

public class StudyFileService : IStudyFileService
{
    public StudyFileService()
    {

    }

    public Task AddFile(AddStudyFileViewModel studyFile)
    {
        throw new NotImplementedException();
    }

    public Task DeleteFile(Guid fileId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateFile(Guid fileId, AddStudyFileViewModel studyFile)
    {
        throw new NotImplementedException();
    }
}
