namespace Gangster.ApiModel.ApiResponse;

public class APIResponse<T>
{
    public int? StatusCode { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }

    public bool Status { get; set; }
    public static APIResponse<T> SendResponse(int? statusCode, string message, T data, bool status = true)
    {
        var response = new APIResponse<T>
        {
            StatusCode = statusCode,
            Message = message,
            Data = data,
            Status = status
        };
        return response;
    }
}
