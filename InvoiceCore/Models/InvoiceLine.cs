namespace InvoiceCore.Models;

public class InvoiceLine
{
    public int InvoiceId { get; set; }
    public int ItemId { get; set; }
    public decimal Price { get; set; } = 0;
    public int Quantity { get; set; } = 1;

    public Invoice Invoice { get; set; } = null!;
    public Item Item { get; set; } = null!;
}
