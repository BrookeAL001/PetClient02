using Microsoft.EntityFrameworkCore;
using PetClient02.Models;

namespace PetClient02.Data
{
    public class ClientsApiDbContext : DbContext
    {
        public ClientsApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}
