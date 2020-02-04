using practice_ssrp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace practice_ssrp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel log)
        {
            usercontext us = new usercontext();
            us.logins.Add(log);
            us.SaveChanges();
            return View();
        }
    }
}