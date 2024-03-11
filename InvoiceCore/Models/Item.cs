namespace InvoiceCore.Models;

public class Item
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public List<Company> Companies { get; } = [];
    public List<Tax> Taxes { get; } = [];
    public List<Invoice> Invoices { get; } = [];
    public List<Inventory> Inventories { get; } = [];
    public List<Taxation> Taxations { get; } = [];
    public List<InvoiceLine> InvoiceLines { get; } = [];
}
