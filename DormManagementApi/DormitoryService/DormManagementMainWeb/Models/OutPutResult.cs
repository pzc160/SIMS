using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace DormManagementMainWeb
{
    /// <summary>
    ///接口输出结果对象
    /// </summary>
    public class OutPutResult : ActionResult
    {
        /// <summary>
        ///接口输出结果对象
        /// </summary>
        public OutPutResult() :
            base()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stateCode">状态编码</param>
        /// <param name="stateMsg">状态描述</param>
        public OutPutResult(int stateCode, string stateMsg)
            : this()
        {
            Code = stateCode;
            Msg = stateMsg;
        }

        /// <summary>
        /// 创建一个请求成功的返回结果
        /// </summary>
        /// <returns></returns>
        public static OutPutResult Success()
        {
            return new OutPutResult(0, "");
        }
        /// <summary>
        /// 创建一个请求失败的返回结果
        /// </summary>
        /// <returns></returns>
        public static OutPutResult Fail(string msg,int code=255)
        {
            return new OutPutResult(code, msg);
        }

        /// <summary>
        /// 状态编码
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 状态描述
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = "application/json";
            response.ContentEncoding = Encoding.UTF8;

            JavaScriptSerializer scriptSerializer = new JavaScriptSerializer();
            string jsonResultString = scriptSerializer.Serialize(this);
            //返回值
            response.Write(jsonResultString);
        }
    }

    /// <summary>
    ///泛型接口输出结果对象
    /// </summary>
    public class OutPutResult<T> : OutPutResult
    {
        /// <summary>
        /// 泛型数据
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 接口输出结果对象
        /// </summary>
        /// <param name="stateCode">状态编码</param>
        /// <param name="stateMsg">状态描述</param>
        public OutPutResult(int stateCode, string stateMsg)
            : base(stateCode, stateMsg)
        {
            Data = default(T);
        }

        /// <summary>
        /// 创建一个请求成功的泛型返回结果
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static OutPutResult<T> Success(T t)
        {
            return new OutPutResult<T>(0, "") { Data = t };
        }
    }
}