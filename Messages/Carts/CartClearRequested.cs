namespace Contracts.Messages.Carts;

public sealed class CartClearRequested
{
    public Guid MessageId { get; set; }
    public Guid UserId { get; set; }
    public Guid OrderId { get; set; }
    public long OrderCode { get; set; }
    public string Reason { get; set; } = string.Empty;
    public DateTime OccurredAt { get; set; }
}
