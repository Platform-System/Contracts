namespace Contracts.Messages.Stocks;

public static class StockMessageTypes
{
    public const string StockReservationRequested = "stock.reservation-requested";
    public const string StockReserved = "stock.reserved";
    public const string StockReservationFailed = "stock.reservation-failed";
    public const string StockReleaseRequested = "stock.release-requested";
    public const string StockReleased = "stock.released";
}
