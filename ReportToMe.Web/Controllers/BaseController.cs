using ReportToMe.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportToMe.Web.Controllers
{
    public class Controller: System.Web.Mvc.Controller
    {
        protected override JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonCamelCaseResult
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior
            };
            //return base.Json(data, contentType, contentEncoding);
        }


    }


   

}