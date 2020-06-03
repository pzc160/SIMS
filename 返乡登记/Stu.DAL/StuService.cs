using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Stu.Models;

namespace Stu.DAL
{
    public class StuService
    {
        public List<Student> GetStudentList()
            {
                string sqlstr = "select * from Stu";
                DataTable dt = DBHelper.GetDataTable(sqlstr);
                List<Student> list = new List<Student>();
                foreach (DataRow r in dt.Rows)
                {
                    Student stu = new Student();
                    stu.ID = int.Parse(r["ID"].ToString());
                    stu.Name = r["name"].ToString();
                    stu.Destination = r["destination"].ToString();
                    stu.Departure_date = r["depature_date"].ToString();
                    stu.Return_date = r["returne_date"].ToString();
                list.Add(stu);
                }
                return list;
            }
            #region 添加学生信息
            /// <summary>
            /// 添加学生信息
            /// </summary>
            /// <param name="newStu">学生</param>
            /// <returns>返回bool值</returns>
            public bool AddStudent(Student newStu)
            {
                string sqlStr = "insert into Stu values(@ID,@name,@destination,@departure_date,@return_date)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ID",newStu.ID),
                new SqlParameter("@name",newStu.Name),
                new SqlParameter("@destination",newStu.Destination),
                new SqlParameter("@departure_date", newStu.Departure_date),
                new SqlParameter("@return_date",newStu.Return_date)
                };
                return DBHelper.ExcuteCommand(sqlStr, param);
            }
            #endregion
            #region 修改学生信息
            /// <summary>
            /// 修改学生信息
            /// </summary>
            /// <param name="stu">学生</param>
            /// <returns>返回bool值</returns>
            public bool UpdateStudent(Student stu)
            {
                string sqlstr = "update Stu set name=@name,destination=@destination departure_date=@departure_date  return_date=@return_date where ID=@id";
                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@ID",stu.ID),
                new SqlParameter("@name",stu.Name),
                new SqlParameter("@destination",stu.Destination),
                new SqlParameter("@departure_date",stu.Departure_date),
                new SqlParameter("@return_date",stu.Return_date)
                };
                return DBHelper.ExcuteCommand(sqlstr, param);
            }
            #endregion
            public bool DelStudent(int id)
            {
                List<String> strSqls = new List<string>();
                List<SqlParameter[]> param = new List<SqlParameter[]>();
                string strDeletel = "DELETE from Stu where ID=@id";

                strSqls.Add(strDeletel);
                SqlParameter[] param1 = new SqlParameter[]
                {
                new SqlParameter("@ID",id)
                };
                param.Add(param1);


                return DBHelper.ExcuteCommand(strSqls, param);
            }
        
    }
}
