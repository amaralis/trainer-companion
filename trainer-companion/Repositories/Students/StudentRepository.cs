using Microsoft.EntityFrameworkCore;
using trainer_companion.Models;

namespace trainer_companion.Repositories.Students
{
    internal class StudentRepository
    {

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            // Implementation for fetching students
            using var ctx = new Database.AppDbContext();

            return await ctx.Students.ToListAsync();
        }
    }
}
