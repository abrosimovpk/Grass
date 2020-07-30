using GrassForLess.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GrassForLess.Models
{
    public class UserDBInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            context.Users.Add(new User { Name = "Вася", Email = "vasya@ya.ru", Password = "vasya321" });
            context.Users.Add(new User { Name = "Петя", Email = "petya@ya.ru", Password = "petya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            context.Users.Add(new User { Name = "Коля", Email = "kolya@ya.ru", Password = "kolya321" });
            base.Seed(context);
        }
    }
}