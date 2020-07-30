using GrassForLess.Context;
using GrassForLess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;

namespace GrassForLess.Controllers
{
    public class AccountController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }
        // POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                User newUser = null;
                using (UserContext userContext = new UserContext())
                {
                    userContext.Users.Add(new User { Email = user.Email, Password = user.Password,  Name = user.Name });
                    userContext.SaveChanges();

                    newUser = userContext.Users.Where(u => u.Email == user.Email && u.Password == user.Password && u.Name == user.Name).FirstOrDefault();
                }
                if (newUser != null)
                {
                    FormsAuthentication.SetAuthCookie(user.Name, true);
                    return RedirectToAction("index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Пользователь с таким логином уже существует");
            }
            return View(user);
        }


        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid) 
            {
                User newUser = null;
                using (UserContext userContext = new UserContext())  
                {
                    newUser = userContext.Users.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();
                }
                if (newUser != null)
                {
                    FormsAuthentication.SetAuthCookie(newUser.Name, true);
                    ViewBag.User = newUser;
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь не найден");
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(user);
        }

        //LogOut
        public void Logout()
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }


        // проверка есть ли юзер в бд по имени
        public bool isUserByName(string name)
        {
            UserContext userContext = new UserContext();
            User newUser = null;
            newUser = userContext.Users.Where(u => u.Name == name).FirstOrDefault();
            if (newUser != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // проверка есть ли юзер в бд по email
        public bool isUserByEmail(string email)
        {
            UserContext userContext = new UserContext();
            User newUser = null;
            newUser = userContext.Users.Where(u => u.Email == email).FirstOrDefault();
            if (newUser != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isUser(string name, string email)
        {
            if(!isUserByName(name) && !isUserByEmail(email))
            {
                return false;
            }
            else
            {
                return true;
            }            
        }
    }
}