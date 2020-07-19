using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudDB.entities;
using StudDB.models;
using StudRepo.Interfaces;

namespace StudRepo.DbAccess
{
    public class StudentInterface : iStudentInterface
    {
        public StudentContext _Student { get; }
        public StudentInterface(StudentContext student)
        {
            this._Student = student;
        }

        public async Task<List<students>> GetStudents()
        {
            return await _Student.students.ToListAsync();
        }

        public async Task<students> GetStudent(int id)
        {
            return await _Student.students.FindAsync(id);
        }
    }
}