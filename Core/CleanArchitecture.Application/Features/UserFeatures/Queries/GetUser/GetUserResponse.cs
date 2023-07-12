namespace CleanArchitecture.Application.Features
{
    public class GetUserResponse
    {
        public Guid Id { get; set; }
        public string UserName { get; set;}
        public string Email { get; set; }
    }
}