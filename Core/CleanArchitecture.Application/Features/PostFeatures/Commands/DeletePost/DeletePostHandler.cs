
using MediatR;

namespace CleanArchitecture.Application.Features;

public class DeletePostHandler : INotificationHandler<DeletePostNotification>
{
    public Task Handle(DeletePostNotification notification, CancellationToken cancellationToken)
    {
        // delete the post here
        throw new NotImplementedException();
    }
}
