using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyApplication;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<MyApplication.Movie> Movie { get; set; } = default!;
    }
