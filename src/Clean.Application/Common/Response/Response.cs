namespace Clean.Application.Common.Response;

public class ApiResponse<T>
{
    public int StatusCode { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
    public bool Status { get; set; }
    public static ApiResponse<T> SendResponse(T data, string message = "", bool status = true, int statusCode = 200)
    {
        var response = new ApiResponse<T> { Data = data, Message = message, Status = status, StatusCode = statusCode };
        return response;
    }
}
