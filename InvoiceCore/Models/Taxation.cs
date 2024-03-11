namespace InvoiceCore.Models;

public class Taxation
{
    public int TaxId { get; set; }
    public int ItemId { get; set; }

    public Tax Tax { get; set; } = null!;
    public Item Item { get; set; } = null!;
}
