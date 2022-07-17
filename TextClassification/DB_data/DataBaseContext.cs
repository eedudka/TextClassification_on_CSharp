using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification.DB_data
{
    public class DataBaseContext : DbContext
    {

        public DbSet<SaveClasificationOnDB>? DocumentClassification { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=DocumentClass; User Id=postgres;Password=GxtMBw1488");
        }

    }
}
