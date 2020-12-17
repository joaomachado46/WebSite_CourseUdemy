using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMvcCore.Models;

namespace WebAppMvcCore.Data
{
    public class WebAppMvcCoreContext : DbContext
    {
        public WebAppMvcCoreContext (DbContextOptions<WebAppMvcCoreContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
        public DbSet<Seller> Sellers { get; set; }

    }
}
