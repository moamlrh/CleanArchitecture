
using MediatR;

public record DeletePostNotification(Guid Id) : INotification;