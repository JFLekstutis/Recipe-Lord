using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recipe_Lord;

namespace Recipe_Lord.Models
{
    public class Recipe_LordContext : DbContext
    {
        public Recipe_LordContext (DbContextOptions<Recipe_LordContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe_Lord.Recipe> Recipe { get; set; }
    }
}
