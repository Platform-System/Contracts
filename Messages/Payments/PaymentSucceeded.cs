namespace Contracts.Messages.Payments;

public sealed class PaymentSucceeded
{
    public Guid MessageId { get; set; }
    public Guid PaymentId { get; set; }
    public string ReferenceType { get; set; } = string.Empty;
    public Guid ReferenceId { get; set; }
    public long ReferenceCode { get; set; }
    public string Provider { get; set; } = string.Empty;
    public string? PaymentLinkId { get; set; }
    public long Amount { get; set; }
    public string Currency { get; set; } = string.Empty;
    public DateTime PaidAt { get; set; }
}
