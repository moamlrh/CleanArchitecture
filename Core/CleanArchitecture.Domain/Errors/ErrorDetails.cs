namespace CleanArchitecture.Domain.Errors;


public class ErrorDetail
{
    public ErrorDetail(int statusCode, string message = "Error occurred")
    {
        this.statusCode = statusCode;
        this.message = message;
    }

    public int statusCode { get; set; }
    public string message { get; set; }
}