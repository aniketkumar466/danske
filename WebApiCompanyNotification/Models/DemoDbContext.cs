using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCompanyNotification.Models
{
    public class DemoDBContext : DbContext
    {
        public DemoDBContext(DbContextOptions<DemoDBContext> options) : base(options)
        {

        }

        public DbSet<Company> Company {get; set; }
        public DbSet<Notification> Notification { get; set; }

    }
}
