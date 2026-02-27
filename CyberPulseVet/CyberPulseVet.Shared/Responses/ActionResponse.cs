namespace CyberPulseVet.Shared.Responses;

public sealed class ActionResponse<T>
{
    public bool WasSuccess { get; set; }
    public string? Message { get; set; }
    public T? Result { get; set; }
    public static ActionResponse<T> Success(T? result = default)
        => new()
        {
            WasSuccess = true,
            Result = result
        };

    public static ActionResponse<T> Fail(string message)
        => new()
        {
            WasSuccess = false,
            Message = message
        };
}