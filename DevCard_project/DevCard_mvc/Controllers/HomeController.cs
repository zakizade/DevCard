using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevCard_mvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_mvc.Controllers
{
    public class HomeController : Controller
    {
               
        public IActionResult Index()
        {
            return View();
        }


		[HttpGet]
		public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }


        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];    
        //return Json(Ok());
        //}


        //[HttpPost]
        //public JsonResult Contact(Contact form) 
        //{
        //    Console.WriteLine(form.ToString());
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(Contact model) 
        {
            //if(ModelState.IsValid == false)
            if (!ModelState.IsValid)
                {
                ViewBag.error = "??????? ???? ??? ???? ????. ???? ?????? ???? ????";
                return View(model);
            }
            ViewBag.success = "????? ??? ?? ?????? ????? ??. ??????";
            return View(model);
            //return RedirectToAction("Index");
        }







        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
