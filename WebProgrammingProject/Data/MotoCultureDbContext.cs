using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebProgrammingProject.Models;

namespace WebProgrammingProject.Data
{
    public class MotoCultureDbContext : IdentityDbContext<UserDetails>
    {
        public MotoCultureDbContext(DbContextOptions<MotoCultureDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebProgrammingProject.Models.ProductViewModel> Products { get; set; }

    }
}
