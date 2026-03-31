using Microsoft.AspNetCore.Mvc;
using StudCrud.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudController : ControllerBase
    {
        private readonly StudentDbContext _context;
        public StudController( StudentDbContext context)
        {
              _context = context;
        }
        [HttpGet]
        public IActionResult GetAllStudent()
        {
            var students = _context.Students.ToList();
            return Ok(students);
        }
         [HttpPost]
         public IActionResult AddStudent(Student student)
        { 
             _context.Students.Add(student);
             _context.SaveChanges();
             return Ok(student);
        }
        [HttpPut]
        public IActionResult EditStudent(Student student) 
        { 
           var stud = _context.Students.Find(student.studentId);
            if (stud == null)
            {
                return NotFound();
            } 
            stud.studentId = student.studentId;
            stud.studName = student.studName;
            stud.mobileNo = student.mobileNo;
            stud.email = student.email;
            stud.city = student.city;
            stud.state = student.state;
            stud.pincode = student.pincode;
            stud.addressLine1 = student.addressLine1;
            stud.addressLine2 = student.addressLine2;
            _context.Students.Update(stud);
            _context.SaveChanges();
            return Ok(stud);
        }
         [HttpDelete("{id}")]
         public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            _context.Students.Remove(student);
            _context.SaveChanges();
            return Ok(student);
        }
    }
}
