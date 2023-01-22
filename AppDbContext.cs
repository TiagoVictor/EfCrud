using EfCrud.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCrud.Data;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=D:\\Desenvolvimento\\EfCrud\\app.db;Cache=Shared");
}
