using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using JarCreations.Models;

namespace JarCreations.Data
{
    public class JarCreationsContext : DbContext
    {
        public JarCreationsContext(DbContextOptions<JarCreationsContext> options)
            : base(options)
        {
        }

        public DbSet<Jar> Jar { get; set; }
    }
}