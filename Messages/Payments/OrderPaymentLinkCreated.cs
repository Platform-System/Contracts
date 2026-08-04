namespace Contracts.Messages.Payments;

public sealed class OrderPaymentLinkCreated
{
    public Guid MessageId { get; set; }
    public Guid PaymentId { get; set; }
    public Guid UserId { get; set; }
    public Guid OrderId { get; set; }
    public long OrderCode { get; set; }
    public string Provider { get; set; } = string.Empty;
    public string PaymentLinkId { get; set; } = string.Empty;
    public string CheckoutUrl { get; set; } = string.Empty;
    public long Amount { get; set; }
    public string Currency { get; set; } = string.Empty;
    public DateTime OccurredAt { get; set; }
}
