using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDbAPI.Controllers
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        { 
        
        }
        public DbSet<Student> Student { get; set; }
    }
}



