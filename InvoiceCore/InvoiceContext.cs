using InvoiceCore.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceCore;

public class InvoiceContext : DbContext
{
    private string connectionString;
    public DbSet<Company> Companies { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Tax> Taxes { get; set; }
    public DbSet<Invoice> Invoices { get; set; }

    public InvoiceContext(string connectionString)
    {
        this.connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=" + connectionString);
    }
}
