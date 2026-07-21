using Contracts.Messages.Payments;

namespace Contracts.Payments;

public static class PaymentStatusSnapshotMapper
{
    public static PaymentSucceeded ToPaymentSucceeded(this PaymentStatusSnapshot snapshot, DateTime fallbackPaidAt)
        => new()
        {
            MessageId = Guid.CreateVersion7(),
            PaymentId = snapshot.PaymentId,
            ReferenceType = snapshot.ReferenceType,
            ReferenceId = snapshot.ReferenceId,
            ReferenceCode = snapshot.ReferenceCode,
            Provider = snapshot.Provider,
            PaymentLinkId = snapshot.PaymentLinkId,
            Amount = snapshot.Amount,
            Currency = snapshot.Currency,
            PaidAt = snapshot.PaidAt ?? fallbackPaidAt
        };

    public static PaymentCancelled ToPaymentCancelled(this PaymentStatusSnapshot snapshot, string reasonCode = "RECONCILIATION")
        => new()
        {
            MessageId = Guid.CreateVersion7(),
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
