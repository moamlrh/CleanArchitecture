using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;

public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}