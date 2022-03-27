using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DMP.Models;

namespace DMP.Data
{
    public class DMPContext : DbContext
    {
        public DMPContext (DbContextOptions<DMPContext> options)
            : base(options)
        {
            
        }

        public DbSet<DMP.Models.Users> Users { get; set; }

        public DbSet<DMP.Models.Recipes> Recipes { get; set; }

        public DbSet<DMP.Models.Nutrients> Nutrients { get; set; }

        public DbSet<DMP.Models.FavouriteRecipes> FavouriteRecipes { get; set; }

        public DbSet<DMP.Models.Meal_Plans> Meal_Plans { get; set; }
    }
}
