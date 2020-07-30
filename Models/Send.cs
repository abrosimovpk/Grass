using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GrassForLess.Models;
namespace GrassForLess.Models
{
    public class Send
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int UserId { get; set; }

        public string UserName {get; set;}

        public DateTime DateUpdate { get; set; }

        // количество съеденых спаржей
        public int Count { get; set; }


    }
}