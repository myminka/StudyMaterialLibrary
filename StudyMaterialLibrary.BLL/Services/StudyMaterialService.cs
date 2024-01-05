using StudyLibrary.Application.Abstractions;
using StudyLibrary.DataAccess.Abstractions.Providers;
using StudyLibrary.Entities;

namespace StudyLibrary.Application.Services
{
    public class StudyMaterialService : IStudyMaterialService
    {
        private readonly IStudyMaterialProvider _materialProvider;

        public StudyMaterialService(IStudyMaterialProvider materialProvider)
        {
            _materialProvider = materialProvider;
        }

        public async Task AddMaterialAsync(StudyMaterial material)
        {
            await _materialProvider.AddMaterialAsync(material);
        }

        public async Task DeleteMaterialAsync(int id)
        {
            await _materialProvider.DeleteMaterialAsync(id);
        }

        public async Task<IEnumerable<StudyMaterial>> GetAllMaterialsAsync()
        {
            return await _materialProvider.GetAllMaterialsAsync();
        }

        public async Task<StudyMaterial> GetMaterialByIdAsync(int id)
        {
            return await _materialProvider.GetMaterialByIdAsync(id);
        }

        public async Task<IEnumerable<StudyMaterial>> GetMaterialsBySubjectIdAsync(int subjectId)
        {
            return await _materialProvider.GetMaterialsBySubjectIdAsync(subjectId);
        }

        public async Task UpdateMaterialAsync(StudyMaterial material)
        {
            await _materialProvider.UpdateMaterialAsync(material);
        }
    }
}
