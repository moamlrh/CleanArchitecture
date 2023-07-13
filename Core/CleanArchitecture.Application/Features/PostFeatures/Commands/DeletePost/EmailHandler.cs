using MediatR;

public class EmailHandler : INotificationHandler<DeletePostNotification>
{
    public Task Handle(DeletePostNotification notification, CancellationToken cancellationToken)
    {
        // email send for a user or whatever you could do here
        throw new NotImplementedException(); 
    }
}
