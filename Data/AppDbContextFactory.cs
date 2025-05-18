using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TarefasApi.Data;

namespace TarefasApi.Data
{
    // A interface IDesignTimeDbContextFactory é usada para criar uma instância do DbContext
    // durante o tempo de design
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite("DataSource=tarefas.db;Cache=Shared");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}

