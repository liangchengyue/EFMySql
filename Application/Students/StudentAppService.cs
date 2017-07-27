using Core;
using EntityFramwork.EntityFramworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Students
{
    public class StudentAppService
    {
        public void AddStudent()
        {
            var db = new EFMySqlDbConText();
            Student student = new Student();
            student.No = "1400170322";
            student.Name = "梁城月";
            student.Gender = "男";
            db.Students.Add(student);
        }
    }
}
