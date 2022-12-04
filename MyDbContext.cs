
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Data.Entity;

namespace FootballLep.Models
{
    public class MyDbContext : DbContext
    { 
        public MyDbContext() : base("name=conn")


        {
        }
        public DbSet<Match>Matches{ get; set;}
    }
}