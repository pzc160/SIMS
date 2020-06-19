using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormManagementMainWeb
{
    public class Domitory : EntityBase
    {
        public string Phone { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public int Count { get { return GetStudentCount(); } }

        public int GetStudentCount()
        {
            int count = 0;
            using (SystemDbContext dbContext = new SystemDbContext())
            {
                count = dbContext.Students.Where(x => x.DomitoryNo == No).Count();
            }
            return count;
        }
    }
}
