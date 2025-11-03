namespace GSSClient.Domain.Entities
{
    public record User
    {
        public required string Login { get; init; }

        public required string Password { get; init; }
    }
}
