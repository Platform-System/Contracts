namespace Platform.Contracts.Payments;

public sealed class CreatePaymentRequest
{
    public string ReferenceType { get; set; } = string.Empty;
    public Guid ReferenceId { get; set; }
    public long ReferenceCode { get; set; }
    public string Provider { get; set; } = string.Empty;
    public long Amount { get; set; }
    public string Currency { get; set; } = "VND";
    public string Description { get; set; } = string.Empty;
    public List<CreatePaymentItem> Items { get; set; } = [];
    public Guid UserId { get; set; }
}
