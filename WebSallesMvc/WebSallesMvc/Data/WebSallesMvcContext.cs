using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSallesMvc.Models;

namespace WebSallesMvc.Data
{
    public class WebSallesMvcContext : DbContext
    {
        public WebSallesMvcContext (DbContextOptions<WebSallesMvcContext> options)
            : base(options)
        {
        }

        public DbSet<WebSallesMvc.Models.Departament> Departament { get; set; } = default!;
    }
}
