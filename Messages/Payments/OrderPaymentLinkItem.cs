namespace Contracts.Messages.Payments;

public sealed class OrderPaymentLinkItem
{
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public long Price { get; set; }
}
