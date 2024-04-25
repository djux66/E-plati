namespace Eplati;

public class Invoice
{
    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? PaymentPurpose { get; set; }

    public string? Institution { get; set; }

    public string? PaymentCode { get; set; }

    public double Amount { get; set; }

    public string? Account { get; set; }

    public string? Model { get; set; }

    public string? ReferenceNumber { get; set; }

    public DateTime? CurrencyDate { get; set; }

    public string? Currency { get; set; }

    public string? QrCode64 { get; set; }
}
