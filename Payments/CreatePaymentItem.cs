namespace Contracts.Payments;

public sealed class CreatePaymentItem
{
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public long Price { get; set; }
}
