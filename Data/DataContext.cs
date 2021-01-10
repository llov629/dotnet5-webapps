using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet5_webapps.Entities;

namespace dotnet5_webapps.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder options)    => options.UseSqlite("DataSource=datingapp.db");

    }
}
