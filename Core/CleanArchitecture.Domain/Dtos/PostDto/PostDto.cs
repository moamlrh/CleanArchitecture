
namespace CleanArchitecture.Domain.Dtos;

public class PostDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
}