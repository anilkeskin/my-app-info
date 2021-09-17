using AppInfo.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppInfo.Context
{
    public class AppInfoDbContext : DbContext
    {
        public AppInfoDbContext(DbContextOptions<AppInfoDbContext> options) : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Flats> Flats { get; set; }
        public virtual DbSet<Debt> Debts { get; set; }
        public virtual DbSet<Expenses> Expenses { get; set; }
        public virtual DbSet<Announcements> Announcements { get; set; }
    }
}
