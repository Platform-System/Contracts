namespace Contracts.Messages.Stores;

public sealed class StoreReviewCompleted
{
    public Guid MessageId { get; set; }
    public Guid UserId { get; set; }
    public Guid StoreId { get; set; }
    public string StoreName { get; set; } = string.Empty;
    public string ReviewType { get; set; } = string.Empty;
    public bool Approved { get; set; }
    public string? Reason { get; set; }
    public DateTime OccurredAt { get; set; }
}
