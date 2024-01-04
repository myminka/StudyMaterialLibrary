using StudyLibrary.Application.Abstractions;
using StudyLibrary.DataAccess.Abstractions.Providers;
using StudyLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLibrary.Application.Services
{
    internal class SubjectService : ISubjectService
    {
        private readonly ISubjectProvider _provider;

        public SubjectService(ISubjectProvider provider)
        {
            _provider = provider;
        }

        public async Task AddSubjectAsync(Subject subject)
        {
            await _provider.AddSubjectAsync(subject);
        }

        public async Task DeleteSubjectAsync(int id)
        {
            await _provider.DeleteSubjectAsync(id);
        }

        public async Task<IEnumerable<Subject>> GetAllSubjectAsync()
        {
            return await _provider.GetAllSubjectAsync();
        }

        public async Task<Subject> GetSubjcetByIdAsync(int id)
        {
            return await _provider.GetSubjcetByIdAsync(id);
        }

        public async Task UpdateSubjectAsync(Subject subject)
        {
            await _provider.UpdateSubjectAsync(subject);
        }
    }
}
