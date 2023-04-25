using DataAccessLayer.Data;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.StudentActions
{
    public static class StudentHelper
    {
        public static async Task Addstudent (Student model , AppDbcontext _dbcontext)
        {
            if (model!= null)
            {
                _dbcontext.Students.Add(model);
                 await _dbcontext.SaveChangesAsync();
            }
        }


        /*isleyir*/
        //public static void Addstudent(Student model, AppDbcontext _dbcontext)
        //{
        //    if (model != null)
        //    {
        //        _dbcontext.Students.Add(model);
        //        _dbcontext.SaveChanges();
        //    }
        //}
    }
}
