namespace Platform.Contracts.Messages.Identity;

public sealed class IdentityUserSynced
{
    public Guid UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime OccurredAtUtc { get; set; }
}
