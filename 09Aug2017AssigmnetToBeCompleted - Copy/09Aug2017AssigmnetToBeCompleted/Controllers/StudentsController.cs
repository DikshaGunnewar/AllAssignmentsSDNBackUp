using _09Aug2017AssigmnetToBeCompleted.Dto;
using _09Aug2017AssigmnetToBeCompleted.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace _09Aug2017AssigmnetToBeCompleted.Controllers
{
    public class StudentsController : ApiController
    {
        private StudentContext2 context;

        //MemberController Constructor
        public StudentsController()
        {
            context = new StudentContext2();
        }

        /*  #region--Get all Elemens by using StudentDto---
           //Get All Elements From mapping with memberDTo rather than domain model
           public IEnumerable<StudentDto> GetMembers()
           {
               return context.Students.ToList().Select(Mapper.Map<Student2, StudentDto>);
           }
           #endregion


           #region--Get Element by single Id using StudentDto---
           public StudentDto GetMember(int id)
           {
               var student = context.Students.SingleOrDefault(c => c.StudentId == id);
               if (student == null)
                   throw new HttpResponseException(HttpStatusCode.NotFound);
               return Mapper.Map<Student2, StudentDto>(student);

           }
           #endregion


           #region--Get create Method by using IhttpActionResult---
           [HttpPost]
           //  public MemberDto CreateMember(MemberDto memberDto)
           public IHttpActionResult CreateMember(StudentDto studentDto)
           {
               if (!ModelState.IsValid)
                   // throw new HttpResponseException(HttpStatusCode.BadRequest);
                   return BadRequest();
               var student = Mapper.Map<StudentDto, Student2>(studentDto);
               context.Students.Add(student);
               context.SaveChanges();
               studentDto.StudentId = student.StudentId;
               return Created(new Uri(Request.RequestUri + "/" + student.StudentId), studentDto);
               //      return memberDto();
           }
           #endregion


           #region--Update Method using HttpPut by using StudentDto class---
           [HttpPut]
           public void UpdateMember(int id, StudentDto studentDto)
           {
               if (!ModelState.IsValid)
                   throw new HttpResponseException(HttpStatusCode.BadRequest);
               var studentInDb = context.Students.SingleOrDefault(c => c.StudentId == id);
               if (studentInDb == null)
                   throw new HttpResponseException(HttpStatusCode.NotFound);
               Mapper.Map(studentDto, studentInDb);
               context.SaveChanges();
           }
           #endregion



           #region--Delete Element by  Id using StudentDto class---
           [HttpDelete]
           public void DeleteMember(int id)
           {
               var studentInDb = context.Students.SingleOrDefault(c => c.StudentId == id);
               if (studentInDb == null)
                   throw new HttpResponseException(HttpStatusCode.NotFound);
               context.Students.Remove(studentInDb);
               context.SaveChanges();
           }
           #endregion
           */

        #region--Get all Elemens by using StudentDto---
        //Get All Elements From mapping with memberDTo rather than domain model
        public IEnumerable<StudentDto> GetMembers()
        {
            return context.StudentViewModels.ToList().Select(Mapper.Map<StudentViewModel, StudentDto>);
        }
        #endregion


        #region--Get Element by single Id using StudentDto---
        public StudentDto GetMember(int id)
        {
            var student = context.StudentViewModels.SingleOrDefault(c => c.StudentId == id);
            if (student == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<StudentViewModel, StudentDto>(student);

        }
        #endregion


        #region--Get create Method by using IhttpActionResult---
        [HttpPost]
        //  public MemberDto CreateMember(MemberDto memberDto)
        public IHttpActionResult CreateMember(StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                // throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();
            var student = Mapper.Map<StudentDto, StudentViewModel>(studentDto);
            context.StudentViewModels.Add(student);
            context.SaveChanges();
            studentDto.StudentId = student.StudentId;
            return Created(new Uri(Request.RequestUri + "/" + student.StudentId), studentDto);
            //      return memberDto();
        }
        #endregion


        #region--Update Method using HttpPut by using StudentDto class---
        [HttpPut]
        public void UpdateMember(int id, StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var studentInDb = context.StudentViewModels.SingleOrDefault(c => c.StudentId == id);
            if (studentInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(studentDto, studentInDb);
            context.SaveChanges();
        }
        #endregion



        #region--Delete Element by  Id using StudentDto class---
        [HttpDelete]
        public void DeleteMember(int id)
        {
            var studentInDb = context.StudentViewModels.SingleOrDefault(c => c.StudentId == id);
            if (studentInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            context.StudentViewModels.Remove(studentInDb);
            context.SaveChanges();
        }
        #endregion


      




    }
}
