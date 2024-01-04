using Microsoft.EntityFrameworkCore;
using StudyLibrary.DataAccess.Abstractions.Providers;
using StudyLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLibrary.DataAccess.Abstractions.Repositories
{
    internal class StudyMaterialProvider : IStudyMaterialProvider
    {
        private readonly StudyContext _context;

        public StudyMaterialProvider(StudyContext context)
        {
            _context = context;
        }

        public async Task AddMaterialAsync(StudyMaterial material)
        {
            _context.StudyMaterials.Add(material);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMaterialAsync(int id)
        {
            var material = await _context.StudyMaterials.FirstOrDefaultAsync(x => x.Id == id);
            if(material != null)
            {
                _context.StudyMaterials.Remove(material);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<StudyMaterial>> GetAllMaterialsAsync()
        {
            return await _context.StudyMaterials.AsNoTracking().ToListAsync();
        }

        public async Task<StudyMaterial> GetMaterialByIdAsync(int id)
        {
            return await _context.StudyMaterials.FindAsync(id);
        }

        public async Task<IEnumerable<StudyMaterial>> GetMaterialsBySubjectIdAsync(int subjectId)
        {
            return await _context.StudyMaterials.Where(x => x.SubjectId == subjectId).ToListAsync();
        }

        public async Task UpdateMaterialAsync(StudyMaterial material)
        {
            _context.StudyMaterials.Add(material);
            await _context.SaveChangesAsync();            
        }
    }
}
