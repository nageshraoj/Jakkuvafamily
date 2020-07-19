using System.Collections.Generic;
using System.Threading.Tasks;
using StudDB.models;

namespace StudRepo.Interfaces
{
    public interface iStudentInterface
    {
         Task<List<students>> GetStudents();

         Task<students> GetStudent(int id);
    }
}