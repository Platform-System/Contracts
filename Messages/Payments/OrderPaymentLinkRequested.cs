namespace Contracts.Messages.Payments;

public sealed class OrderPaymentLinkRequested
{
    public Guid MessageId { get; set; }
    public Guid PaymentId { get; set; }
    public Guid UserId { get; set; }
    public Guid OrderId { get; set; }
    public long OrderCode { get; set; }
    public string Provider { get; set; } = string.Empty;
    public long Amount { get; set; }
    public string Currency { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<OrderPaymentLinkItem> Items { get; set; } = [];
    public DateTime OccurredAt { get; set; }
}
