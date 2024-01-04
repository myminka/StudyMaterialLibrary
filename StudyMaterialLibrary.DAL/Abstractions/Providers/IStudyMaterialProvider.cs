using StudyLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLibrary.DataAccess.Abstractions.Providers
{
    internal interface IStudyMaterialProvider
    {
        Task<StudyMaterial> GetMaterialByIdAsync(int id);
        Task<IEnumerable<StudyMaterial>> GetMaterialsBySubjectIdAsync(int subjectId);
        Task<IEnumerable<StudyMaterial>> GetAllMaterialsAsync();
        Task AddMaterialAsync(StudyMaterial material);
        Task UpdateMaterialAsync(StudyMaterial material);
        Task DeleteMaterialAsync(int id);
    }
}
