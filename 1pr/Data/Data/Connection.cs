using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Connection: DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<UserDetail> UserDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=111;Database=PR1_GruznykhND;");  

        }
    }
}
