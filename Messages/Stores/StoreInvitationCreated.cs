namespace Contracts.Messages.Stores;

public sealed class StoreInvitationCreated
{
    public Guid MessageId { get; set; }
    public Guid InvitationId { get; set; }
    public Guid StoreId { get; set; }
    public string StoreName { get; set; } = string.Empty;
    public Guid InvitedUserId { get; set; }
    public Guid InvitedByUserId { get; set; }
    public Guid RoleId { get; set; }
    public string RoleName { get; set; } = string.Empty;
    public DateTime ExpiresAt { get; set; }
    public DateTime OccurredAt { get; set; }
}
