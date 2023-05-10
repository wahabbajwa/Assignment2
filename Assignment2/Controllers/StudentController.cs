using Assignment2.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly APIDbContext _context;

        public StudentController(APIDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            
            _context.StudentsRecord.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.StudentID }, student);
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.StudentsRecord.ToListAsync();
        }


    }
}
