using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;

namespace Mvc5IdentityAuthorize.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            if(User.Identity.Name!="kevin@gmail.com")
            {
                return Content($"{User.Identity.Name}帳號無權存取此Action動作方法!");
            }            

            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Users = "kevin@gmail.com, mary@gmail.com")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "Admin, Supervisor")]
        public ActionResult Administrators()
        {
            return View();
        }


        public ActionResult ListClaimsInformation()
        {
            ClaimsPrincipal principal = User as ClaimsPrincipal;

            if (principal == null)
            {
                return Content("Principal is null!");
            }

            return View(principal);
        }
    }
}