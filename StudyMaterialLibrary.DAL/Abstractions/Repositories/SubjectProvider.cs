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
    internal class SubjectProvider : ISubjectProvider
    {
        private readonly StudyContext _context;

        public SubjectProvider(StudyContext context)
        {
            _context = context;
        }

        public async Task AddSubjectAsync(Subject subject)
        {
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();            
        }

        public async Task DeleteSubjectAsync(int id)
        {
            var subject = await _context.Subjects.FindAsync(id);
            if (subject != null)
            {
                _context.Subjects.Remove(subject);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Subject>> GetAllSubjectAsync()
        {
            return await _context.Subjects.AsNoTracking().ToListAsync();            
        }

        public async Task<Subject> GetSubjcetByIdAsync(int id)
        {
            return await _context.Subjects.FindAsync(id);
        }

        public async Task UpdateSubjectAsync(Subject subject)
        {
            _context.Subjects.Update(subject);
            await _context.SaveChangesAsync();
        }
    }
}
