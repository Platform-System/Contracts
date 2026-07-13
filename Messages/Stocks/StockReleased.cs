namespace Platform.Contracts.Messages.Stocks;

public sealed class StockReleased
{
    public Guid MessageId { get; set; }
    public Guid OrderId { get; set; }
    public DateTime OccurredAt { get; set; }
    public List<StockAdjustmentItemMessage> Items { get; set; } = [];
}
