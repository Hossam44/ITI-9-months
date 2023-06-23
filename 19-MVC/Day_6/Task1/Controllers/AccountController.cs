using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Client cl)
        {
            if(ModelState.IsValid)
            {
                MainDpContext context = new MainDpContext();
                context.clints.Add(cl);
                context.SaveChanges();
                var userIdentity = new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name,cl.Name),
                    new Claim(ClaimTypes.Email,cl.Email),
                    new Claim("Password",cl.Password)
                
                }, "appCokie");
                Request.GetOwinContext().Authentication.SignIn(userIdentity);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Client cl)
        {
            ModelState["Name"].Errors.Clear();
            ModelState["Mobile"].Errors.Clear();
            if (ModelState.IsValid)
            {
                MainDpContext context = new MainDpContext();
                var clint1 = context.clints.FirstOrDefault(cli=>cli.Email== cl.Email && cli.Password==cl.Password);
                if(clint1!=null)
                {
                    var userIdentity = new ClaimsIdentity(new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,clint1.Name),
                        new Claim(ClaimTypes.Email,clint1.Email),
                        new Claim("Password",clint1.Password)
                    }, "appCokie");
                    Request.GetOwinContext().Authentication.SignIn(userIdentity);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Email", "Enter Correct Email");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut("appCokie");
            return RedirectToAction("Login");
        }
    }
}