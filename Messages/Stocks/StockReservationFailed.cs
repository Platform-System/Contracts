namespace Platform.Contracts.Messages.Stocks;

public sealed class StockReservationFailed
{
    public Guid MessageId { get; set; }
    public Guid OrderId { get; set; }
    public DateTime OccurredAt { get; set; }
    public string Reason { get; set; } = string.Empty;
    public List<StockAdjustmentItemMessage> Items { get; set; } = [];
}
