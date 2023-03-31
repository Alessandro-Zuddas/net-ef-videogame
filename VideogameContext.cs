using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videogames
{
    public class VideogameContext : DbContext
    {
        public DbSet<SoftwareHouse> SoftwareHouse { get; set; }
        public DbSet<Videogame> Videogame { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ef_videogames_db;Integrated Security=True;Encrypt=False");
        }
    }
}
