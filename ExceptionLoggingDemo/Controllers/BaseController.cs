﻿using DesignPatternsDemo;
using System.Web.Mvc;

namespace ExceptionLoggingDemo.Controllers
{
    public class BaseController : Controller
    {
        private ILog _Ilog;

        public BaseController()
        {
            _Ilog = Log.GetInstance;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            _Ilog.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }
}