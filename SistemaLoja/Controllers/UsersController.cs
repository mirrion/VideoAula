using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SistemaLoja.Models;
using SistemaLoja.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaLoja.Controllers
{
    public class UsersController : Controller
    {
        private SistemaLojaContext db = new SistemaLojaContext();

        // GET: Users
        public ActionResult Index()
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var users = userManager.Users.ToList();
            var usersView = new List<UserView>();
            foreach(var user in users)
            {
                var userView = new UserView
                {
                    Email = user.Email,
                    Nome = user.UserName,
                    UserId = user.Id
                };
                usersView.Add(userView);
            }
            return View(usersView);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}