using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMMON;
using MODEL;

namespace WEB.Controllers
{
    public class LoginController : Controller
    {
        private IGenericRepository<UserInfo> userinfoRespository = new GenericRepository<UserInfo>(new FrameworkDBContext());
        // GET: Login
        public ActionResult Index()
        {
            FrameworkDBContext context = new FrameworkDBContext();
            context.Database.CreateIfNotExists();
            //UserInfo user = new UserInfo() { LoginName = "admin", RealName = "ceshi" };
            // userinfoRespository.Insert(user); 
            return View();
        }
    }
}