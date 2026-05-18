namespace Platform.Contracts.Payments;

public sealed class PaymentLinkResponse
{
    public Guid PaymentId { get; set; }
    public string? CheckoutUrl { get; set; }
    public string? PaymentLinkId { get; set; }
    public long Amount { get; set; }
    public string? Currency { get; set; }
    public string Status { get; set; } = string.Empty;
}
