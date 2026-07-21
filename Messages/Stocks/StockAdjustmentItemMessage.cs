namespace Contracts.Messages.Stocks;

public sealed class StockAdjustmentItemMessage
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}
