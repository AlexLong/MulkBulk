using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MulkBulk.Controllers
{
    public class UserController : MulkControllerBase
    {
        //
        // GET: /User/
        [Authorize]
        public ActionResult Index(string username)
        {

          


            throw new NotImplementedException("The username: " + username);
           // return View();
        }
	}
}