namespace InvoiceCore.Models;

public class Inventory
{
    public int CompanyId { get; set; }
    public int ItemId { get; set; }
    public decimal Price { get; set; } = 0;
    public int Quantity { get; set; } = 0;
    
    public Company Company { get; set; } = null!;
    public Item Item { get; set; } = null!;
}
