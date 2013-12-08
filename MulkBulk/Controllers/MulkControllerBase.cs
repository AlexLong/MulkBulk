using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MulkBulk.Domain.Abstract;
using MulkBulk.Domain.Concrete;
using MulkBulk.Models;
using MulkBulk.User.Services;
using MulkBulk.User.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MulkBulk.Controllers
{
    public class MulkControllerBase : Controller
    {

        protected IUserService _users;

        protected IContext _context;

        public MulkControllerBase()
        {
            _context = new Context();

            _users = new UserService(_context);
        }


	}
}