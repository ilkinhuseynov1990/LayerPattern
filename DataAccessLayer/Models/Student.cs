using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
   public  class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int Age { get; set; }
    }
}
