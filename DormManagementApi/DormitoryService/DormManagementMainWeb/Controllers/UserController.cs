using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DormManagementMainWeb.Controllers
{
    public class UserController : BaseController
    {
        [HttpGet]
        public OutPutResult<IEnumerable<Student>> List(string no = "", string name = "", string className = "", string subjectName = "", string domitoryNo = "", bool isHaveDomitory = false)
        {
            IEnumerable<Student> students = dbContext.Students.AsEnumerable();

            if (isHaveDomitory)
                students = students.Where(x => x.DomitoryNo.Length > 0);

            if (!string.IsNullOrEmpty(no))
                students = students.Where(x => x.No == no);

            if (!string.IsNullOrEmpty(name))
                students = students.Where(x => x.Name.Contains(name));

            if (!string.IsNullOrEmpty(subjectName))
                students = students.Where(x => x.SubjectName.Contains(subjectName));

            if (!string.IsNullOrEmpty(className))
                students = students.Where(x => x.ClassName.Contains(className));

            if (!string.IsNullOrEmpty(domitoryNo))
                students = students.Where(x => x.DomitoryNo == domitoryNo);
            return OutPutResult<IEnumerable<Student>>.Success(students.ToList());
        }

        [HttpGet]
        public OutPutResult<Student> Get(string no)
        {
            List<Student> students = new List<Student>();

            Expression<Func<Student, bool>> expression = (x => x.No.Length > 0);
            if (string.IsNullOrEmpty(no))
                throw new ExceptionBase("参数no不能为null");

            var student = dbContext.Students.FirstOrDefault(x => x.No == no);
            if (student == null)
                throw new ExceptionBase("不存在此学生");
            return OutPutResult<Student>.Success(student);
        }


        [HttpGet]
        public OutPutResult Add(string no, string name, string subjectName, string className, string sex)
        {
            if (string.IsNullOrEmpty(no))
                throw new ExceptionBase("参数no不能为null");
            if (string.IsNullOrEmpty(name))
                throw new ExceptionBase("参数name不能为null");
            if (string.IsNullOrEmpty(subjectName))
                throw new ExceptionBase("参数subjectName不能为null");
            if (string.IsNullOrEmpty(className))
                throw new ExceptionBase("参数className不能为null");
            if (string.IsNullOrEmpty(sex))
                throw new ExceptionBase("参数sex不能为null");

            if (dbContext.Students.FirstOrDefault(x => x.No == no) != null)
                throw new ExceptionBase("已存在此学号");

            Student student = new Student()
            {
                No = no,
                Name = name,
                Sex = sex,
                SubjectName = subjectName,
                ClassName = className
            };

            dbContext.Students.Add(student);
            if (dbContext.SaveChanges() < 1)
                throw new ExceptionBase("操作失败");

            return OutPutResult.Success();
        }

        [HttpGet]
        public OutPutResult CheckIn(string no, string domitoryNo)
        {
            if (string.IsNullOrEmpty(no))
                throw new ExceptionBase("参数no不能为null");
            if (string.IsNullOrEmpty(domitoryNo))
                throw new ExceptionBase("参数no不能为null");

            var student = dbContext.Students.FirstOrDefault(x => x.No == no);
            if (student == null)
                throw new ExceptionBase("不存在此学生");

            var domitory = dbContext.Domitorys.FirstOrDefault(x => x.No == domitoryNo);
            if (domitory == null)
                throw new ExceptionBase("不存在此宿舍");

            student.DomitoryNo = domitoryNo;
            dbContext.Entry(student).State = EntityState.Modified;
            if (dbContext.SaveChanges() < 1)
                throw new ExceptionBase("操作失败");

            return OutPutResult.Success();
        }

        [HttpGet]
        public OutPutResult CheckOut(string no)
        {
            if (string.IsNullOrEmpty(no))
                throw new ExceptionBase("参数no不能为null");

            var student = dbContext.Students.FirstOrDefault(x => x.No == no);
            if (student == null)
                throw new ExceptionBase("不存在此学生");

            student.DomitoryNo = "";
            dbContext.Entry(student).State = EntityState.Modified;
            if (dbContext.SaveChanges() < 1)
                throw new ExceptionBase("操作失败");

            return OutPutResult.Success();
        }
    }
}
