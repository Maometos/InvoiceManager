namespace InvoiceCore.Models;

public class Tax
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double? Rate { get; set; }

    public List<Item> Items { get; } = [];
    public List<Taxation> Taxations { get; } = [];
}
