using MakineData.Mapping;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MakineData.Context
{
        public class AppDbContext : IdentityDbContext<AppUser>
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("server=М\\SQLEXPRESS; database=CoreBlogDb; integrated security=true;");
                base.OnConfiguring(optionsBuilder);
            }
            public DbSet<Asset> Assets { get; set; }
            public DbSet<AssetCategory> AssetCategories { get; set; }
            public DbSet<Image> Images { get; set; }
            public DbSet<Department> Departments { get; set; }
            public DbSet<RoutineMaintenance> RoutineMaintenances { get; set; }
            public DbSet<RoutineMaintenanceDetail> RoutineMaintenancesDetails { get; set; }
            public DbSet<Warnings> Warnings { get; set; }
            public DbSet<WorkOrders> WorkOrders { get; set; }

		    protected override void OnModelCreating(ModelBuilder builder)
		    {
			    base.OnModelCreating(builder);
			    builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

		    }
	    }
}
