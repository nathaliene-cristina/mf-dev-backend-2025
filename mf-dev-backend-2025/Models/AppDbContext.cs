using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2025.Models
{
    public class AppDbContext : DbContext //a classe AppDbContext vai herdar todas as características e propriedades do DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } //o DbContextOptions vai receber a classe AppDbContext e passa para a base como herança

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
