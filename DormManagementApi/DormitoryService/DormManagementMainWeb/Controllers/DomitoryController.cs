using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DormManagementMainWeb.Controllers
{
    public class DomitoryController : BaseController
    {
        [HttpGet]
        public OutPutResult<IEnumerable<Domitory>> List(string no = "", string phone = "")
        {
            IEnumerable<Domitory> domitorys = dbContext.Domitorys.AsEnumerable();

            if (!string.IsNullOrEmpty(no))
                domitorys = domitorys.Where(x => x.No == no);

            if (!string.IsNullOrEmpty(phone))
                domitorys = domitorys.Where(x => x.Phone.Contains(phone));

            return OutPutResult<IEnumerable<Domitory>>.Success(domitorys.ToList());
        }

        [HttpGet]
        public OutPutResult Add(string no, string phone)
        {
            if (string.IsNullOrEmpty(no))
                throw new ExceptionBase("参数no不能为null");
            if (string.IsNullOrEmpty(phone))
                throw new ExceptionBase("参数phone不能为null");

            if (dbContext.Domitorys.FirstOrDefault(x => x.No == no) != null)
                throw new ExceptionBase("已存在此宿舍号");

            Domitory domitory = new Domitory()
            {
                No = no,
                Phone = phone
            };

            dbContext.Domitorys.Add(domitory);
            if (dbContext.SaveChanges() < 1)
                throw new ExceptionBase("操作失败");

            return OutPutResult.Success();
        }
    }
}
