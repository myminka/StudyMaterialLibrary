using StudyLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLibrary.Application.Abstractions
{
    public interface ISubjectService
    {
        Task<Subject> GetSubjectByIdAsync(int id);
        Task<IEnumerable<Subject>> GetAllSubjectAsync();
        Task AddSubjectAsync(Subject subject);
        Task DeleteSubjectAsync(int id);
        Task UpdateSubjectAsync(Subject subject);
    }
}
