using MulkBulk.Domain.Abstract;
using MulkBulk.Domain.Concrete;
using MulkBulk.Domain.Entities;
using MulkBulk.User.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MulkBulk.Controllers
{
    public class HomeController : MulkControllerBase
    {

        public ActionResult Index()
        {

          
            /*
         HttpCookie cookie = new HttpCookie("User");
            
            if(cookie["username"] == null)
            {

                cookie["id"] = "Cookie Test";

                cookie.Expires = DateTime.Now.AddDays(365);


                Response.Cookies.Add(cookie);
            }
             * */

           // _users.ComposeMessage("Hello Buddy", "test");

     //  var user = _users.GetBy("test");


            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}