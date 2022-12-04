using FootballLep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace FootballLep.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext context = new MyDbContext();
        // GET: Home
        public ActionResult Index1()
        {
            return View(context.Matches);


        }
        public ActionResult add()

        {

            return View();

        }
        public ActionResult Addnewmatchdetails(Match a)

        {

            context.Matches.Add(a);

            context.SaveChanges();

            return RedirectToAction("Index");

        }



    }
}