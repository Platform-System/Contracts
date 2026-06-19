using System;

namespace Platform.Contracts.Messages.Stores;

public sealed class StoreCreated
{
    public Guid MessageId { get; set; }
    public Guid UserId { get; set; }
    public Guid StoreId { get; set; }
    public DateTime OccurredAt { get; set; }
}
