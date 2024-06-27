using JewishHairCut.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using JewishHairCut.Models;
namespace JewishHairCut.DAL
{
    public class DataLayer : DbContext
    {
        public DataLayer(string ConnectionString) : base(GetOptions(ConnectionString))
        {
            Database.EnsureCreated();
            if (Users.Count() == 0)
            {
                Seed();
            }
        }
        private void Seed()
        {
            Barbers.Add(new Barber("Ariel Ohana", "0502337666", true));
            SaveChanges();
        }
        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Act> Acts { get; set; }
        public DbSet<ActOption> ActOptions { get; set; }
        public DbSet<Barber> Barbers { get; set; }
        public List<Barber> GetAllBarbersActs
        {
            get
            {
                return Barbers.Include(c=> c.Acts).ToList();
            }
        }
    }
}







