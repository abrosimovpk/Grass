using GrassForLess.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GrassForLess.Models
{
    public class SendDBInitializer : DropCreateDatabaseAlways<SendContext>
    {
        protected override void Seed(SendContext context) 
        {
            // создание контекста данных
            UserContext db = new UserContext();
            IEnumerable<User> users = db.Users;
            if ( db.Users != null ) 
            {
                foreach( var user in users)
                {
                        context.Sends.Add(new Send { DateUpdate = DateTime.Now, Text = DateTime.Now + user.Name + " ел спаржу 0 раз", UserId = user.Id, UserName = user.Name, Count = 0 });
                }
                

            }
            base.Seed(context);
        }
    }
}