using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Sayfalama.Models
{
    public class mvcPagelistContex : DbContext
  
    {
        public mvcPagelistContex() : base("mesjDb") { }

        public DbSet<mesaj> mesajs { get;set;}
    }
    
}