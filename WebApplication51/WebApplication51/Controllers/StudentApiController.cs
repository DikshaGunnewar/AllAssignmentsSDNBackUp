using AutoMapper;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using WebApplication51.Dtos;
using WebApplication51.Models;

namespace WebApplication51.Controllers
{
    public class StudentApiController : ApiController
    {
        private Context  _context;

        public StudentApiController()
        {
            _context = new Context();
        }

        // GET /api/customers
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = _context.students
                .Include(c => c.studentdetails);

            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.FirstName.Contains(query));

            var customerDtos = customersQuery
                .ToList()
                .Select(Mapper.Map<Student, StudentDto>);

            return Ok(customerDtos);
        }

        // GET /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var stud = _context.students.SingleOrDefault(c => c.Id == id);

            if (stud == null)
                return NotFound();

            return Ok(Mapper.Map<Student, StudentDto>(stud));
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var student = Mapper.Map<StudentDto, Student>(studentDto);
            _context.students.Add(student);
            _context.SaveChanges();

            studentDto.Id = student.Id;
            return Created(new Uri(Request.RequestUri + "/" + student.Id), studentDto);
        }

        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var studentInDb = _context.students.SingleOrDefault(c => c.Id == id);

            if (studentInDb == null)
                return NotFound();

            Mapper.Map(studentDto, studentInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var studentInDb = _context.students.SingleOrDefault(c => c.Id == id);

            if (studentInDb == null)
                return NotFound();

            _context.students.Remove(studentInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
