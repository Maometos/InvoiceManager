namespace InvoiceCore.Models;

public class Company
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public string? Email { get; set; }
    public string? Website { get; set; }
    public string? Address { get; set; }

    public List<Invoice> Invoices { get; } = [];
    public List<Item> Items { get; } = [];
    public List<Inventory> Inventories { get; } = [];
}
