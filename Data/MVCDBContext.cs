using Microsoft.EntityFrameworkCore;
using sql_server_0326.Models.Entities;

namespace sql_server_0326.Controllers.Data
{
    public class MVCDBContext :DbContext
    {
        public MVCDBContext(DbContextOptions<MVCDBContext> options) : base(options) 
        {
        }

        public DbSet<Customers> Customers { get; set; }
    }
}
