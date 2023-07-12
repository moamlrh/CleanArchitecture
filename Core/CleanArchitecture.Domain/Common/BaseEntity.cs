using System.Dynamic;
using System;

namespace CleanArchitecture.Domain.Common;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime DeletedDate { get; set; }
    public DateTime CreationDate { get; set; }
}