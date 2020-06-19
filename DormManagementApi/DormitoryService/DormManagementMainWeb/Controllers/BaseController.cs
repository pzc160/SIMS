using DormManagementMainWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace DormManagementMainWeb.Controllers
{
    [BaseHandleError]
    public class BaseController : ApiController
    {
        public SystemDbContext dbContext;
        public BaseController()
        {
            dbContext = new SystemDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if(dbContext!=null)
                dbContext.Dispose();
        }
    }
}