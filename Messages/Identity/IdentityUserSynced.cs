namespace Contracts.Messages.Identity;

public sealed class IdentityUserSynced
{
    public Guid MessageId { get; set; }
    public Guid UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime OccurredAt { get; set; }
}
