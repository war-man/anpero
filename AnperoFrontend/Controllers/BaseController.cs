﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnperoFrontend.Controllers
{
    public class BaseController : Controller
    {
      
      
        
    }
    public class BuildCommonHtml : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
            AnperoService.AnperoService service = new AnperoService.AnperoService();
            var rs= service.GetCommonConfig(CommonConfig.StoreID, CommonConfig.TokenKey);
            filterContext.Controller.ViewData["commonInfo"] = rs;


        }
    }
    public partial class CommonConfig
    {
        public static int StoreID = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["storeID"]);
        public static string TokenKey = System.Configuration.ConfigurationManager.AppSettings["storeTokenKey"];
    }
}