using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManagementMainWeb
{
    /// <summary>
    /// 自定义异常基类（所有自定义异常必须继承此基类）
    /// </summary>
    public class ExceptionBase : Exception
    {
        /// <summary>
        /// 自定义异常基类
        /// </summary>
        /// <param name="msg">错误描述</param>
        /// <param name="code">错误编码</param>
        public ExceptionBase(string msg, int code = 255)
            : base(msg)
        {
            Code = code;
            Msg = msg;
        }
        /// <summary>
        /// 获取或者设置错误编码
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 获取或者设置错误描述
        /// </summary>
        public string Msg { get; set; }
    }
}
