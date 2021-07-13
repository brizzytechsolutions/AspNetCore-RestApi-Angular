using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAngular.Models;

namespace WebApiAngular.DataContext
{
    public class PackageContext : DbContext
    {
        public DbSet<Package> Packages { get; set; }
        public PackageContext(DbContextOptions<PackageContext> options) : base(options)
        {

        }
    }
}
