using BLL.StudentActions;
using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayerPattern.Controllers
{
    public class StudentController : Controller
    {
        private AppDbcontext _dbcontext;
        public StudentController(AppDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<IActionResult> Index()
        {
            var student = new Student
            {
      
                StudentName = "ilkin",
                StudentSurname = "Huseynov",
                Age = 32
            };

             await StudentHelper.Addstudent(student,_dbcontext);

            return Content("Student is created");
        }


        /*Without task*/
        //public  IActionResult Index()
        //{
        //    var student = new Student
        //    {

        //        StudentName = "ilkin",
        //        StudentSurname = "Huseynov",
        //        Age = 32
        //    };

        //    StudentHelper.Addstudent(student, _dbcontext);

        //    return Content("Student is created");
        //}
    }
}
