namespace InvoiceCore.Models;

public class Invoice
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public int CustomerId { get; set; }
    public int InvoiceNumber { get; set; }
    public DateOnly Date { get; set; }
    public string Status { get; set; } = InvoiceStatus.Unpaid.ToString();

    public Company Company { get; set; } = null!;
    public Customer Customer { get; set; } = null!;
    public List<Item> Items { get; } = [];
    public List<InvoiceLine> InvoiceLines { get; } = [];
}
