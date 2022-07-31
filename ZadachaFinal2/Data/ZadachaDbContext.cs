using Microsoft.EntityFrameworkCore;
using ZadachaFinal2.Models;

namespace ZadachaFinal2.Data
{
    public class ZadachaDbContext:DbContext
    {
        public ZadachaDbContext(DbContextOptions<ZadachaDbContext> options):base(options)
        {
                
        }
        public DbSet<Zadacha1> zad1 { get; set; }
        public DbSet<Zadacha2> zad2 { get; set; }
        public DbSet<Zadacha3> zad3 { get; set; }
    }
}
