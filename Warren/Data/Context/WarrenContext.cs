using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class WarrenContext : DbContext
    {
        #region Props
        // Criando essa propriedade o banco de dados irá entender que tem que trabalhar com uma tabela que tem as propriedades da nossa classe
        // Caso não haja uma tabela criada, ele mesmo irá criar
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Planta> Plantas { get; set; }
        public DbSet<Usuario> Usarios { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5435; Database=postgres; UserId=postgres; Password=123456");
        }
    }
}
