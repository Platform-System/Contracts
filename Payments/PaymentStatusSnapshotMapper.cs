using Platform.Contracts.Messages.Payments;

namespace Platform.Contracts.Payments;

public static class PaymentStatusSnapshotMapper
{
    public static PaymentSucceeded ToPaymentSucceeded(this PaymentStatusSnapshot snapshot)
        => new()
        {
            PaymentId = snapshot.PaymentId,
            ReferenceType = snapshot.ReferenceType,
            ReferenceId = snapshot.ReferenceId,
            ReferenceCode = snapshot.ReferenceCode,
            Provider = snapshot.Provider,
            PaymentLinkId = snapshot.PaymentLinkId,
            Amount = snapshot.Amount,
            Currency = snapshot.Currency,
            PaidAt = snapshot.PaidAt ?? DateTime.UtcNow
        };

    public static PaymentCancelled ToPaymentCancelled(this PaymentStatusSnapshot snapshot, string reasonCode = "RECONCILIATION")
        => new()
        {
            PaymentId = snapshot.PaymentId,
            ReferenceType = snapshot.ReferenceType,
            ReferenceId = snapshot.ReferenceId,
            ReferenceCode = snapshot.ReferenceCode,
            Provider = snapshot.Provider,
            PaymentLinkId = snapshot.PaymentLinkId,
            Amount = snapshot.Amount,
            Currency = snapshot.Currency,
            ReasonCode = reasonCode
        };
}
