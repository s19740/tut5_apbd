using System.Collections.Generic;
using Task3.Models;
using task5_sol.Controllers;
using task5_sol.Models;

namespace task5_sol.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
        public List<string> GetSemesterEntries(string studentId);
        public IEnumerable<Student> GetStudents(Enrollment request);
        ERequest ERequest(ERequest request);
    }
}