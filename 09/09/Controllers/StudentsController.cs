
using AutoMapper;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using _09.Dto;
using _09.Models;

namespace _09.Controllers
{
    public class StudentsController : ApiController
    {
      
        private StudentContext1 context;

        public StudentsController()
        {
            context = new StudentContext1();
        }

        #region--JqGrid--

        #endregion

        //main

         #region--Get All students--
          // GET /api/customers

         public IHttpActionResult GetStudents(string query = null)
          {
              var Query = context.Students.Include(c => c.studentdetails);

              if (!String.IsNullOrWhiteSpace(query))
                  Query = Query.Where(c => c.FirstName.Contains(query));

              var customerDtos = Query
                  .ToList()
                  .Select(Mapper.Map<Student1, StudentDto>);

              return Ok(customerDtos);
          }
          #endregion

   

        #region--Get student by id--
        // GET /api/customers/1
        public IHttpActionResult GetStudents(int id)
        {
            var stud = context.Students.SingleOrDefault(c => c.Id == id);

            if (stud == null)
                return NotFound();

            return Ok(Mapper.Map<Student1, StudentDto>(stud));
        }
        #endregion

        /* #region--add Customer--
           // POST /api/Students
           [HttpPost]
           public IHttpActionResult CreateStudents(StudentDto studentDto)
           {
               if (!ModelState.IsValid)
                   return BadRequest();

               var student = Mapper.Map<StudentDto, Student1>(studentDto);
               context.Students.Add(student);
               context.SaveChanges();

               studentDto.Id = student.Id;
               return Created(new Uri(Request.RequestUri + "/" + student.Id), studentDto);
           }

           #endregion */

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateStudent(StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var student = Mapper.Map<StudentDto, Student1>(studentDto);
            context.Students.Add(student);
            context.SaveChanges();

            studentDto.Id = student.Id;
            return Created(new Uri(Request.RequestUri + "/" + student.Id), studentDto);
        }

       /* [HttpPost]
        public IHttpActionResult PostPersonalDetails([FromBody] Student1 student1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           context.Students.Add(student1);
            context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = student1.Id }, student1);
        }*/




        #region--Update--
        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var studentInDb = context.Students.SingleOrDefault(c => c.Id == id);

            if (studentInDb == null)
                return NotFound();

            Mapper.Map(studentDto, studentInDb);

            context.SaveChanges();

            return Ok();
        }
        #endregion


        #region--Delete--
        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var studentInDb = context.Students.SingleOrDefault(c => c.Id == id);

            if (studentInDb == null)
                return NotFound();

            context.Students.Remove(studentInDb);
            context.SaveChanges();

            return Ok();
        }

        #endregion
        
    }
}
