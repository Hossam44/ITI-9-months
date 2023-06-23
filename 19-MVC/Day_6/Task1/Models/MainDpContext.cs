using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class MainDpContext:DbContext
    {
        public MainDpContext():base("Myconn")
        {
                
        }
        public DbSet<Client> clints { get; set; }
    }
}