#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Login.Models;

namespace DMP.Data
{
    public class LoginContext : DbContext
    {
        public LoginContext (DbContextOptions<LoginContext> options)
            : base(options)
        {
        }

        public DbSet<Login.Models.Login> Login { get; set; }
    }
}
