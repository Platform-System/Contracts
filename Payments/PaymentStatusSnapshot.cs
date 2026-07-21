namespace Contracts.Payments;

public sealed class PaymentStatusSnapshot
{
    public Guid PaymentId { get; init; }
    public string ReferenceType { get; init; } = string.Empty;
    public Guid ReferenceId { get; init; }
    public long ReferenceCode { get; init; }
    public string Provider { get; init; } = string.Empty;
    public string? PaymentLinkId { get; init; }
    public long Amount { get; init; }
    public string Currency { get; init; } = string.Empty;
    public string Status { get; init; } = string.Empty;
    public DateTime? PaidAt { get; init; }
}
