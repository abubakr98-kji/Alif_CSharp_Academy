using Microsoft.EntityFrameworkCore;



namespace Entity_Practice_Part_One
{
    public class ConnectTo:DbContext
    {
        public DbSet<User> Users { get; set; }

        public ConnectTo()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ABUBAKRNAZIRMAD;Database = connecttodb;Trusted_Connection=True;");
        }

        }
    }
