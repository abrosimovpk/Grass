using GrassForLess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GrassForLess.Context
{
    public class SendContext : DbContext
    {
        public DbSet<Send> Sends { get; set; }
    }
}