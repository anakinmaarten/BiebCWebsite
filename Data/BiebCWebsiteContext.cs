using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BiebCWebsite.Models;

namespace BiebCWebsite.Data
{
    public class BiebCWebsiteContext : DbContext
    {
        public BiebCWebsiteContext (DbContextOptions<BiebCWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<BiebCWebsite.Models.AdminModel> AdminModel { get; set; } = default!;

        public DbSet<BiebCWebsite.Models.EmployeeModel> EmployeeModel { get; set; } = default!;

        public DbSet<BiebCWebsite.Models.GuestModel> GuestModel { get; set; } = default!;
    }
}
