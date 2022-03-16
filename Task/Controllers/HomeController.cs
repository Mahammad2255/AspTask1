using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        //public ContentResult Index()
        //{
        //    ContentResult contentResult = new ContentResult();
        //    contentResult.Content = "P225 Content";
        //    contentResult.ContentType = "Get Index";
        //    contentResult.StatusCode = (int?)HttpStatusCode.OK;

        //    return contentResult;

        //}

        //public ViewResult Index()
        //{
        //    ViewResult viewResult = new ViewResult();
        //    viewResult.ViewName = "test";
        //    return viewResult;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
