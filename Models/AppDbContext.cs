using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2025.Models
{
    public class AppDbContext : DbContext //AppDbContext herda de DbContext, que é a classe base do EF Core responsável por gerenciar o acesso ao banco de dados
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } //O construtor recebe um objeto DbContextOptions<AppDbContext>, que contém as configurações da conexão com o banco (tipo de banco, string de conexão, etc.)
                                                                                        //Essa options é passada para a classe base DbContext através de base(options)
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}


//Nao sera criada as opções manualmente dentro do AppDbContext.
//Em vez disso, elas sao injetadas automaticamente pelo container de serviços do .NET