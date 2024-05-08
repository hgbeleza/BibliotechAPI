using BibliotechAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotechAPI.Data;

public class BibliotechContext : DbContext
{
    public BibliotechContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
}
