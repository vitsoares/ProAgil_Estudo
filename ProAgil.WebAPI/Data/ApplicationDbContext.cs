using Microsoft.EntityFrameworkCore;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Evento> Eventos { get; set; }
    }
}