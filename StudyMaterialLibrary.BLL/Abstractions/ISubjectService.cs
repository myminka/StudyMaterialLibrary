using StudyLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLibrary.Application.Abstractions
{
    internal interface ISubjectService
    {
        Task<Subject> GetSubjcetByIdAsync(int id);
        Task<IEnumerable<Subject>> GetAllSubjectAsync();
        Task AddSubjectAsync(Subject subject);
        Task DeleteSubjectAsync(int id);
        Task UpdateSubjectAsync(Subject subject);
    }
}
