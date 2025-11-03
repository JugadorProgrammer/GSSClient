namespace GSSClient.Domain.Results
{
    public enum SingUpResult : byte
    {
        Success,
        InvalidEmail,
        InvalidPassword,
        UserAlreadyExists,
        ConnectionFailed
    }
}
