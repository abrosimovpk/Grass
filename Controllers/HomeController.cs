using GrassForLess.Context;
using GrassForLess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace GrassForLess.Controllers
{
    public class HomeController : Controller
    {
        // создание контекста данных
        UserContext userContext = new UserContext();
        SendContext sendContext = new SendContext();

        // количество сообщений на странице/кол-во сообщений за прокрутку
        const int pageSize = 10;

        [Authorize]
        public ActionResult Index(int? id)
        {
            // получаем всех users
            UserContext userContext = new UserContext(); //need?
            IEnumerable<User> users = userContext.Users;
            ViewBag.Users = users;
            ViewBag.User = users.Where(u => u.Name == User.Identity.Name).FirstOrDefault();
            // тк бд локальная можно в сессии хранить юзера не из бд и он типа залогин
            if (ViewBag.User == null)
            {
                // выход юзера и редирект
                FormsAuthentication.SignOut();
                return RedirectToAction("Login", "Account");
            }

            // определяем какую часть постов показать
            int page = id ?? 0;

            // вызов частичного представления при догрузке контента
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Send", GetItemsPage(page));
            }
            ViewBag.PageId = page;
            return View(GetItemsPage(page));
        }


        // получаем посты для добавления
        private List<Send> GetItemsPage(int page = 1)
        {
            int itemsToSkip = page * pageSize;
            IEnumerable<Send> sends = sendContext.Sends;
            ViewBag.Sends = sends;
            return sends.OrderBy(u => u.Id).Skip(itemsToSkip).
                Take(pageSize).ToList();
        }

        [HttpGet]
        [Authorize]
        public bool Send(int id)
        {
            ViewBag.UserId = id;
            
            IEnumerable<Send> sends = sendContext.Sends;
            bool response = false;
            // проверка ел ли юзер до этого спаржу
            Send newSend = null;
            newSend = sendContext.Sends.Where(u => u.UserId == id).FirstOrDefault();
            if (newSend != null)
            {
                newSend.DateUpdate = DateTime.Now;
                newSend.Count++;
                newSend.Text = newSend.DateUpdate + newSend.UserName + " ел спаржу" + newSend.Count + " раз";                
            }
            else
            {
                newSend.DateUpdate = DateTime.Now;
                newSend.Count = 1;
                newSend.UserId = id;
                newSend.UserName = userContext.Users.Where(u => u.Id == id).FirstOrDefault().Name;
                newSend.Text = newSend.DateUpdate + newSend.UserName + " ел спаржу" + newSend.Count + " раз";
                sendContext.Sends.Add(newSend);

            }
            //обновление бд и viewBag
            sendContext.SaveChanges();
            ViewBag.Sends = sends;
            response = true;
            //string html = "< div class=\"container\"> <div class=\"row\"><p>Спасибо," + newSend.UserName + ", что съели спаржу!</p><a class=\"btn btn-default\"  href=../Index>Вернуться</a></div></div>";
            //return base.Content(html, "text/html");

            return response;

        }
    }
}