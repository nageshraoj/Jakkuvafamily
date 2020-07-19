using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudDB.entities;
using StudDB.models;
using StudRepo.Interfaces;

namespace StudApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        public iStudentInterface _Student { get; }
        public StudentController(iStudentInterface student)
        {
            this._Student = student;
        }

        [HttpGet]
        public async Task<ActionResult<List<students>>> GetStudents()
        {
            return Ok(await _Student.GetStudents());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<students>> GetStudent(int id)
        {
            return Ok(await _Student.GetStudent(id));
        }
    }
}