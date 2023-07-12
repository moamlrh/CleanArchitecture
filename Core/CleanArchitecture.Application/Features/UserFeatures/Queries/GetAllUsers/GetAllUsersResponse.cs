namespace CleanArchitecture.Application.Features
{
    public class GetAllUsersResponse
    {
        public Guid Id { get; set; }
        public string UserName { get; set;}
        public string Email { get; set; }
    }
}