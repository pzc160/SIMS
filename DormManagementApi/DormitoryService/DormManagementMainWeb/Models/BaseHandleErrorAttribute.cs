
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace DormManagementMainWeb
{
    /// <summary>
    /// 异常过滤器基类
    /// </summary>
    public class BaseHandleErrorAttribute : ExceptionFilterAttribute
    {
        /// <summary>
        /// 捕获异常时处理函数
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnException(HttpActionExecutedContext filterContext)
        {
            ExceptionBase ex = filterContext.Exception as ExceptionBase;
            if (ex != null)
                filterContext.Response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(JsonConvert.SerializeObject(new OutPutResult(ex.Code, ex.Msg)), Encoding.UTF8, "application/json")
                };
            else
                filterContext.Response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(JsonConvert.SerializeObject(OutPutResult.Fail("未知错误")), Encoding.UTF8, "application/json")
                };

            base.OnException(filterContext);
        }


    }
}