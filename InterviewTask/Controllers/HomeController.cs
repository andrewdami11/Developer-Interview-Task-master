using InterviewTask.Services;
using System;
using System.Web.Mvc;

namespace InterviewTask.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Prepare your opening times here using the provided HelperServiceRepository class.       
         */
        public ActionResult Index()
        {
            HelperServiceRepository helperServiceRepository = new HelperServiceRepository();
            var model = helperServiceRepository.Get();
            return View(model);
        }
    }
}   