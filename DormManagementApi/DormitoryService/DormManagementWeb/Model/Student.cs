using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DormManagementWeb
{
    public class Student : EntityBase
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string ClassName { get; set; }
        public string SubjectName { get; set; }
        public string DomitoryNo { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

    }

    public enum Sex
    {
        /// <summary>
        /// 发起退款
        /// </summary>
        [Description("男")]
        Man = 0,
        /// <summary>
        /// 发起退款
        /// </summary>
        [Description("女")]
        WoMan = 1
    }
}
