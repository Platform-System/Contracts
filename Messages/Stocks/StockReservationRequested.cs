namespace Platform.Contracts.Messages.Stocks;

public sealed class StockReservationRequested
{
    public Guid MessageId { get; set; }
    public Guid OrderId { get; set; }
    public Guid UserId { get; set; }
    public long OrderCode { get; set; }
    public DateTime OccurredAt { get; set; }
    public List<StockAdjustmentItemMessage> Items { get; set; } = [];
}
