using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Todo.Service;
using TodoApi.Model;
using TodoApi.ViewModels;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public ActionResult Post([FromBody] StudentCM studentCM)
        {
            try
            {
                var student = studentCM.Adapt<Student>();
                _studentService.Create(student);
                _studentService.SaveChange();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            return StatusCode(201);
        }
    }
}
